using System;
using System.Windows.Input;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace CollectionViewTest
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<object> _itemSource;
        public ObservableCollection<object> ItemSource => _itemSource;

        public MainPageViewModel()
        {
            _itemSource = new ObservableCollection<object>();
            for (int i = 0; i < 28; i++)
                _itemSource.Add(new object());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
