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
    public partial class SharePage : ContentPage
    {
        public SharePage()
        {
            InitializeComponent();
        }

        private async void ButtonShare_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Share.RequestAsync(new ShareTextRequest
                {
                    Text = EntryShare.Text,
                    Title = "Share"
                });
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Alert", $"Error In SharePage: {ex.Message}", "OK");
            }
        }
    }
}