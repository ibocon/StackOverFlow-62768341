using System;
namespace PropertyChangedBindingContext
{
    public class ChildViewModel : BaseViewModel
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

        public ChildViewModel()
        {
            Title = "ChildViewModel";
        }
    }
}
