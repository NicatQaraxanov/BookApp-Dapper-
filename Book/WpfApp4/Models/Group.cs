using System;
using System.Collections.Generic;

#nullable disable

namespace WpfApp4.Models
{
    public partial class Group
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int IdFaculty { get; set; }

        public virtual Faculty IdFacultyNavigation { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
