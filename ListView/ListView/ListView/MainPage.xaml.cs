using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var alunos = new string[]
            {
                "Amanda Lorenzetti",
                "Mario Hikari",
                "Willian Bastos"
            };
            listViewAlunos.ItemsSource = alunos;
        }
    }
}
