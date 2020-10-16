using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CustomizeView
{
    public partial class ChildView : ContentView
    {
        public static BindableProperty TextProperty =
            BindableProperty.Create(
                propertyName: nameof(Text),
                returnType: typeof(string),
                declaringType: typeof(ChildView),
                defaultValue: string.Empty,
                propertyChanged: (b, o, n) =>
                {
                    (b as ChildView).Label.Text = (string)n;
                });
        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public ChildView()
        {
            InitializeComponent();
        }
    }
}
