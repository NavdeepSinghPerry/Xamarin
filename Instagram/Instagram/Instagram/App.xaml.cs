using Instagram.Services;
using Instagram.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Instagram
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new InstaPage();
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
