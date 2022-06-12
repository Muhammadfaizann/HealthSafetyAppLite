using Foundation;
using HealthSafetyAppLite.iOS.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(Entry), typeof(BorderlessEntry))]
namespace HealthSafetyAppLite.iOS.Renderers
{
   public class BorderlessEntry  :EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Layer.BorderWidth = 0;
            }
        }
    }
}