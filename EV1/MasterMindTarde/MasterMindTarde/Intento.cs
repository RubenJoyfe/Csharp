using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMindTarde
{
    public class Intento
    {
        //Campos privados
        private int[] _secuencia = new int[5];
        private string _resultado;
       
        //Propiedades
        public string Secuencia {
            get
            {
                string cadena_final = "";

                cadena_final = "" + _secuencia[0] + " " +
                                +_secuencia[1] + " " +
                                +_secuencia[2] + " " +
                                +_secuencia[3] + " " +
                                +_secuencia[4];

                return cadena_final;
            }
        }
        public string Resultado
        {
            get { return _resultado; }
            set { _resultado = value; }
        }
        //Constructor(es)
        public Intento(int[] pSecuencia, string pResultado)
        {
            _secuencia = pSecuencia;
            _resultado = pResultado;
        }
        //Metodos
    }
}
