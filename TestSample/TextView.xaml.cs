using MvvmCross.Forms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextView : MvxContentView
    {
        public static readonly BindableProperty TextProperty =
    BindableProperty.Create(
        propertyName: nameof(Text),
        returnType: typeof(string),
        declaringType: typeof(TextView),
        defaultValue: "Hello, World!",
        propertyChanged: OnTextChanged);

        private static void OnTextChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var textView = (TextView)bindable;
            textView.TextLabel.Text = $"TextChanged from {(string)oldValue} to {(string)newValue}";
        }

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public static readonly BindableProperty TextSizeProperty =
            BindableProperty.Create(
                propertyName: nameof(Unit),
                returnType: typeof(Unit),
                declaringType: typeof(TextView),
                defaultValue: new Unit(9999),
                propertyChanged: OnTextSizeChanged);

        private static void OnTextSizeChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var textView = (TextView)bindable;
            textView.SizeLabel.Text = $"TextChanged from {((Unit)oldValue).Value} to {((Unit)newValue).Value}";
            // Never executed! even if I change text size, this code does not executed.
        }
        public Unit TextSize
        {
            get => (Unit)GetValue(TextSizeProperty);
            set => SetValue(TextSizeProperty, value);
        }

        public TextView()
        {
            InitializeComponent();
        }
    }
}