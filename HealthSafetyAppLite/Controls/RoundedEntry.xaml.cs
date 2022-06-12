using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealthSafetyAppLite.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoundedEntry : Frame
    {
        public static readonly BindableProperty TextProperty =
 BindableProperty.Create("Text", typeof(string), typeof(RoundedEntry), null,
           defaultBindingMode: BindingMode.TwoWay);

        public RoundedEntry()
        {
            InitializeComponent();
        }

        public double FontSize
        {
            get => txt.FontSize;
            set { txt.FontSize = (double)value; }
        }
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public string PlaceHolder
        {
            get => txt.Placeholder;
            set { txt.Placeholder = value; }
        }
        public Keyboard Keyboard
        {
            get => txt.Keyboard;
            set { txt.Keyboard = value; }
        }

        public bool IsPassword
        {
            get => txt.IsPassword;
            set { txt.IsPassword = value; }
        }
    }
}