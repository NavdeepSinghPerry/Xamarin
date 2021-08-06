using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InstaFinalVersion
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NotificationPage();
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
