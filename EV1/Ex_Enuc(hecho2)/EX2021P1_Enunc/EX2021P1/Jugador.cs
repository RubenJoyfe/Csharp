using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2021P1
{
    public class Jugador
    {
      
        public string Nombre { get; set; }
        public int Puntos { get; set; }

        public Jugador()
        {
        }

        public Jugador(string nombre, int puntos)
        {
            Nombre = nombre;
            Puntos = puntos;
        }
    }
}
