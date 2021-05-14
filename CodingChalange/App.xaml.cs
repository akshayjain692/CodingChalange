using CodingChalange.View;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CodingChalange
{
    public partial class App : Application
    {

        public string FilePath { get; private set; }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
            FilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Order.txt");
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
    }
}
