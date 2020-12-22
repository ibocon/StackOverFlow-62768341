using System;

using Xamarin.Forms;

namespace StyleDoesNotApply
{
    public class MyFrame : Frame
    {
        private readonly Label _title;
        public string Title { set => _title.Text = value; }

        public MyFrame()
        {
            BackgroundColor = Color.LightPink;

            _title = new Label
            {
                TextColor = Color.Black,
                FontSize = 16,
            };

            Content = _title;
        }
    }
}

