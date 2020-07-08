using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestSample
{
    public class Model : MvxNotifyPropertyChanged
    {
        private Unit _textSize;
        private string _text;

        public Model(Unit textSize, string text)
        {
            _textSize = textSize;
            _textSize.PropertyChanged += (sender, e) =>
            {
                RaiseAllPropertiesChanged();
            };
            _text = text;
        }

        public string Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }

        public Unit TextSize
        {
            get => _textSize;
            set => SetProperty(ref _textSize, value);
        }
    }
}
