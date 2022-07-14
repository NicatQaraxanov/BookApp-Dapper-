using WpfApp4.Commands;
using WpfApp4.Stores;
using Dapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp4.Models;
using WpfApp4.Services;

namespace WpfApp4.ViewModels
{

    public class BookViewModel : BaseViewModel
    {

        public ObservableCollection<Book> Books { get; set; }

        public ICommand GetBookCommand { get; set; }

        public ICommand NavigateAddDriver { get; set; }

        public ICommand NavigateUpdateDriver { get; set; }

        public ICommand SearchCommand { get; set; }



        private Book _selectedBook;

        public Book SelectedBook
        {
            get { return _selectedBook; }
            set
            {
                _selectedBook = value;
                SelectedStudent = null;
                OnPropertChanged("SelectedBook");
            }
        }


        private Student _selectedStudent;

        public Student SelectedStudent
        {
            get { return _selectedStudent; }
            set
            {
                _selectedStudent = value;
                OnPropertChanged("SelectedStudent");
            }
        }


        private string _search;

        public string Search
        {
            get { return _search; }
            set
            {
                _search = value;
                //SearchDrivers(_search);
                OnPropertChanged("Search");
            }
        }



        public BookViewModel(NavigationStore navigation)
        {
            GetBookCommand = new RelayCommand(d => GetBookFromStudent());

            using var con = new SqlConnection("Data Source=DESKTOP-J450DMQ; Initial Catalog=Library; Integrated Security=true;");

            var sqlQuery = "SELECT * FROM Books LEFT JOIN S_Cards ON Books.Id = S_Cards.Id_Book LEFT JOIN Students ON Students.Id = S_Cards.Id_Student";

            Books = new ObservableCollection<Book>();

            Books = new ObservableCollection<Book>(con.Query<Book, SCard, Student, Book>(sqlQuery,
                (book, sCard, student) =>
                {
                    if (student != null)
                    {
                        sCard.IdStudentNavigation = student;
                        book.Students.Add(student);
                    }

                    if (sCard != null)
                        book.SCards.Add(sCard);

                    return book;
                }
                ).Distinct<Book>(new MyBookComparer()).ToList());


            //NavigateAddDriver = new UpdateViewCommand<AddDriverViewModel>(navigation, () => new AddDriverViewModel(navigation));
            //NavigateUpdateDriver = new UpdateViewCommand<UpdateDriverViewModel>(navigation, () => new UpdateDriverViewModel(navigation, SelectedDriver));
        }


        public void GetBookFromStudent()
        {
            if (SelectedBook != null && SelectedStudent != null)
            {
                using var con = new SqlConnection("Data Source=DESKTOP-J450DMQ; Initial Catalog=Library; Integrated Security=true;");

                con.Execute("DELETE FROM S_Cards WHERE Id_Student = @id AND Id_Book = @idBook", new { id = SelectedStudent.Id, idBook = SelectedBook.Id });

                con.Execute("UPDATE Books SET Quantity += 1 WHERE Id = @id", new { id = SelectedBook.Id });

                Books.FirstOrDefault(b => b == SelectedBook).Quantity += 1;
                Books.FirstOrDefault(b => b == SelectedBook).Students.Remove(SelectedStudent);
            }
        }


        //public async void SearchDrivers(string Name)
        //{
        //    if (Name.Length > 0)
        //    {
        //        var drivers = await Task.Run(() => context.Drivers.Where(d => d.FirstName.ToLower().StartsWith(Name.ToLower())));

        //        Drivers.Clear();

        //        foreach (var item in drivers)
        //        {
        //            Drivers.Add(item);
        //        }
        //    }
        //    else
        //    {
        //        Drivers.Clear();
        //        foreach (var item in context.Drivers)
        //        {
        //            Drivers.Add(item);
        //        }
        //    }
        //}

    }
}
