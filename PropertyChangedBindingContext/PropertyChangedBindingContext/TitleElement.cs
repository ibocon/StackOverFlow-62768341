using System;
using Xamarin.Forms;

namespace PropertyChangedBindingContext
{
    static class TitleElement
    {
        public static readonly BindableProperty TitleProperty =
            BindableProperty.Create(nameof(ITitleElement.Title), typeof(string), typeof(ITitleElement), string.Empty, BindingMode.TwoWay, propertyChanged: OnTitleChanged);
        public static void OnTitleChanged(BindableObject bindable, object oldTitle, object newTitle)
        {
            (bindable as ITitleElement).OnTitleChanged(newTitle as string);
        }

    }
}
