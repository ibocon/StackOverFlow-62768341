using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CustomizeView
{
    public partial class ParentView : ContentView
    {
        public static BindableProperty ChildProperty =
            BindableProperty.Create(
                propertyName: nameof(Child),
                returnType: typeof(ChildView),
                declaringType: typeof(ParentView),
                defaultValue: null,
                propertyChanged: (b, o, n) =>
                {
                    (b as ParentView).Child = (ChildView)n;
                });
        public ChildView Child
        {
            get => (ChildView)GetValue(ChildProperty);
            set => SetValue(ChildProperty, value);
        }

        public ParentView()
        {
            InitializeComponent();
        }
    }
}
