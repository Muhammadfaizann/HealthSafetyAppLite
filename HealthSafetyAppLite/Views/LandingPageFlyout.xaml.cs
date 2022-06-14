using HealthSafetyAppLite.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealthSafetyAppLite.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LandingPageFlyout : ContentPage
    {
        //public ListView ListView;

        public LandingPageFlyout()
        {
            InitializeComponent();
            this.BindingContext = new LandingPageViewModel(Navigation);

            //BindingContext = new LandingPageFlyoutViewModel();
            //ListView = MenuItemsListView;
        }

        //class LandingPageFlyoutViewModel : INotifyPropertyChanged
        //{
        //    public ObservableCollection<LandingPageFlyoutMenuItem> MenuItems { get; set; }

        //    public LandingPageFlyoutViewModel()
        //    {
        //        MenuItems = new ObservableCollection<LandingPageFlyoutMenuItem>(new[]
        //        {
        //            new LandingPageFlyoutMenuItem { Id = 0, Title = "Page 1" },
        //            new LandingPageFlyoutMenuItem { Id = 1, Title = "Page 2" },
        //            new LandingPageFlyoutMenuItem { Id = 2, Title = "Page 3" },
        //            new LandingPageFlyoutMenuItem { Id = 3, Title = "Page 4" },
        //            new LandingPageFlyoutMenuItem { Id = 4, Title = "Page 5" },
        //        });
        //    }

        //    #region INotifyPropertyChanged Implementation
        //    public event PropertyChangedEventHandler PropertyChanged;
        //    void OnPropertyChanged([CallerMemberName] string propertyName = "")
        //    {
        //        if (PropertyChanged == null)
        //            return;

        //        PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //    #endregion
        //}
    }
}