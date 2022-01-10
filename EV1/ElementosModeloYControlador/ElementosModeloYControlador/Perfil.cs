using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementosModeloYControlador
{

    public class Perfil
    {
        public enum Dificultad { Fácil, Medio, Difícil };
        //CAMPOS
        private string _nombre;
        private string _apellido_1;
        private string _apellido_2;
        private string _nick;
        private DateTime _fecha_Nacimiento;
        private int _resolucionAltura;
        private int _resolucionAnchura;
        private int _volumenMusica;
        private Dificultad _dificultadPrograma;

        //PROPIEDADES
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
        public int VolumenMusica
        {
            get { return _volumenMusica; }
            set { _volumenMusica = value; }
        }
        public Dificultad DificultadPrograma
        {
            get { return _dificultadPrograma; }
            set { _dificultadPrograma = value; }
        }

        //CONSTRUCTORES
        public Perfil()
        {
            _nombre = "Por Defecto";
            _apellido_1 = "";
            _apellido_2 = "";
            _nick = "Player";
            _dificultadPrograma = Dificultad.Medio;
            _resolucionAltura   = 600;
            _resolucionAnchura  = 600;
            _volumenMusica      = 0;
            _fecha_Nacimiento = DateTime.Today;
        }

        //METODOS
        public bool RegistrarFecha(DateTime nuevaFechaNac)
        {
            //Comprobar si es mayor de edad
            if(DateTime.Now.Year - nuevaFechaNac.Year >= 18)
            {
                _fecha_Nacimiento = nuevaFechaNac;
                return true;
            }
            return false;
        }

    }
}
