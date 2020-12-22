using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using Xamarin.Forms;

namespace StyleDoesNotApply
{
    public class MyView : ContentView
    {
        private readonly StackLayout _layout;
        public ObservableCollection<View> Views { get; set; }

        public MyView()
        {
            Views = new ObservableCollection<View>();
            Views.CollectionChanged += OnViewsCollectionChanged;

            _layout = new StackLayout();
            Content = _layout;
        }

        private void OnViewsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.OldItems != null)
                foreach (View view in e.OldItems)
                    _layout.Children.Remove(view);

            if (e.NewItems != null)
                foreach (View view in e.NewItems)
                    _layout.Children.Add(view);
        }
    }
}

