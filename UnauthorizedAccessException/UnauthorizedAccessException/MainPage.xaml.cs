using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Threading.Tasks;
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
            _label.Text = "Start";
            var assembly = Assembly.GetExecutingAssembly();
            using (var stream = assembly.GetManifestResourceStream("UnauthorizedAccessException.Test.zip"))
            {
                var zipArchive = new ZipArchive(stream);
                zipArchive.ExtractToDirectory(App.FolderPath);
            }

            Task.Delay(1000).ConfigureAwait(true).GetAwaiter();

            _label.Text = "Complete";
            string text = File.ReadAllText(Path.Combine(App.FolderPath, "Test.txt"));
            _label.Text = text;
        }
    }
}
