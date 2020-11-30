using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace PropertyChangedBindingContext
{
    public partial class ParentView : ContentView
    {
        public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(ICommand), typeof(ParentView), null, BindingMode.OneWay);
        //public ICommand TestCommand
        //{
        //    get => (ICommand)GetValue(TestCommandProperty);
        //    set => SetValue(TestCommandProperty, value);
        //}

        public ParentView()
        {
            InitializeComponent();
            _button.Clicked += OnButtonClicked;
            _button.BindingContextChanged += OnButtonBindingContextChanged;
        }

        private void OnButtonBindingContextChanged(object sender, EventArgs e)
        {
            Console.WriteLine($"[PropertyChangedBindingContext] ParentView.OnButtonBindingContextChanged {_button.BindingContext.GetType()}");
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            //Command.Execute(null);
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            //Console.WriteLine($"[PropertyChangedBindingContext] ParentView.OnPropertyChanged {propertyName}");
        }
    }
}
