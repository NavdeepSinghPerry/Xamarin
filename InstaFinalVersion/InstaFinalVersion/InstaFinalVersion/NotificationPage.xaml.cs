using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InstaFinalVersion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotificationPage : ContentPage
    {
        public List<User> users = new List<User>()
        {
             new User
             {
                 Id=1,
                 Description="your facebook friend Gurpreet from JOhn Deere is in love",
            //     ImageUrl =ImageSource.FromFile("gurpreet.jpg") 
             },
             new User
             {
                 Id=1,
                 Description="your facebook friend Khusvinder Kaur Hanjra has updated her relationship status as open",
             //    ImageUrl =ImageSource.FromFile("khushi.jpg") 
             }
        };
        public NotificationPage()
        {
             InitializeComponent();
             notificationsList.ItemsSource = users;


        }
    }

    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

       // public ImageSource ImageUrl { get; set; }
    }
}