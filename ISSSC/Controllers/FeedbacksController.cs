﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.IO;
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using ISSSC.Models;
using ISSSC.Models.Meta;
using ISSSC.Class;
using ISSSC.Attributes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SSCIS.Controllers
{
    /// <summary>
    /// Feedback controller
    /// </summary>
    public class FeedbacksController : Controller
    {
        /// <summary>
        /// Database context
        /// </summary>
        private SscisContext db = new SscisContext();

        /// <summary>
        /// Feedback QR code URL generator
        /// </summary>
        private FeedbackUrlGenerator urlGenerator = new FeedbackUrlGenerator();

        /// <summary>
        /// Feedbacks to CSV converte
        /// </summary>
        private FeedbacksCSVConverter csvConverter = new FeedbacksCSVConverter();

        /// <summary>
        /// Adding new feedback
        /// </summary>
        /// <param name="code">Code from url</param>
        /// <returns>Feedback form view</returns>
        [HttpGet]
        public ActionResult Index(int? code)
        {
            int? eventId = urlGenerator.ResolveEventID(code.ToString());
            if (eventId == null)
            {
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);
            }
            Feedback model = new Feedback() { Id = eventId.Value }; //sending eventID in feedbackID for POST
            return View("Create", model);
        }

        /// <summary>
        /// Saves feedback
        /// </summary>
        /// <param name="model">Feedback model</param>
        /// <returns>Redirection</returns>
        [HttpPost]
        public ActionResult Index(Feedback model)
        {
            int userId = (int)HttpContext.Session.GetInt32("userId");
            int eventID = model.Id;
            Event evnt = db.Event.Find(eventID);
            Feedback feedback = new Feedback() { Text = model.Text };
            Participation part = new Participation() { IdEventNavigation = evnt, IdUser = userId };

            //TODO chyba
            db.Participation.Add(part);
            db.SaveChanges();
            feedback.IdParticipationNavigation = part;
            db.Feedback.Add(feedback);
            db.SaveChanges();

            return RedirectToAction("Sent");
        }

        /// <summary>
        /// Message after sent feedback
        /// </summary>
        /// <returns>View with message</returns>
        [HttpGet]
        public ActionResult Sent()
        {
            return View();
        }

        // GET: Feedbacks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);
            }
            Feedback feedback = db.Feedback.Find(id);
            if (feedback == null)
            {
                return NotFound();
            }
            return View(feedback);
        }

        /// <summary>
        /// Generates QR code of URL for adding feedback to event
        /// </summary>
        /// <param name="id">Event ID</param>
        /// <returns>View with QR code of URL</returns>
        [HttpGet]
        [SSCISAuthorize(AccessLevel = AuthorizationRoles.Tutor)]
        public ActionResult EventQR(int? id)
        {
            if (id == null)
            {
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);
            }

            using (MemoryStream ms = new MemoryStream())
            {
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                string url = urlGenerator.GenerateURL(id.Value, db);
                ViewBag.FeedbackURL = url;
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                using (Bitmap bitMap = qrCode.GetGraphic(20))
                {
                    bitMap.Save(ms, ImageFormat.Png);
                    ViewBag.QRCodeImage = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
                }
            }
            return View();
        }

        /// <summary>
        /// Creates view with form with filter for generating csv file with feedback
        /// </summary>
        /// <returns>View with form</returns>
        [HttpGet]
        [SSCISAuthorize(AccessLevel = AuthorizationRoles.Administrator)]
        public ActionResult Generate()
        {
            return View();
        }

        /// <summary>
        /// Return csv file with feedbacks
        /// </summary>
        /// <param name="model">Filter model</param>
        /// <returns>CSV file</returns>
        [HttpPost]
        [SSCISAuthorize(AccessLevel = AuthorizationRoles.Administrator)]
        public IActionResult Generate(MetaInterval model)
        {
            List<Feedback> feedbacks = db.Feedback.Where(f => f.IdParticipationNavigation.IdEventNavigation.TimeFrom >= model.From && f.IdParticipationNavigation.IdEventNavigation.TimeTo <= model.To).ToList();
            string csv = csvConverter.Convert(feedbacks, db);
            string filename = string.Format("feedback.csv");
            //TODO pokud se nezobrazuje diakritika tak je to starým excelem - neumí UTF-8 (Excel 2019 by to už měl umět defaultně)
            return File(new System.Text.UTF8Encoding().GetBytes(csv), "text/csv", filename);
        }

        /// <summary>
        /// Shows list of feedbacks
        /// </summary>
        /// <param name="model">Interval model</param>
        /// <returns>View with list of feedback</returns>
        [HttpGet]
        [Route("Detail")]
        [SSCISAuthorize(AccessLevel = AuthorizationRoles.Administrator)]
        public ActionResult Detail(int? id)
        {

            if (id == null)
            {
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);
            }

            List<Feedback> feedbacks = db.Feedback.Where(f => f.IdParticipationNavigation.IdEvent == id).ToList();
            return View(feedbacks);
        }


        [HttpPost]
        [SSCISAuthorize(AccessLevel = AuthorizationRoles.Administrator)]
        public IActionResult List(MetaInterval model)
        {
            Statistics statistics = new Statistics();
            List<Event> events = new List<Event>();

            events = db.Event.Where(e => e.TimeFrom >= model.From && e.TimeTo <= model.To).ToList();
            
            foreach (var item in events)
            {
                MetaStat meta = new MetaStat();
                meta.IdSubjectNavigation = item.IdSubjectNavigation;
                statistics.Lessons++;

                if (item.IdSubjectNavigation.Code.Equals("MAT"))
                {
                    statistics.MathLessons++;
                } else if (item.IdSubjectNavigation.Code.Equals("INF"))
                {
                    statistics.InfLessons++;
                } else if (item.IdSubjectNavigation.Code.Equals("MECH"))
                {
                    statistics.MechLessons++;
                }

                int standartLessonLength = int.Parse(db.SscisParam.Where(p => p.ParamKey == SSCISParameters.STANDART_EVENT_LENGTH).Single().ParamValue);
                if(standartLessonLength == 0)
                {
                    standartLessonLength = 2;
                }

                statistics.LessonsHours = statistics.Lessons * standartLessonLength;
                statistics.MathLessonsHours = statistics.MathLessons * standartLessonLength;
                statistics.InfLessonsHours = statistics.InfLessons * standartLessonLength;
                statistics.MechLessonsHours = statistics.MechLessons * standartLessonLength;

                meta.IdTutorNavigation = item.IdTutorNavigation;
                meta.TimeFrom = item.TimeFrom;
                meta.TimeTo = item.TimeTo;
                meta.Id = item.Id;
                meta.IdEventNavigation = item;

                int feedbackCount = db.Participation.Where(p => p.IdEvent == item.Id).Count();
                meta.FeedbacksCount = feedbackCount;

                if (statistics.Event == null)
                {
                    statistics.Event = new List<MetaStat>();
                }

                statistics.Event.Add(meta);
            }

            if(statistics.Event != null)
            {
            statistics.Event.Sort(delegate (MetaStat x, MetaStat y)
            {
                if (x.TimeFrom == null && y.TimeFrom == null) return 0;
                else if (x.TimeFrom == null) return -1;
                else if (y.TimeFrom == null) return 1;
                else return x.TimeFrom.CompareTo(y.TimeFrom);
            });
            }

            return View(statistics);
        }


        [HttpPost]
        [SSCISAuthorize(AccessLevel = AuthorizationRoles.Administrator)]
        public IActionResult LastMontTutors()
        {
            StatisticsTutor statistics = new StatisticsTutor();
            List<Event> events = new List<Event>();
            List<SscisUser> tutors = new List<SscisUser>();


            DateTime start = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, 1, 0, 0, 0, 0);

            DateTime end = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month - 1), 23, 59, 59, 59);

            tutors = db.SscisUser.Where(t => t.IdRoleNavigation.Role.Equals(AuthorizationRoles.Tutor)).ToList();
            events = db.Event.Where(e => e.TimeFrom >= start && e.TimeTo <= end).ToList();

            foreach (var tutor in tutors)
            {
                MetaTutor metaTutor = new MetaTutor();
                metaTutor.Id = tutor.Id;
                metaTutor.IdTutorNavigation = tutor;
                if (statistics.Tutor == null)
                {
                    statistics.Tutor = new List<MetaTutor>();
                }
                statistics.Tutor.Add(metaTutor);

            }


            foreach (var item in events)
            {
                if (item.IsAccepted == true && item.IsCancelled != true)
                {

                    foreach (var storedTutor in statistics.Tutor)
                    {
                        if (item.IdTutor == storedTutor.Id)
                        {
                            if (item.IdSubjectNavigation.Code.Equals("MAT"))
                            {
                                storedTutor.MathLessons++;
                            }
                            else if (item.IdSubjectNavigation.Code.Equals("INF"))
                            {
                                storedTutor.InfLessons++;
                            }
                            else if (item.IdSubjectNavigation.Code.Equals("MECH"))
                            {
                                storedTutor.MechLessons++;
                            }

                            int standartLessonLength = int.Parse(db.SscisParam.Where(p => p.ParamKey == SSCISParameters.STANDART_EVENT_LENGTH).Single().ParamValue);
                            if (standartLessonLength == 0)
                            {
                                standartLessonLength = 2;
                            }

                            storedTutor.Lessons = storedTutor.MathLessons + storedTutor.InfLessons + storedTutor.MechLessons;
                            storedTutor.LessonsHours = storedTutor.Lessons * standartLessonLength;
                        }
                    }

                }
            }

            statistics.Tutor.Sort(delegate (MetaTutor x, MetaTutor y)
            {
                if (x.IdTutorNavigation.Login == null && y.IdTutorNavigation.Login == null) return 0;
                else if (x.IdTutorNavigation.Login == null) return -1;
                else if (y.IdTutorNavigation.Login == null) return 1;
                else return x.IdTutorNavigation.Login.CompareTo(y.IdTutorNavigation.Login);
            });

            return View(statistics);
        }


        [HttpPost]
        [SSCISAuthorize(AccessLevel = AuthorizationRoles.Administrator)]
        public IActionResult TutorList(MetaInterval model)
        {
            StatisticsTutor statistics = new StatisticsTutor();
            List<Event> events = new List<Event>();
            List<SscisUser> tutors = new List<SscisUser>();


            tutors = db.SscisUser.Where(t => t.IdRoleNavigation.Role.Equals(AuthorizationRoles.Tutor)).ToList();
            events = db.Event.Where(e => e.TimeFrom >= model.From && e.TimeTo <= model.To.AddHours(20)).ToList();

            foreach (var tutor in tutors)
            {
                MetaTutor metaTutor = new MetaTutor();
                metaTutor.Id = tutor.Id;
                metaTutor.IdTutorNavigation = tutor;
                if (statistics.Tutor == null)
                {
                    statistics.Tutor = new List<MetaTutor>();
                }
                statistics.Tutor.Add(metaTutor);
                
            }


            foreach (var item in events)
            {
                if (item.IsAccepted == true && item.IsCancelled != true)
                {
                    
                foreach (var storedTutor in statistics.Tutor)
                {
                    if(item.IdTutor == storedTutor.Id)
                    {
                        if (item.IdSubjectNavigation.Code.Equals("MAT"))
                        {
                            storedTutor.MathLessons++;
                        }
                        else if (item.IdSubjectNavigation.Code.Equals("INF"))
                        {
                            storedTutor.InfLessons++;
                        }
                        else if (item.IdSubjectNavigation.Code.Equals("MECH"))
                        {
                            storedTutor.MechLessons++;
                        }

                        int standartLessonLength = int.Parse(db.SscisParam.Where(p => p.ParamKey == SSCISParameters.STANDART_EVENT_LENGTH).Single().ParamValue);
                        if (standartLessonLength == 0)
                        {
                            standartLessonLength = 2;
                        }

                        storedTutor.Lessons = storedTutor.MathLessons + storedTutor.InfLessons + storedTutor.MechLessons;
                        storedTutor.LessonsHours = storedTutor.Lessons * standartLessonLength;
                    }
                }

                }
            }

            statistics.Tutor.Sort(delegate (MetaTutor x, MetaTutor y)
            {
                if (x.IdTutorNavigation.Login == null && y.IdTutorNavigation.Login == null) return 0;
                else if (x.IdTutorNavigation.Login == null) return -1;
                else if (y.IdTutorNavigation.Login == null) return 1;
                else return x.IdTutorNavigation.Login.CompareTo(y.IdTutorNavigation.Login);
            });

            return View(statistics);
        }

        /// <summary>
        /// Disposes cotroller
        /// </summary>
        /// <param name="disposing">Dispose db context</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
