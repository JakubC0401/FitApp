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
    public partial class itemTabbed : ContentPage
    {
        private int _mealID;
        public itemTabbed(int mealID, string mealname, int kcals, DateTime mealDate)
        {
            InitializeComponent();
            MealNameLabel.Text = mealname;
            KcalsLabel.Text = kcals.ToString();
            timelbl.Text = mealDate.ToString();
        }
    }
}