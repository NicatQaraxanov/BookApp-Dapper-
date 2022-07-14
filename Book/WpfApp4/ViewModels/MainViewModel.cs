using WpfApp4.Commands;
using WpfApp4.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp4.ViewModels
{
    class MainViewModel : BaseViewModel
    {

        private readonly NavigationStore _navigation;

        public BaseViewModel SelectedViewModel { get; set; }

        public ICommand NavigateBookCommand { get; set; }

        public ICommand NavigateStudentCommand { get; set; }

        


        public MainViewModel(NavigationStore navigation)
        {
            _navigation = navigation;
            _navigation.SelectedViewModelChanged += OnSelectedViewChanged;
            SelectedViewModel = _navigation.SelectedViewModel;

            NavigateBookCommand = new UpdateViewCommand<BookViewModel>(navigation, () => new BookViewModel(navigation));
            //NavigateCarCommand = new UpdateViewCommand<CarViewModel>(navigation, () => new CarViewModel(navigation));
        }

        protected void OnSelectedViewChanged()
        {
            SelectedViewModel = _navigation.SelectedViewModel;
            OnPropertChanged(nameof(SelectedViewModel));
        }

    }
}
