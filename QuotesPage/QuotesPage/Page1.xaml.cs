using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuotesPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        string[] strings = new string[] { "HI", "HELLO", "NI HAO" };
        
        int i = 0;

        public Page1()
        {
            InitializeComponent();

            label.Text = string.Format("{0}", strings[i]);

            Padding = 20;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (i == 3)
            {
                i = 0;
            }

            label.Text = string.Format("{0}", strings[i]);

            

            i++;
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label.FontSize = e.NewValue;
        }
    }
}