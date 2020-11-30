using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PropertyChangedBindingContext
{
    public class ParentViewModel : BaseViewModel
    {
        private string _title;
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        private ChildViewModel _childViewModel;
        public ChildViewModel ChildViewModel
        {
            get => _childViewModel;
            set
            {
                _childViewModel = value;
                OnPropertyChanged(nameof(ChildViewModel));
            }
        }

        public ParentViewModel()
        {
            Title = "ParentViewModel";
            ChildViewModel = new ChildViewModel();
        }

    }
}
