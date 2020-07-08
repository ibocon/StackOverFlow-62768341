using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestSample
{
    public class ViewModel : MvxViewModel<Model>
    {
        public ViewModel() 
        {
        }

        private Model _model;
        public Model Model
        {
            get => _model;
            set => SetProperty(ref _model, value, () =>
            {
                _model.PropertyChanged += (sender, e) =>
                {
                    RaiseAllPropertiesChanged();
                };
            });
        }

        public string Text
        {
            get => _model.Text;
            set => _model.Text = value;
        }

        public Unit TextSize
        {
            get => _model.TextSize;
            set => _model.TextSize = value;
        }

        public override void Prepare(Model parameter)
        {
            throw new NotImplementedException();
        }
    }
}
