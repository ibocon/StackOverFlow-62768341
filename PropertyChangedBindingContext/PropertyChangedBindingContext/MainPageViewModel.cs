using System;
namespace PropertyChangedBindingContext
{
    public class MainPageViewModel : BaseViewModel
    {
        private string _title;
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        private ParentViewModel _parentViewModel;
        public ParentViewModel ParentViewModel
        {
            get => _parentViewModel;
            set
            {
                _parentViewModel = value;
                OnPropertyChanged(nameof(ParentViewModel));
            }
        }

        public MainPageViewModel()
        {
            Title = "MainPageViewModel";
            ParentViewModel = new ParentViewModel();
        }
    }
}
