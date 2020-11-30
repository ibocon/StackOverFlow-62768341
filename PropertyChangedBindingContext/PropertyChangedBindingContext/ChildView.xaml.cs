using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace PropertyChangedBindingContext
{
    public partial class ChildView : ContentView, ITitleElement
    {
        public static BindableProperty TitleProperty = TitleElement.TitleProperty;
        public string Title
        {
            get => GetValue(TitleProperty) as string;
            set => SetValue(TitleProperty, value);
        }
        public void OnTitleChanged(string newTitle)
        {
            _editor.Text = newTitle;
        }

        public ChildView()
        {
            InitializeComponent();
            _editor.TextChanged += OnEditorTextChanged;
        }

        private void OnEditorTextChanged(object sender, TextChangedEventArgs e)
        {
            Title = e.NewTextValue;
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            Console.WriteLine($"[PropertyChangedBindingContext] ChildView.OnBindingContextChanged {BindingContext.GetType()}");
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            Console.WriteLine($"[PropertyChangedBindingContext] ChildView.OnPropertyChanged {propertyName}");
        }


    }
}
