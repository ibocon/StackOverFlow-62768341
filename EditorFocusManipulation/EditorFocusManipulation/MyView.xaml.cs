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

        private void OnEditorUnfocused(object sender, FocusEventArgs e)
        {
            if (!Editor.IsVisible)
            {
                Editor.Unfocus();
                Console.WriteLine($"<Unfocused> Editor: Focused {Editor.IsFocused}");
            }
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (propertyName == nameof(IsVisible))
            {
                if (IsVisible)
                {
                    Editor.Focus();
                    Editor.Unfocused += OnEditorUnfocused;
                }
                else
                {
                    Editor.Unfocused -= OnEditorUnfocused;
                    Editor.Unfocus();
                }
                Console.WriteLine($"<IsVisibleChanged> InputView: IsVisible {!IsVisible} -> ({IsVisible})");
            }
            base.OnPropertyChanged(propertyName);
        }
    }
}
