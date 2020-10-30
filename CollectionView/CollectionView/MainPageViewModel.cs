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
            "1", "2", "3","4", "5", "6", "7", "8", "9", "10",
            "11", "12", "13","14", "15", "16", "17", "18", "19", "20",
            "21", "22", "23","24", "25", "26", "27", "28", "29", "30",
            "31", "32", "33","34", "35", "36", "37", "38", "39", "40",
            "41", "42", "43","44", "45", "46", "47", "48", "49", "50",
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
