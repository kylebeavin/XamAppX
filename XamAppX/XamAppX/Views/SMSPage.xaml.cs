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
    public partial class SMSPage : ContentPage
    {
        public SMSPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
            Sms.ComposeAsync(new SmsMessage(EntryMessage.Text, EntryNumber.Text));
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Alert", $"Error In SMSPage: {ex.Message}", "OK");
            }
        }
    }
}