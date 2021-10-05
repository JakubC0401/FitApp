using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;


namespace FitApp
{
    public partial class App : Application
    {
        static dataBase _database;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
        public static dataBase dataBase
        {
            get
            {
                if (_database == null)
                {
                    _database = new dataBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "database.db3"));
                }
                return _database;
            }
        }
    }
}
