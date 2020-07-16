using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestSample
{
    public class Model
    {

        public Model(Unit textSize, string text)
        {
            TextSize = textSize;
            TextSize.ValueChanged += (sender, e) =>
            {
                TextSizeChanged?.Invoke(sender, e);
            };
            Text = text;
        }

        private string text;
        public string Text 
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                TextChanged?.Invoke(this, new EventArgs());
            } 
        }

        public Unit TextSize { get; set; }

        public event EventHandler TextChanged;
        public event EventHandler TextSizeChanged;
    }
}
