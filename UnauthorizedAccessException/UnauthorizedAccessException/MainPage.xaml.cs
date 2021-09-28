using System;
using System.IO.Compression;
using System.Reflection;
using Xamarin.Forms;

namespace UnauthorizedAccessException
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            var assembly = Assembly.GetExecutingAssembly();
            using (var stream = assembly.GetManifestResourceStream("UnauthorizedAccessException.Test.zip"))
            {
                var zipArchive = new ZipArchive(stream);
                zipArchive.ExtractToDirectory(App.FolderPath);
            }
        }
    }
}
