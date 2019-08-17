using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ex2Grid
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            listViewVeiculos.ItemsSource = new string []
            {
                "Maverick V6",
                "Monza",
                "Ford Galaxy"
            };
        }
    }
}
