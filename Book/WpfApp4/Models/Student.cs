using System;
using System.Collections.Generic;

#nullable disable

namespace WpfApp4.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int IdGroup { get; set; }
        public int Term { get; set; }

        public virtual Group IdGroupNavigation { get; set; }
        public virtual ICollection<SCard> SCards { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

    }
}
