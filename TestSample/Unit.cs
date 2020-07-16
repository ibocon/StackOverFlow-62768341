using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestSample
{
    public class Unit
    {
        protected float _value;

        public Unit(float value)
        {
            _value = value;
        }

        public float Value
        {
            get => _value;
            set 
            {
                _value = value;

                ValueChanged?.Invoke(this, new EventArgs());
            } 
        }

        public event EventHandler ValueChanged;
    }
}
