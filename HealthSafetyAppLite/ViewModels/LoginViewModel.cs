using HealthSafetyAppLite.Services;
using HealthSafetyAppLite.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace HealthSafetyAppLite.ViewModels
{
  public  class LoginViewModel :BaseViewModel
    {
        public INavigation Navigation { get; set; }
        public ICommand SignUpPageCommand { get; set; }
        public ICommand LogInCommand { get; set; }

        private async void LogIn()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                if (string.IsNullOrEmpty(_userName) && string.IsNullOrEmpty(_password))
                {
                  await  App.Current.MainPage.DisplayAlert("Attention", "Please Enter The All Fields", "OK");
                    return;
                }
                UserService service = new UserService();
                Result = await service.LoginUser(_userName, _password);
                if (Result)
                {
                    Preferences.Set("UserName", UserName);
                    await Navigation.PushModalAsync(new LandingPage());
                    
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Attention", "Wrong User Name and Password","Ok");
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                IsBusy = false;
            }
               

        }

        public LoginViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            LogInCommand = new Command(() => { LogIn(); });
            SignUpPageCommand = new Command(async () =>
              {
                  if (IsBusy)
                      return;
                  try
                  {
                      IsBusy = true;
                     
                          await Navigation.PushModalAsync(new SignupPage());
                      IsBusy = false;
                      
                  }
                  catch(Exception ex)
                  {

                  }
                  finally
                  {
                      IsBusy = false;
                  }
                  
              });
        }

        bool _result;
        public bool Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged("Result");
            }
        }

        bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                OnPropertyChanged("IsBusy");
            }
        }
        string _userName;
        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                OnPropertyChanged("UserName");
            }
        }
        string _password;
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }
    }
}
