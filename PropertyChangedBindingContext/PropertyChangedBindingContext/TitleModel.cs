using System;
namespace PropertyChangedBindingContext
{
    public class TitleModel : BaseViewModel
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

        public TitleModel(string title)
        {
            Title = title;
        }
    }
}
