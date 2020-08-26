using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EditorFocusManipulation
{
    public partial class MyView : ContentView
    {
        private Task _focusEditorTask;
        private Task _unfocusEditorTask;

        public event EventHandler LostFocused;

        public MyView()
        {
            InitializeComponent();

            _focusEditorTask = _unfocusEditorTask = Task.CompletedTask;
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            IsVisible = false;
        }

        private void OnEditorUnfocused(object sender, FocusEventArgs e)
        {
            if (IsVisible)
            {
                FocusEditor();
                Console.WriteLine($"<Unfocused> Editor: Focused {Editor.IsFocused}");
            }
        }

        private void FocusEditor()
        {
            _unfocusEditorTask.Wait();
            _focusEditorTask.Wait();

            _focusEditorTask = Task.Factory.StartNew(async () =>
            {
                Console.WriteLine($"<FocusEditor> START {Editor.IsFocused}");

                while (!Editor.IsFocused)
                {
                    Editor.Focus();
                    await Task.Delay(100);
                    Console.WriteLine($"<FocusEditor> PROGRESS {Editor.IsFocused}");
                }
                Console.WriteLine($"<FocusEditor> END {Editor.IsFocused}");
            });
        }

        private void UnfocusEditor()
        {
            _focusEditorTask.Wait();
            _unfocusEditorTask.Wait();

            _unfocusEditorTask = Task.Factory.StartNew(async () =>
            {
                Console.WriteLine($"<!UnfocusEditor> START {Editor.IsFocused}");
                while (Editor.IsFocused)
                {
                    Editor.Unfocus();
                    await Task.Delay(100);
                    Console.WriteLine($"<!UnfocusEditor> PROGRESS {Editor.IsFocused}");
                }

                Console.WriteLine($"<!UnfocusEditor> END {Editor.IsFocused}");

                return Task.CompletedTask;
            });
        }

        protected override void OnPropertyChanging([CallerMemberName] string propertyName = null)
        {
            if (propertyName.Equals("IsVisible") && IsVisible)
            {
                Console.WriteLine($"<IsVisibleChanging> InputView: IsVisible ({IsVisible}) -> {!IsVisible}");
                Editor.Unfocused -= OnEditorUnfocused;
                UnfocusEditor();
            }

            base.OnPropertyChanging(propertyName);
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (propertyName.Equals("IsVisible") && IsVisible)
            {
                Console.WriteLine($"<IsVisibleChanged> InputView: IsVisible {!IsVisible} -> ({IsVisible})");
                Editor.Unfocused += OnEditorUnfocused;
                FocusEditor();
            }

            base.OnPropertyChanged(propertyName);
        }
    }
}
