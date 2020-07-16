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
                propertyName: "TextSize",
                returnType: typeof(float),
                declaringType: typeof(TextView),
                defaultValue: 9999.0f,
                propertyChanged: OnTextSizeChanged);

        private static void OnTextSizeChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var textView = (TextView)bindable;
            textView.SizeLabel.Text = $"TextChanged from {(float)oldValue} to {(float)newValue}";
            // Never executed! even if I change text size, this code does not executed.
        }
        public float TextSize
        {
            get => (float)GetValue(TextSizeProperty);
            set => SetValue(TextSizeProperty, value);
        }

        public TextView()
        {
            InitializeComponent();
        }
    }
}