using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestSample
{
    public class MainPageViewModel : MvxViewModel
    {
        private Model _model;
        private Unit _unit;
        public ViewModel ViewModel { get; set; }
        public override async Task Initialize()
        {
            await base.Initialize();

            _unit = new Unit(0);
            _model = new Model(_unit, "A");
            ViewModel = new ViewModel
            {
                Model = _model
            };
        }

        public IMvxCommand Command => new MvxCommand(() =>
        {
            var c = Convert.ToChar(_model.Text);
            _model.Text = Convert.ToString(++c);
            _unit.Value += 1;
        });
    }
}
