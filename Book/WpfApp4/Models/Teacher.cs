using System;
using System.Collections.Generic;

#nullable disable

namespace WpfApp4.Models
{
    public partial class Teacher
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int IdDep { get; set; }

        public virtual Department IdDepNavigation { get; set; }
        public virtual ICollection<TCard> TCards { get; set; }
    }
}
