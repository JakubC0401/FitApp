using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MetabolismPage : ContentPage
    {
        public MetabolismPage()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {
            string age = AgeEntry.Text;
            string height = HeigtEntry.Text;
            string weight = WeightEntry.Text;

            int iage = Int32.Parse(age);
            int iheight = Int32.Parse(height);
            int iweight = Int32.Parse(weight);

            //wzoru Harrisa-Benedicta
            if (GenderPicker.SelectedItem == "Man")
            {
                double result = 66.47 + (13.7 * iweight) + (5.0 * iheight) - (6.76 * iage);

                resultsLabel.Text = result.ToString() + " kcal";
            }
            else if (GenderPicker.SelectedItem == "Woman")
            {
                double result = 665.09 + (9.56 * iweight) + (1.85 * iheight) - (4.67 * iage);

                resultsLabel.Text = result.ToString() + " kcal";
            }
        }
    }
}