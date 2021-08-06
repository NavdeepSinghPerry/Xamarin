using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        private List<String> quotes = new List<string>()
        {
            "First",
            "Second",
            "Third"
        };


        public List<string> Quotes
        {
            get
            {
                return quotes;
            }
            
        }

        public int index = 0;
        public QuotesPage()
        {
           
            InitializeComponent();
         
            this.BindingContext = this;
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (index > (Quotes.Count() - 1))
                index = 0;

            LabelQuote.Text = Quotes[index];
            index++;
        }
    }
}