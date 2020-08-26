using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EditorFocusManipulation
{
    public partial class MyView : ContentView
    {
        public MyView()
        {
            InitializeComponent();
            Editor.Unfocused += OnEditorUnfocused;
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            IsVisible = false;
        }

        private async void OnEditorUnfocused(object sender, FocusEventArgs e)
        {
            if (IsVisible)
            {
                await FocusEditorAsync();
                Console.WriteLine($"<Unfocused> Editor: Focused {Editor.IsFocused}");
            }
        }

        private async Task FocusEditorAsync()
        {
            Console.WriteLine($"<FocusEditor> START {Editor.IsFocused}");

            while (!Editor.IsFocused)
            {
                Editor.Focus();
                await Task.Delay(100);
                Console.WriteLine($"<FocusEditor> PROGRESS {Editor.IsFocused}");
            }
            Console.WriteLine($"<FocusEditor> END {Editor.IsFocused}");
        }

        private async Task UnfocusEditorAsync()
        {
            Console.WriteLine($"<!UnfocusEditor> START {Editor.IsFocused}");
            while (Editor.IsFocused)
            {
                Editor.Unfocus();
                await Task.Delay(100);
                Console.WriteLine($"<!UnfocusEditor> PROGRESS {Editor.IsFocused}");
            }

            Console.WriteLine($"<!UnfocusEditor> END {Editor.IsFocused}");
        }

        protected override void OnPropertyChanging([CallerMemberName] string propertyName = null)
        {
            if (propertyName.Equals("IsVisible") && IsVisible)
            {
                Console.WriteLine($"<IsVisibleChanging> InputView: IsVisible ({IsVisible}) -> {!IsVisible}");
            }

            base.OnPropertyChanging(propertyName);
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (propertyName.Equals("IsVisible") && IsVisible)
            {
                Console.WriteLine($"<IsVisibleChanged> InputView: IsVisible {!IsVisible} -> ({IsVisible})");
            }

            base.OnPropertyChanged(propertyName);
        }
    }
}
