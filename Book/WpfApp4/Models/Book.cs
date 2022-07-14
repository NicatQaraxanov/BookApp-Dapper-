using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

#nullable disable

namespace WpfApp4.Models
{
    public partial class Book : DependencyObject
    {

        public Book()
        {
            SCards = new List<SCard>();
            Students = new ObservableCollection<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Pages { get; set; }
        public int YearPress { get; set; }
        public int IdThemes { get; set; }
        public int IdCategory { get; set; }
        public int IdAuthor { get; set; }
        public int IdPress { get; set; }
        public string Comment { get; set; }

        public int Quantity
        {
            get { return (int)GetValue(QuantityProperty); }
            set { SetValue(QuantityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Quantity.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty QuantityProperty =
            DependencyProperty.Register("Quantity", typeof(int), typeof(Book), new PropertyMetadata(0));



        public virtual Author IdAuthorNavigation { get; set; }
        public virtual Category IdCategoryNavigation { get; set; }
        public virtual Press IdPressNavigation { get; set; }
        public virtual Theme IdThemesNavigation { get; set; }
        public virtual List<SCard> SCards { get; set; } 
        public virtual ICollection<TCard> TCards { get; set; }

        public virtual ObservableCollection<Student> Students { get; set; }
    }
}
