using System;
using System.Collections.Generic;

#nullable disable

namespace WpfApp4.Models
{
    public partial class SCard
    {
        public int Id { get; set; }
        public int IdStudent { get; set; }
        public int IdBook { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime? DateIn { get; set; }
        public int IdLib { get; set; }

        public virtual Book IdBookNavigation { get; set; }
        public virtual Lib IdLibNavigation { get; set; }
        public virtual Student IdStudentNavigation { get; set; }

        public override string ToString()
        {
            return IdStudentNavigation.FirstName + " " + IdStudentNavigation.LastName;
        }
    }
}
