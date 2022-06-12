using HealthSafetyAppLite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealthSafetyAppLite.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignupPageSecond : ContentPage
    {
        public SignupPageSecond()
        {
            InitializeComponent();
            this.BindingContext = new SignUpViewModel(Navigation);
        }
    }
}