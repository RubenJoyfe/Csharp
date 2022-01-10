using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementosVisuales
{
    class Perfil
    {
        public enum Dificultad { facil, medio, dificil };
        private string _nombre;
        private string _apellido_1;
        private string _apellido_2;
        private string _nick;
        private DateTime _fecha_Nacimiento;
        private int _resolucionAltura;
        private int _resolucionAnchura;
        private int _volumenMusica;
        private Dificultad _dificultad;

        public string Nick
        {
            get { return _nick; }
        }

        public int ResolucionAltura
        {
            get { return _resolucionAltura; }
            set { _resolucionAltura = value; }
        }
        public int ResolucionAnchura
        {
            get { return _resolucionAnchura; }
            set { _resolucionAnchura = value; }
        }
        public int VolumenMusica {
            get { return _volumenMusica; }
            set { _volumenMusica = value; }
        }

        public Dificultad DificultadPrograma
        {
            get { return _dificultad; }
            set { _dificultad = value; }
        }

        //CONSTRUCTORES

        public Perfil(DateTime fechanac)
        {
            _nombre = "random01";
            _apellido_1 = "";
            _apellido_2 = "";
            _nick = "Player";
            _dificultad = Dificultad.medio;
            _resolucionAltura = 600;
            _resolucionAnchura = 800;
            _fecha_Nacimiento = fechanac;
        }

        public bool RegistrarFecha(DateTime nuevaFechaNac)
        {
            if (DateTime.Now.Year - nuevaFechaNac.Year < 18)
            {
                return false;
            }
            _fecha_Nacimiento = nuevaFechaNac;
            return true;

        }

    }
}