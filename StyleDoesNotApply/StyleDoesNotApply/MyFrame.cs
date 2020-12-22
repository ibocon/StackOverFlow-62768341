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
            HorizontalOptions = LayoutOptions.Start;
            VerticalOptions = LayoutOptions.CenterAndExpand;

            MinimumWidthRequest = 82;
            WidthRequest = 82;

            MinimumHeightRequest = 38;
            HeightRequest = 38;

            Padding = new Thickness(0);
            HasShadow = false;

            CornerRadius = 20;
            BackgroundColor = Color.LightPink;

            _title = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                TextColor = Color.Black,
                FontSize = 16,
                Text = "Title",
            };

            Content = _title;
        }
    }
}

