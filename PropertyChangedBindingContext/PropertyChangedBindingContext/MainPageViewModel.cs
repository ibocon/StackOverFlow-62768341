using System;
namespace PropertyChangedBindingContext
{
    public class MainPageViewModel : BaseViewModel
    {
        public ParentViewModel ParentViewModel { get; set; }

        public MainPageViewModel()
        {
            ParentViewModel = new ParentViewModel();
        }
    }
}
