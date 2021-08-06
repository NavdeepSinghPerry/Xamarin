using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InstagramWorking
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabsPage : TabbedPage
    {
        public TabsPage()
        {
            InitializeComponent();
        }

        private async void NavigationPage_Focused(object sender, FocusEventArgs e)
        {
            await Navigation.PushAsync(new UserDetail(new User()
            {
                Name = "Perry",
                Content = "I am a passionate Full-Stack Developer",
                ImageUrl = ImageSource.FromFile("nav.jpg")
            }));
        }
    }
}