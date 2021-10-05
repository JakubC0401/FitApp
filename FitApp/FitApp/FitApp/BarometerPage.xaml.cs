using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitApp
{
    
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarometerPage : ContentPage
    {
        
        SensorSpeed speed = SensorSpeed.UI;
        
        public BarometerPage()
        {
            InitializeComponent();
            
        }
        

        private async void openMap(object sender, EventArgs e)
        {
            var my = await Geolocation.GetLastKnownLocationAsync();

            
            var location = new Location(my);
            var options = new MapLaunchOptions { Name = "Position" };
            try
            {
                await Map.OpenAsync(location, options);
            }
            catch (Exception ex)
            {

            }
        }
    }
}