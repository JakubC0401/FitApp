using Plugin.Geolocator;
using System;
using Xamarin.Essentials;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;

namespace FitApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrackerPage : ContentPage
    {
        Stopwatch stopwatch;
        public TrackerPage()
        {
           
            InitializeComponent();
            stopwatch = new Stopwatch();
            stopwatchLabel.Text = "00:00";
        }
        public double Ax;
        public double Ay;
        public double Bx;
        public double By;
        private async void onStart(object sender, EventArgs e)
        {

            stopwatch.Start();
            Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
            {

                stopwatchLabel.Text = (Math.Truncate(stopwatch.Elapsed.TotalSeconds * 100) / 100).ToString();
                
                return true;
            });


            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();
                if (location != null)
                {
                   
                    Ax=(double) location.Latitude;
                    Ay = (double)location.Longitude;
                   
                  

                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to get location
            }

        }
        private double calculateDistane()
        {
            double x = Math.Pow((Bx - Ax), 2);
            double y = Math.Cos((Ax * Math.PI) / 180);
            double z = By - Ay;
            double v = Math.Pow((y * z), 2);
            double b = Math.Sqrt(x + v);
            double restult = b * (40075.704 / 360);
            return restult;
           
        }

        private async void onStop(object sender, EventArgs e)
        {
            stopwatch.Stop();
            
            double sec = (Math.Truncate(stopwatch.Elapsed.TotalSeconds * 100) / 100);
            secLabel.Text = sec.ToString() + " seconds";

            stopwatch.Reset();


            try
            {

                var location = await Geolocation.GetLastKnownLocationAsync();
                if (location != null)
                {
                    
                    Bx = (double)location.Latitude;
                    By  = (double)location.Longitude;
                 
                   
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to get location
            }
            
            double result = calculateDistane();

            distanceLablel.Text = result.ToString() +" km";
        }
    }
}