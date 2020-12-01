using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

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

        private TitleModel _titleModel;
        public TitleModel TitleModel
        {
            get => _titleModel;
            set
            {
                _titleModel = value;
                OnPropertyChanged(nameof(TitleModel));
            }
        }

        private static int _count = 0;
        public ICommand TitleCommand =>
            new Command(() => TitleModel = new TitleModel($"TitleModel {_count++}"));

        public ParentViewModel()
        {
            Title = "ParentViewModel";
            TitleModel = new TitleModel($"TitleModel {_count++}");
        }

    }
}
