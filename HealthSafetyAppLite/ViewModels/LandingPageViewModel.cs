using HealthSafetyAppLite.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace HealthSafetyAppLite.ViewModels
{
   public class LandingPageViewModel  :BaseViewModel
    {
        public INavigation Navigation { get; set; }
       
        public ICommand EmailCommand { get; set; }
        public LandingPageViewModel(INavigation navigation)
        {
            this.Navigation = navigation;

            EmailCommand = new Command( () => {  SendEmail(); });
            
        }

        
        private async void SendEmail()
        {
           // var emailReceiver = Preferences.Get("UserName", "");

            //await Email.ComposeAsync("","", "support@thehealthandsafetyapp.co.uk");
            Device.OpenUri(new Uri("mailto:support@thehealthandsafetyapp.co.uk"));

        }
    }
}
