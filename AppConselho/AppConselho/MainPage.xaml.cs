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

        
        private async void btn_Novo_Conselho_Clicked(object sender, EventArgs e)
        {
            try
            {

          
            Console.WriteLine("_____________");
             Conselho Advice = await DataService.GetConselho();

            this.BindingContext = Advice;
            btn_novo_conselho.Text = "Novo Conselho";
            }
            catch(Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "ok");
            }
        }
    }
}
