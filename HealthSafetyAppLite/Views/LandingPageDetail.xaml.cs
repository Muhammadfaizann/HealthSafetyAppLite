using HealthSafetyAppLite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace HealthSafetyAppLite.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LandingPageDetail : ContentPage
    {
        public LandingPageDetail()
        {
        
            InitializeComponent();
            this.BindingContext = new LandingPageViewModel(Navigation);
        }
        
        
    }
}