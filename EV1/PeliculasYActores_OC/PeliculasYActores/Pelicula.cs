using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeliculasYActores
{
    public class Pelicula
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int AnhoEstreno { get; set; }
        public ObservableCollection<Actor> Actores { get; set; }

        public Pelicula() { }

        public Pelicula(string titulo, string descripcion, int anhoEstreno, ObservableCollection<Actor> actores)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            AnhoEstreno = anhoEstreno;
            Actores = actores;
        }
        
    }
}
