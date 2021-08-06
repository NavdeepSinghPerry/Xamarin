using Instagram.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Instagram.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}