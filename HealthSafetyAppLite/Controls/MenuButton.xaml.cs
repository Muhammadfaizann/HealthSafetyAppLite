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
    public partial class MenuButton : Frame
    {
        public MenuButton()
        {
            InitializeComponent();
        }

        public ImageSource Image
        {
            get => img.Source;
            set
            {
                img.Source = value;
            }
        }
        public double FontSize
        {
            get => txt.FontSize;
            set
            {
                txt.FontSize = value;
            }
        }
        public string Text
        {
            get => txt.Text;
            set
            {
                txt.Text = value;
            }
        }
    }
}