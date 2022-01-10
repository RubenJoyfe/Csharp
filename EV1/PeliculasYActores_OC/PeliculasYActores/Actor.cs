using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeliculasYActores
{
    public class Actor
    {
        public string Nombre { get; set; }
        public string Biografia { get; set; }
        public int AnhoNacimiento { get; set; }

        public Actor() { }

        public Actor(string nombre, string biografia, int anhoNacimiento)
        {
            Nombre = nombre;
            Biografia = biografia;
            AnhoNacimiento = anhoNacimiento;
        }
        
    }
}
