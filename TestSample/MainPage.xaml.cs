using MvvmCross.Binding.BindingContext;
using MvvmCross.Forms.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MvxContentPage<MainPageViewModel>
    {


        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();

            using (var set = this.CreateBindingSet<MainPage, MainPageViewModel>())
            {
                set.Bind(TextView)
                    .For(view => view.DataContext)
                    .To(viewModel => viewModel.ViewModel);
            }

        }
    }
}
