using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PropertyChangedBindingContext
{
    public class TitleModel : INotifyPropertyChanged
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

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
