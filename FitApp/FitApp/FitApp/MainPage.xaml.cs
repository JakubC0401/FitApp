using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FitApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ToBmiCalculator(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BMIpage());
        }

        private async void ToTracker(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TrackerPage());
        }

        private async void ToMetabolism(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MetabolismPage());
        }

        private async void ToBarometer(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BarometerPage());
        }

        private async void ToListPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MealsPage());
        }
    }
}
