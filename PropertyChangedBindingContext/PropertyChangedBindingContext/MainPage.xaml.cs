using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PropertyChangedBindingContext
{
    public partial class MainPage : ContentPage, ITitleElement
    {
        public new static BindableProperty TitleProperty = TitleElement.TitleProperty;
        public new string Title
        {
            get => GetValue(TitleProperty) as string;
            set => SetValue(TitleProperty, value);
        }
        public void OnTitleChanged(string newTitle)
        {
            _editor.Text = newTitle;
        }

        public MainPage()
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
            Console.WriteLine($"[PropertyChangedBindingContext] MainPage.OnBindingContextChanged {BindingContext.GetType()}");
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            Console.WriteLine($"[PropertyChangedBindingContext] MainPage.OnPropertyChanged {propertyName}");
        }
    }
}
