using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Enunciado2122P1
{
    public class Tirada : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int _intento1;
        private int _intento2;
        private int _tiradaResultado;
        public int Intento1
        {
            get { return _intento1; }
            set { _intento1 = value;
                OnPropertyChanged();
            }
        }
        public int Intento2
        {
            get { return _intento2; }
            set
            {
                _intento2 = value;
                OnPropertyChanged();
            }
        }
        public int TiradaResultado
        {
            get { return _tiradaResultado; }
            set
            {
                _tiradaResultado = value;
                OnPropertyChanged();
            }
        }

        public Tirada() {
            Intento1 = 0;
            Intento2 = 0;
            TiradaResultado = 0;
        }
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
