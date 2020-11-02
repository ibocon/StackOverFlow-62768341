using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace CollectionView
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private readonly IList<string> _titles = new List<string>
        {
            "1", "2", "3","4", "5", "6", "7", "8"
        };

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public ObservableCollection<Item> Items { get; set; }

        public MainPageViewModel()
        {
            Items = new ObservableCollection<Item>();

            foreach (var title in _titles)
                Items.Add(new Item(title));
        }
    }
}
