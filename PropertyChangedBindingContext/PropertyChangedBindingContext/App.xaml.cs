using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PropertyChangedBindingContext
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var mainPageViewModel = new MainPageViewModel();
            MainPage = new MainPage
            {
                BindingContext = mainPageViewModel
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
