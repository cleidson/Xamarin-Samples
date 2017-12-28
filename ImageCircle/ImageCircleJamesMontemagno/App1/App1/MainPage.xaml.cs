using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        private Pessoa _pessoa;

        public Pessoa Pessoa
        {
            get { return _pessoa; }
            set { _pessoa = value; }
        }

        public MainPage()
        {
            InitializeComponent();
            
            Pessoa = new Pessoa();
            Pessoa.Nome = "Cleidson";
            Pessoa.Foto = "http://br.web.img2.acsta.net/c_300_300/medias/nmedia/18/63/50/22/20351664.jpg";
            BindingContext = Pessoa;

        }
    }
}
