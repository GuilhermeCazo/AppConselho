using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using AppConselho.Model;
using AppConselho.Services;

namespace AppConselho
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Title = "Conselhos";

           this.BindingContext = new Conselho();
        }

        //terminar com o bot]ao
        private async void btn_Novo_Conselho_Clicked(object sender, EventArgs e)
        {
            


        }
    }
}
