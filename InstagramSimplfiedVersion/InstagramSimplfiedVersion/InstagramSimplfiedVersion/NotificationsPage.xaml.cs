using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InstagramSimplfiedVersion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotificationsPage : ContentPage
    {
        public List<User> users = new List<User>()
        {
             new User 
             {
                 Id=1,
                 Description="your facebook friend Gurpreet from JOhn Deere is in love",
                 ImageUrl ="Gurpreet.jpg" 
             },
             new User
             {
                 Id=1,
                 Description="your facebook friend Khusvinder Kaur Hanjra has updated her relationship status as open",
                 ImageUrl ="Kushi.jpg" 
             }
        };        
        public NotificationsPage()
        {
            InitializeComponent();
           
          //  notificationsList.ItemsSource = users;
        }
    }

   public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }
    }
}