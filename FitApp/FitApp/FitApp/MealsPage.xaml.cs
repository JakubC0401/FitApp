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
    public partial class MealsPage : ContentPage
    {
        public MealsPage()
        {
            InitializeComponent();
        }

        private async void onSaveButton(object sender, EventArgs e)
        {

            Meals meal = new Meals()
            {
                MealName = mealEntry.Text,
                MealKcals = Convert.ToInt32(kcalsEntry.Text),
                MealTime = datePicker.Date
            };

            await App.dataBase.SaveMealAsync(meal);
            await DisplayAlert("succesfully added", "you added your meal to list", "ok");
        }

        private async void ShowAll(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AllMeals());
        }
    }
}