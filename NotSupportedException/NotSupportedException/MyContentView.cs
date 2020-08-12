using SkiaSharp;
using SkiaSharp.Views.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NotSupportedException
{
    public class MyContentView : ContentView
    {
        private string _text;
        private SKCanvasView _canvasView;
        private Editor _editorView;

        public MyContentView()
        {
            _text = "Hello, World!";

            _canvasView = new SKCanvasView()
            {
                WidthRequest = 100,
                HeightRequest = 100,
                EnableTouchEvents = true
            };
            _canvasView.PaintSurface += (sender, e) =>
            {
                e.Surface.Canvas.Clear();

                var rect = new SKRect(0, 0, 
                    (float)(Width * Xamarin.Essentials.DeviceDisplay.MainDisplayInfo.Density), 
                    (float)(Height * Xamarin.Essentials.DeviceDisplay.MainDisplayInfo.Density));
                var rectPaint = new SKPaint()
                {
                    Color = SKColors.Red,
                    IsStroke = false,
                    StrokeWidth = 1
                };
                e.Surface.Canvas.DrawRect(rect, rectPaint);

                var textPaint = new SKPaint()
                {
                    Color = SKColors.Black,
                    IsAntialias = true,
                    TextSize = 16
                };
                e.Surface.Canvas.DrawText(_text, 0, 0, textPaint);
            };
            _canvasView.Touch += (sender, e) =>
            {
                ToggleContent();
                e.Handled = true;
            };

            _editorView = new Editor()
            {
                AutoSize = EditorAutoSizeOption.TextChanges
            };

            _editorView.Completed += (sender, e) =>
            {
                _text = _editorView.Text;
            };
            _editorView.Unfocused += (sender, e) =>
            {
                ToggleContent();
            };

            _canvasView.InvalidateSurface();
            Content = _canvasView;
        }

        public void ToggleContent()
        {
            if (Content == _canvasView)
            {
                Content = _editorView;
            }
            else
            {
                _canvasView.InvalidateSurface();
                Content = _canvasView;
            }
        }
    }
}