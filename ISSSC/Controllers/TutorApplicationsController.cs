﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using ISSSC.Models;
using ISSSC.Models.Meta;
using ISSSC.Class;
using ISSSC.Attributes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;

namespace ISSSC.Controllers
{
    /// <summary>
    /// Controller for tutors applications UCs
    /// </summary>
    public class TutorApplicationsController : Controller
    {
        /// <summary>
        /// Database context
        /// </summary>
        private SscisContext db = new SscisContext();

        /// <summary>
        /// Injection of email service
        /// </summary>
        private readonly IEmailService _emailService;

        /// <summary>
        /// Injection of config
        /// </summary>
        readonly IConfiguration _configuration;


        public TutorApplicationsController(IEmailService emailService, IConfiguration configuration)
        {
            _configuration = configuration;
            _emailService = emailService;
        }

        /// <summary>
        /// Index UC - list of tutors applications
        /// </summary>
        /// <returns>List of tutors applications view</returns>
        [HttpGet]
        [SSCISAuthorize(AccessLevel = AuthorizationRoles.Administrator)]
        public ActionResult Index()
        {
            var tutorApplication = db.TutorApplication.Include(t => t.AcceptedBy).Include(t => t.IdUserNavigation).Where(t => t.IsAccepted == null);
            return View(tutorApplication.ToList());
        }

        /// <summary>
        /// Detail of tutor application
        /// </summary>
        /// <param name="id">Application ID</param>
        /// <returns>View with details of application</returns>
        [HttpGet]
        [SSCISAuthorize(AccessLevel = AuthorizationRoles.Administrator)]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new StatusCodeResult((int)HttpStatusCode.NotFound);
            }
            TutorApplication tutorApplication = db.TutorApplication.Find(id);
            if (tutorApplication == null)
            {
                return NotFound();
            }
            MetaTutorApplication model = new MetaTutorApplication
            {
                Application = tutorApplication
            };
            List<TutorApplicationSubject> subjects = db.TutorApplicationSubject.Where(s => s.IdApplication == tutorApplication.Id).Include(a => a.IdSubjectNavigation).ToList();
            model.ApplicationSubjects = subjects;
            return View(model);
        }

        /// <summary>
        /// Creation of Tutor Application
        /// </summary>
        /// <returns>View with form</returns>
        [HttpGet]
        public ActionResult Create()
        {
            string text = db.SscisParam.Where(p => p.ParamKey.Equals(SSCISParameters.CHCIPOMAHATHTML)).Single().ParamValue;
            ViewBag.TextHelp = WebUtility.HtmlDecode(text);
            if (HttpContext.Session.GetString("role") == null) return View("Create_public");

            int userID = (int) HttpContext.Session.GetInt32("userId");
            if (db.TutorApplication.Where(a => a.IdUser == userID && a.IsAccepted == null).Count() > 0)
            {
                return RedirectToAction("ApplicationPending");
            }

            int countOfSubjects = db.EnumSubject.Count(s => s.IdParent != null && s.Lesson == true);

            MetaTutorApplication model = new MetaTutorApplication(countOfSubjects);

            SscisUser user = db.SscisUser.Find(userID);
            model.Application.IdUserNavigation = user;
            ViewBag.SubjectID = new SelectList(db.EnumSubject.Where(s => s.Lesson != null && s.Lesson.Value).ToList(), "Id", "Code");
            ViewBag.AcceptedByID = new SelectList(db.SscisUser, "Id", "Login");
            ViewBag.UserID = new SelectList(db.SscisUser, "Id", "Login");
            ViewBag.Degree = new SelectList(ApplicationDegrees.Degrees);
            return View(model);
        }

        /// <summary>
        /// Creation of Tutor application
        /// </summary>
        /// <param name="model">Application model</param>
        /// <returns>Result of creation</returns>
        /// 
        [HttpPost]
        [ValidateAntiForgeryToken]
        [SSCISAuthorize(AccessLevel = AuthorizationRoles.User)]
        public ActionResult Create(MetaTutorApplication model)
        {
            if (ModelState.IsValid)
            {

                int userID = (int)HttpContext.Session.GetInt32("userId");
                int countOfSubjects = int.Parse(Request.Form["subjects_count"]);

                if (countOfSubjects < 1)
                {
                    return RedirectToAction("Create");
                }

                model.Application.ApplicationDate = DateTime.Now;
                model.Application.IdUserNavigation = db.SscisUser.Find(userID);
                db.TutorApplication.Add(model.Application);
                db.SaveChanges();

                string znamky = Request.Form["Degree"];
                string predmety = HttpContext.Request.Form["SubjectID"];

                string[] znamkyPole = znamky.Split(',');
                string[] predmetyPole = predmety.Split(',');

                for (int i = 0; i <= countOfSubjects; i++)
                {
                    TutorApplicationSubject s = new TutorApplicationSubject();

                    s.IdApplicationNavigation = model.Application;
                    s.IdSubjectNavigation = db.EnumSubject.Find(Int32.Parse(predmetyPole[i]));
                    
                    byte.TryParse(znamkyPole[i], out byte deg);
                    if (deg == 0)
                    {
                        s.Degree = null;
                    }
                    else
                    {
                        s.Degree = deg;
                    }
                    db.TutorApplicationSubject.Add(s);
                    db.SaveChanges();
                }
                return RedirectToAction("Applied");
            }

            ViewBag.AcceptedByID = new SelectList(db.SscisUser, "ID", "Login", model.Application.AcceptedById);
            ViewBag.UserID = new SelectList(db.SscisUser, "ID", "Login", model.Application.IdUser);
            return View(model.Application);
        }

        /// <summary>
        /// Acceptation of pendind tutor application
        /// </summary>
        /// <param name="id">Applications ID</param>
        /// <returns>View</returns>
        [HttpGet]
        [SSCISAuthorize(AccessLevel = AuthorizationRoles.Administrator)]
        public ActionResult Accept(int? id)
        {
            if (id == null)
            {
                return new StatusCodeResult((int)HttpStatusCode.NotFound);
            }
            TutorApplication tutorApplication = db.TutorApplication.Find(id);
            if (tutorApplication == null)
            {
                return NotFound();
            }
            int? userID = (int)HttpContext.Session.GetInt32("userId");
                                 
            tutorApplication.AcceptedDate = DateTime.Now;
            tutorApplication.IsAccepted = 1;
            tutorApplication.AcceptedBy = db.SscisUser.Find(userID);
            db.SaveChanges();

            tutorApplication.IdUserNavigation.IdRoleNavigation = db.EnumRole.Where(r => "TUTOR".Equals(r.Role)).Single();
            tutorApplication.IdUserNavigation.IsActivatedBy = userID;
            db.SaveChanges();

            List<TutorApplicationSubject> subjects = db.TutorApplicationSubject.Where(s => s.IdApplication == id).ToList();
            List<EnumSubject> parents = new List<EnumSubject>();
            foreach (TutorApplicationSubject subject in subjects)
            {
                if (subject.IdSubjectNavigation.IdParentNavigation != null && !parents.Contains(subject.IdSubjectNavigation.IdParentNavigation))
                {
                    parents.Add(subject.IdSubjectNavigation.IdParentNavigation);
                }
            }
            foreach (EnumSubject subject in parents)
            {
                Approval app = new Approval();
                app.IdTutorNavigation = tutorApplication.IdUserNavigation;
                app.IdSubjectNavigation = subject;
                db.Approval.Add(app);
                db.SaveChanges();
            }

            EmailMessage emailMessage = new EmailMessage();

            EmailAddress emailTo = new EmailAddress();
            emailTo.Address = tutorApplication.IdUserNavigation.Email;
            List<EmailAddress> listTo = new List<EmailAddress>();
            listTo.Add(emailTo);
            emailMessage.ToAddresses = listTo;

            emailMessage.Subject = _configuration.GetValue<string>("EmailMessageConfigs:AcceptApplicationEmail:Subject");
            emailMessage.Content = _configuration.GetValue<string>("EmailMessageConfigs:AcceptApplicationEmail:Content");

            _emailService.Send(emailMessage);

            return RedirectToAction("Index");
        }

        /// <summary>
        /// Declines tutor application
        /// </summary>
        /// <param name="id">Application ID</param>
        /// <returns>View</returns>
        [HttpGet]
        [SSCISAuthorize(AccessLevel = AuthorizationRoles.Administrator)]
        public ActionResult Decline(int? id)
        {
            if (id == null)
            {
                return new StatusCodeResult((int)HttpStatusCode.NotFound);
            }
            TutorApplication tutorApplication = db.TutorApplication.Find(id);
            if (tutorApplication == null)
            {
                return NotFound();
            }
            tutorApplication.AcceptedDate = DateTime.Now;
            tutorApplication.IsAccepted = 0;
            tutorApplication.AcceptedBy = db.SscisUser.Find(HttpContext.Session.GetInt32("userId"));
            db.SaveChanges();

            EmailMessage emailMessage = new EmailMessage();

            EmailAddress emailTo = new EmailAddress();
            emailTo.Address = tutorApplication.IdUserNavigation.Email;
            List<EmailAddress> listTo = new List<EmailAddress>();
            listTo.Add(emailTo);
            emailMessage.ToAddresses = listTo;

            emailMessage.Subject = _configuration.GetValue<string>("EmailMessageConfigs:DeclineApplicationEmail:Subject");
            emailMessage.Content = _configuration.GetValue<string>("EmailMessageConfigs:DeclineApplicationEmail:Content");

            _emailService.Send(emailMessage);

            return RedirectToAction("Index");
        }

        /// <summary>
        /// Shows view with message of just created application
        /// </summary>
        /// <returns>View</returns>
        [HttpGet]
        public ActionResult Applied()
        {
            return View();
        }

        /// <summary>
        /// Shows view with message for pending application
        /// </summary>
        /// <returns>View</returns>
        [HttpGet]
        public ActionResult ApplicationPending()
        {
            return View();
        }

        /// <summary>
        /// Disposes controller
        /// </summary>
        /// <param name="disposing">disposing db value</param>
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
