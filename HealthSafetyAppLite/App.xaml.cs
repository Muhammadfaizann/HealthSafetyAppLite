using HealthSafetyAppLite.Views;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("Poppins-Regular.tff", Alias = "PoppinsRegular")]
[assembly: ExportFont("Poppins-Bold.ttf", Alias = "PoppinsBold")]
[assembly: ExportFont("Poppins-Light.tff", Alias = "PoppinsRegular")]
[assembly: ExportFont("Poppins-Italic.ttf", Alias = "PoppinsBold")]
[assembly: ExportFont("FontAwesomeBrand.otf", Alias = "FontAwesomeBrand")]
[assembly: ExportFont("FontAwesomeRegular.otf", Alias = "FontAwesomeRegular")]
[assembly: ExportFont("FontAwesomeSolid.otf", Alias = "FontAwesomeSolid")]

namespace HealthSafetyAppLite
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var user = Preferences.Get("UserName", "");
            if (string.IsNullOrEmpty(user))
            {
                MainPage = new LoginPage();
            }
            else
            {
                MainPage = new LandingPage();
            }
           
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
