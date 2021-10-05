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
    public partial class AllMeals : ContentPage
    {
        public AllMeals()
        {
            InitializeComponent();
            data();

        }
        private async void data()
        {
            MealsListView.ItemsSource = await App.dataBase.GetMealAsync();
        }
        private async void RecipesListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as Meals;
            await Navigation.PushModalAsync(new itemTabbed(details.ID, details.MealName, details.MealKcals, details.MealTime));
        }

        private async void deleteButton_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            var meal = button.BindingContext as Meals;
            await App.dataBase.DeleteMealAsync(meal);
        }
    }
}