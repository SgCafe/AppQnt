using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppQnt
{
    public partial class MainPage : ContentPage
    {
        int quantidade = 1;
        string pipo = "Vai botar na pipoquinha quantas vezes?";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Aumentar(object sender, EventArgs e)
        {
            quantidade++;
            lblQuantidade.Text = quantidade.ToString();
        }

        private void Diminuir(object sender, EventArgs e)
        {
            if(quantidade != 0)
            {
                quantidade--;
                lblQuantidade.Text = quantidade.ToString();
            }
            
        }

        private void Curioso(object sender, EventArgs e)
        {
            
            lblAlternativo.Text = pipo.ToString();
            
        }
    }
}
