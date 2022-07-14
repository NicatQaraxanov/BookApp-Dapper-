using System;
using System.Collections.Generic;

#nullable disable

namespace WpfApp4.Models
{
    public partial class Author
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
