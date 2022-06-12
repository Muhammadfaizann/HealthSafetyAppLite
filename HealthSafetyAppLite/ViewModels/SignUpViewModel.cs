using HealthSafetyAppLite.Helper;
using HealthSafetyAppLite.Models;
using HealthSafetyAppLite.Services;
using HealthSafetyAppLite.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace HealthSafetyAppLite.ViewModels
{
  public  class SignUpViewModel:BaseViewModel
    {
        UserService service = new UserService();
        public INavigation Navigation { get; set; }
        public ICommand SignUpCommand { get; set; }
        public ICommand SecondSignupPageCommand { get; set; }
        public SignUpViewModel(INavigation navigation)
        {
            Navigation = navigation;
            SignUpCommand = new Command( () => { SignUp(); });

            SecondSignupPageCommand = new Command(async () =>
              {
                  await Navigation.PushModalAsync(new SignupPageSecond());
              });
        }

        private async void SignUp()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                string[] inputs = { _name, _organization, _industry, _position, _qualification, _password, _confirmPassword, _telephone, _email };
               foreach (var input in inputs)
               {
                   if (string.IsNullOrEmpty(input))
                   {
                     await  App.Current.MainPage.DisplayAlert("Attention", "Please Enter the Required Fields", "Ok");
                       return;
                   }

               }
                if (!EmailValidator.EmailIsValid(_email))
                {
                    await App.Current.MainPage.DisplayAlert("Attention", "Please Enter a Valid Email", "Ok");
                    return;
                }

                if (_password.Length < 8)
                {
                    await App.Current.MainPage.DisplayAlert("Attention", "Enter Mininum 8 Characters", "Ok");
                    return;
                }
                if (_password != _confirmPassword)
                {
                   await App.Current.MainPage.DisplayAlert("Attention", "Password and Confirm Password not matched", "Ok");
                    return;
                }
                User user = new User();
                user.Name = _name;
                user.Organization = _organization;
                user.Position = _position;
                user.Qualification = _qualification;
                user.Industry = _industry;
                user.DOB = _dob.ToString("dd/mm/yyyy");
                user.Email = _email;
                user.Password = _password;
                user.Telephone = _telephone;
                Result = await service.RegisterUser(user);
                if (Result)
                {
                    await App.Current.MainPage.DisplayAlert("Success", "Registered Successfully", "Ok");
                    await Navigation.PopModalAsync();
                }
                else
                {
                  await  App.Current.MainPage.DisplayAlert("Attention","User Already Exists","Ok");
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

        string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        string _organization;
        public string Organizatiion
        {
            get => _organization;
            set
            {
                _organization = value;
                OnPropertyChanged("Organizatiion");
            }
        }

        string _position;
        public string Position
        {
            get => _position;
            set
            {
                _position = value;
                OnPropertyChanged("Position");
            }
        }

        string _industry;
        public string Industry
        {
            get => _industry;
            set
            {
                _industry = value;
                OnPropertyChanged("Industry");
            }
        }

        string _qualification;
        public string Qualification
        {
            get => _qualification;
            set
            {
                _qualification = value;
                OnPropertyChanged("Qualification");
            }
        }

        DateTime _dob;
        public DateTime DOB
        {
            get => _dob;
            set
            {
                _dob = value;
                OnPropertyChanged("DOB");
            }
        }
        string _email;
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged("Email");
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
        string _confirmPassword;
        public string ConfirmPassword
        {
            get => _confirmPassword;
            set
            {
                _confirmPassword = value;
                OnPropertyChanged("ConfirmPassword");
            }
        }

        string _telephone;
        public string Telephone
        {
            get => _telephone;
            set
            {
                _telephone = value;
                OnPropertyChanged("Telephone");
            }
        }
    }
}
