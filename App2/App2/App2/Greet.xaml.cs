using System;
using System.Windows;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Greet : ContentPage
    {
        public Greet()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Title", "Hello World", "Ok");
           
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            
        }
    }
}