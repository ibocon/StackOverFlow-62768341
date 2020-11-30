using System;
namespace PropertyChangedBindingContext
{
    interface ITitleElement
    {
        string Title { get; set; }
        void OnTitleChanged(string newTitle);
    }
}
