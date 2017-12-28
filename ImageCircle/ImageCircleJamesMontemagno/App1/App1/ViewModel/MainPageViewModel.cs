using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Pessoa _pessoa;

        public Pessoa Pessoa
        {
            get { return _pessoa; }
            set {
                _pessoa = value;
                OnPropertyChanged("Pessoa");
            }
        }

        public MainPageViewModel()
        {
            Pessoa = new Pessoa();
            Pessoa.Nome = "Cleidson";
            Pessoa.Foto = "http://br.web.img2.acsta.net/c_300_300/medias/nmedia/18/63/50/22/20351664.jpg";

        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
