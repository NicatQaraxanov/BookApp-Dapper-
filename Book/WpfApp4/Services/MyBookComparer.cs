using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp4.Models;

namespace WpfApp4.Services
{
    public class MyBookComparer : IEqualityComparer<Book>
    {
        public bool Equals(Book x, Book y)
        {
            if (x.Id == y.Id)
            {
                x.SCards.AddRange(y.SCards);
                foreach (var item in y.Students)
                {
                    x.Students.Add(item);
                }
                return true;
            }
            else
                return false;
        }

        public int GetHashCode(Book obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
