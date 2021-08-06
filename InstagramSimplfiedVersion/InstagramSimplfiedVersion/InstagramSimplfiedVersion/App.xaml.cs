using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InstagramSimplfiedVersion
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NotificationsPage();
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
