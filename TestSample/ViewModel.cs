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
                _model.TextChanged += (sender, e) => { RaisePropertyChanged(nameof(Text)); };
                _model.TextSizeChanged += (sender, e) => { RaisePropertyChanged(nameof(TextSize)); };
            });
        }

        public string Text
        {
            get => _model.Text;
            set => _model.Text = value;
        }

        public float TextSize
        {
            get => _model.TextSize.Value;
            set => _model.TextSize.Value = value;
        }

        public override void Prepare(Model parameter)
        {
            throw new NotImplementedException();
        }
    }
}
