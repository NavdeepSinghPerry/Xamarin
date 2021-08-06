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
    public partial class NotificationPage : ContentPage
    {
        public List<User> users = new List<User>()
        {
             new User
             {
                 Id=1,
                 Name="Gopi",
                 Description="Gurpreet Sandhu has started following you.",
                 ImageUrl =ImageSource.FromFile("gurpreet.jpg"),
                 Content="Gurpreet aka Gopi is an awesome person with a transparent nature and an exquisitive presense"

             },
        
             new User
             {
                 Id=1,
                 Description="your facebook friend Subham Singhania from John Deere has deactivated the account",
                ImageUrl =ImageSource.FromFile("subham.jpg") 
             },
           
             new User
             {
                 Id=1,
                 Description="your facebook friend Subham Singhania from john Deere has activated the account again",
                ImageUrl =ImageSource.FromFile("subham.jpg")
             },
             new User
             {
                 Id=1,
                 Description="Gurpreet Liked your profile picture ",
                 ImageUrl =ImageSource.FromFile("gurpreet.jpg")
             },
              new User
             {
                 Id=1,
                 Description="Gurpreet Liked your profile picture ",
                 ImageUrl =ImageSource.FromFile("gurpreet.jpg")
             },
              new User
             {
                 Id=1,
                 Description="Gurpreet Liked your profile picture ",
                 ImageUrl =ImageSource.FromFile("gurpreet.jpg")
             },
             new User
             {
                 Id=1,
                 Description="Gurpreet Liked your profile picture ",
                 ImageUrl =ImageSource.FromFile("gurpreet.jpg")
             },
             new User
             {
                 Id=1,
                 Description="Gurpreet Liked your profile picture ",
                 ImageUrl =ImageSource.FromFile("gurpreet.jpg")
             },
              new User
             {
                 Id=1,
                 Description="Gurpreet Liked your profile picture ",
                 ImageUrl =ImageSource.FromFile("gurpreet.jpg")
             },

        };
        public NotificationPage()
        {
            InitializeComponent();
            notificationsList.ItemsSource = users;


        }

        private void notificationsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var selectedUser = e.SelectedItem as User;
            Navigation.PushAsync(new UserDetail(selectedUser));
            notificationsList.SelectedItem = null;
         
        }
    }

    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

         public ImageSource ImageUrl { get; set; }
    }
}