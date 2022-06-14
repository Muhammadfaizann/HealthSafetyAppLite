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
        public ObservableCollection<LandingPageModel> LandingList { get; set; }
        public ICommand EmailCommand { get; set; }
        public LandingPageViewModel(INavigation navigation)
        {
            this.Navigation = navigation;

            EmailCommand = new Command( () => {  SendEmail(); });
            LandingList = new ObservableCollection<LandingPageModel>()
            {
              new LandingPageModel
              {
                  Title="DYNAMIC RISK ASSESSMENT TOOL"
              } ,
              new LandingPageModel
              {
                  Title="COSHH ASSESSMENT TOOL"
              },
              new LandingPageModel
              {
                  Title="WORKSTATION ASSESSMENT TOOL"
              } ,
               new LandingPageModel
              {
                  Title="MANUAL HANDLING RISK ASSESSMENT TOOL"
              } ,
                new LandingPageModel
              {
                  Title="ACCIDENT RECORD FORM TOOL"
              },
                 new LandingPageModel
              {
                  Title="SAFE SYSTEMS OF WORK TOOL"
              },
                  new LandingPageModel
              {
                  Title="AUDIT FORM TOOL"
              }
                  ,
                  new LandingPageModel
              {
                  Title="TOOLBOX TALKS"
              }
                  ,
                  new LandingPageModel
              {
                  Title="AUDIT FORM TOOL"
              }
            };
        }

        private async void SendEmail()
        {
            var emailReceiver = Preferences.Get("UserName", "");

            await Email.ComposeAsync("","", "support@thehealthandsafetyapp.co.uk");
           
        }
    }
}
