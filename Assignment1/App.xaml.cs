using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Assignment1.Data;
namespace Assignment1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Entries = new FileEntryStore();
          //  Entries.LoadMockData();

            MainPage = new NavigationPage(new Assignment1.MainPage())
            {
                BarBackgroundColor = Color.FromHex("#3498db"),
                BarTextColor = Color.White
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static INoteEntryStore Entries { get; set; }
    }
}
