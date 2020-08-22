using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamAppX.ViewModels
{
    class BatteryViewModel : BaseViewModel
    {
        public BatteryViewModel()
        {
            Title = "Battery";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}
