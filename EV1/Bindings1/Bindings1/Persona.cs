using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bindings1
{
    public class Persona : INotifyPropertyChanged
    {
        // Declare the event
        public event PropertyChangedEventHandler PropertyChanged;

        private int _edad = 0;
        private string _nombre = "";
        public int Edad
        {
            get { 
                return _edad;
            }
            set { 
                _edad = value;
                OnPropertyChanged();
            }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public Persona()
        {
            _nombre = "RandomJoe";
            _edad = 18;
        }
        public Persona(string nuevoNombre, int nuevaEdad)
        {
            _nombre = nuevoNombre;
            _edad = nuevaEdad;
        }

        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
