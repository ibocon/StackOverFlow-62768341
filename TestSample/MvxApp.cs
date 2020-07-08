using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestSample
{
    public class MvxApp : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            RegisterAppStart<MainPageViewModel>();
        }
    }
}
