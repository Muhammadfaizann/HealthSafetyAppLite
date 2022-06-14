using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSafetyAppLite.Views
{
    public class LandingPageFlyoutMenuItem
    {
        public LandingPageFlyoutMenuItem()
        {
            TargetType = typeof(LandingPageFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}