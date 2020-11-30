using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace PropertyChangedBindingContext
{
    public class ParentViewModel : BaseViewModel
    {
        //private int count = 0;
        public ICommand InitCommand => new Command(
            () =>
            {
                Console.WriteLine("Hello, World!");
                //TitleModel = new TitleModel($"Hello, {count++}!");
            }
        );

        //public TitleModel TitleModel { get; set; }

        public ParentViewModel()
        {
            //TitleModel = new TitleModel($"Fuck, {count++}!");
        }

    }
}
