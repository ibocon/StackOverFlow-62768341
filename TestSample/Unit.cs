using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestSample
{
    public class Unit : MvxNotifyPropertyChanged
    {
        protected float _value;

        public Unit(float value)
        {
            _value = value;
        }

        public float Value
        {
            get => _value;
            set => SetProperty(ref _value, value);
        }
    }
}
