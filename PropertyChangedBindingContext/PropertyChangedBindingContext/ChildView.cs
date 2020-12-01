using System;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace PropertyChangedBindingContext
{
    public class ChildView : ContentView, ITitleElement
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
            _label.Text = newTitle;
        }

        private readonly Editor _editor;
        private readonly Label _label;

        public ChildView()
        {
            _editor = new Editor
            {
                BackgroundColor = Color.Blue,
            };
            _editor.TextChanged += OnEditorTextChanged;

            _label = new Label
            {
                BackgroundColor = Color.AliceBlue,
            };


            Content = new StackLayout
            {
                Children = { _label, _editor }
            };
        }

        private void OnEditorTextChanged(object sender, TextChangedEventArgs e)
        {
            Title = e.NewTextValue;
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            Console.WriteLine($"[PropertyChangedBindingContext] ChildView.OnBindingContextChanged {BindingContext?.GetType()}");
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            Console.WriteLine($"[PropertyChangedBindingContext] ChildView.OnPropertyChanged {propertyName}");
        }
    }
}

