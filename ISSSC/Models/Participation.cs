﻿using System;
using System.Collections.Generic;

namespace ISSSC.Models
{
    public partial class Participation
    {
        public Participation()
        {
            Feedback = new HashSet<Feedback>();
        }

        public int Id { get; set; }
        public int IdEvent { get; set; }
        public int? IdUser { get; set; }

        public virtual Event IdEventNavigation { get; set; }
        public virtual SscisUser IdUserNavigation { get; set; }
        public virtual ICollection<Feedback> Feedback { get; set; }
    }
}
