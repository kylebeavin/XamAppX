using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace XamAppX.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeviceDisplayPage : ContentPage
    {
        public DeviceDisplayPage()
        {
            InitializeComponent();
            var deviceName = DeviceInfo.Name;
            var version = DeviceInfo.Version;
            var platform = DeviceInfo.Platform;
            // Idiom (Phone)
            var idiom = DeviceInfo.Idiom;

            if (idiom == DeviceIdiom.Tablet)
            {
                // if on tablet do something
            }

            // Device Type (Physical)
            var deviceType = DeviceInfo.DeviceType;

            LabelDeviceInfo.Text = $"{deviceName} {version} {platform}";

            LabelDeviceDisplay.Text = DeviceDisplay.MainDisplayInfo.ToString();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DeviceDisplay.MainDisplayInfoChanged += DeviceDisplay_MainDisplayInfoChanged;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            DeviceDisplay.MainDisplayInfoChanged -= DeviceDisplay_MainDisplayInfoChanged;
        }

        private void DeviceDisplay_MainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
        {
            LabelDeviceDisplay.Text = e.DisplayInfo.ToString();
        }
    }
}