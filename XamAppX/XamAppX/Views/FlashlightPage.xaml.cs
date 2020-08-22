using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.Diagnostics;

namespace XamAppX.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlashlightPage : ContentPage
    {
        public FlashlightPage()
        {
            InitializeComponent();
        }

        private async void ButtonOn_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Flashlight.TurnOnAsync();
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Alert", $"Unable toggle flashlight: {ex.Message}", "OK");
            }
        }

        private async void ButtonOff_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Flashlight.TurnOffAsync();
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Alert", $"Unable toggle flashlight: {ex.Message}", "OK");
            }
        }
    }
}