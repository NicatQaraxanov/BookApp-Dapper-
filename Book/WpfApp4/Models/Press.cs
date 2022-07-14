using System;
using System.Collections.Generic;

#nullable disable

namespace WpfApp4.Models
{
    public partial class Press
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
