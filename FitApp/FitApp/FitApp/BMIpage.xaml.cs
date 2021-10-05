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
    public partial class BMIpage : ContentPage
    {
        public BMIpage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();

        }

    }
}