﻿using ISSSC.Models;
using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISSSC.Class
{
    /// <summary>
    /// Class for rendering timetable component
    /// </summary>
    public class TimetableRenderer
    {
        /// <summary>
        /// Renders timetable component
        /// </summary>
        /// <param name="events">List of events to display</param>
        /// <param name="showState">Show state of event</param>
        /// <returns>rendered component</returns>
        public HtmlString Render(List<Event> events, string id = null, bool showState = false)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("<div class=\"table-responsive\">");
            if (id != null)
            {
                builder.Append(string.Format("<table id=\"{0}\" class=\"table table-responsive\">", id));
            }
            else
            {
                builder.Append("<table class=\"table table-responsive\">");
            }
            builder.Append("<tr>");
            builder.Append("<th>Čas od</th>");
            builder.Append("<th>Čas do</th>");
            builder.Append("<th>Poznámka</th>");
            builder.Append("<th>Předmět</th>");
            builder.Append("<th>Tutor</th>");
            if (showState)
            {
                builder.Append("<th>Akceptováno</th>");
                builder.Append("<th>Zrušeno</th>");
            }
            builder.Append("</tr>");

            foreach (var item in events)
            {

                if(item.IsCancelled != null && item.IsCancelled.Value)
                {
                    builder.Append("<tr class=\"canceled-evnt\">");
                } else if (item.IsExtraLesson == true)
                {
                    builder.Append("<tr class=\"extra-evnt\">");
                } else
                {
                    builder.Append("<tr>");
                }
                builder.Append("<td>");
                builder.Append(item.TimeFrom.ToString("d") + " " + item.TimeFrom.ToString("t"));
                builder.Append("</td>");
                builder.Append("<td>");
                builder.Append(item.TimeTo.ToString("d") + " " + item.TimeTo.ToString("t"));
                builder.Append("</td>");
                builder.Append("<td>");
                if(item.IsCancelled == true)
                {
                    builder.Append(item.CancelationComment);
                } else
                {
                    builder.Append(item.ExtraComment);
                }
                builder.Append("</td>");
                builder.Append("<td>");
                builder.Append(item.IdSubjectNavigation.Code);
                builder.Append("</td>");
                builder.Append("<td>");
                builder.Append(item.IdTutorNavigation.Login);
                builder.Append("</td>");
                if (showState)
                {
                    builder.Append("<td>");
                    builder.Append(SSCISHtml.DisplayForBool(item.IsAccepted));
                    builder.Append("</td>");
                    builder.Append("<td>");
                    builder.Append(SSCISHtml.DisplayForBool(item.IsCancelled));
                    builder.Append("</td>");
                }
                builder.Append("</tr>");
            }

            builder.Append("</table>");
            builder.Append("</div>");
            return new HtmlString(builder.ToString());
        }

        /// <summary>
        /// Renders public event timetable component
        /// </summary>
        /// <param name="db">Database context</param>
        /// <param name="weeks">Weeks</param>
        /// <returns>Html component</returns>
        public HtmlString RenderPublic(SscisContext db, int weeks = 0)
        {
            DateTime now = DateTime.Now;
            now.AddDays(7 * weeks);
            DateTime start = _startOfWeek(now, DayOfWeek.Monday);
            DateTime end = start.AddDays(7);

            int month = 1;
            int dbMonth = Convert.ToInt32(db.SscisParam.Where(p => p.ParamKey.Equals(SSCISParameters.TIMETABLEMONTHRANGE)).Single().ParamValue);
            if (dbMonth > month)
            {
                month = dbMonth;
            }

            DateTime endTime = now.AddMonths(month);

            List<Event> events = db.Event.Where(e => e.TimeFrom >= now && e.TimeFrom <= endTime && e.IsAccepted != null && e.IsAccepted.Value).OrderBy(e => e.TimeFrom).ToList();
            return Render(events, "public-timetable");
        }

        /// <summary>
        /// Renders tutors event timetable
        /// </summary>
        /// <param name="db">Database context</param>
        /// <param name="tutorId">Tutor ID</param>
        /// <param name="weeks">Weeks</param>
        /// <returns>Html component</returns>
        public HtmlString RenderTutor(SscisContext db, int tutorId, int weeks = 0)
        {
            DateTime now = DateTime.Now;
            List<Event> events = db.Event.Where(e => e.TimeFrom >= now /*&& e.TimeFrom <= end*/ && e.IdTutor == tutorId).OrderBy(e => e.TimeFrom).ToList();
            return Render(events, "tutor-timetable", true);
        }

        /// <summary>
        /// Finds start day of week
        /// </summary>
        /// <param name="dt">date</param>
        /// <param name="startOfWeek">start day</param>
        /// <returns>start date</returns>
        private DateTime _startOfWeek(DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }

    }
}