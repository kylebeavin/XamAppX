using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamAppX.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BatteryPage : ContentPage
    {
        public BatteryPage()
        {
            InitializeComponent();
            SetBackground(Battery.ChargeLevel, Battery.State == BatteryState.Charging);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Battery.BatteryInfoChanged += Battery_BatteryInfoChanged;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Battery.BatteryInfoChanged -= Battery_BatteryInfoChanged;
        }

        private void Battery_BatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
        {
            SetBackground(e.ChargeLevel, e.State == BatteryState.Charging);
        }

        private void SetBackground(double level, bool charging)
        {
            Color? color = null;
            var status = charging ? "Charging" : "Not charging";

            if (level > .5f)
            {
                color = Color.Green.MultiplyAlpha(level);
            }
            else if (level > .1f)
            {
                color = Color.Yellow.MultiplyAlpha(1d - level);
            }
            else
            {
                color = Color.Red.MultiplyAlpha(1d - level);
            }

            BackgroundColor = color.Value;
            LabelBatteryLevel.Text = status;
        }
    }
}