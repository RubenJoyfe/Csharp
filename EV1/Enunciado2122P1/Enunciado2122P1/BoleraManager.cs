using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Enunciado2122P1
{
    public class BoleraManager : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        //Campos
        private bool[] _bolos = { false, false, false, false, false, false, false, false, false, false };
        private int _lineaTiro;
        private int _energia;
        private int _tiradaActual;
        private int _intentoActual;
        private ObservableCollection<Tirada> _marcador;
        public ObservableCollection<int> puntuacionesTotales;

        //Propiedades

        public ObservableCollection<int> PuntuacionesTotales
        {
            get{ return puntuacionesTotales;}
            set
            {
                puntuacionesTotales = value;
                OnPropertyChanged();
            }
        }
        public bool[] Bolos
        {
            get { return _bolos; }
            set { _bolos = value; }
        }
        public int LineaTiro
        {
            get { return _lineaTiro; }
            set
            {
                _lineaTiro = value;
                OnPropertyChanged();
            }
        }
        public int Energia
        {
            get { return _energia; }
            set { _energia = value;
                OnPropertyChanged();
            }
        }
        public int TiradaActual
        {
            get { return _tiradaActual; }
            set { _tiradaActual = value;
                OnPropertyChanged();
            }
        }
        public int IntentoActual
        {
            get { return _intentoActual; }
            set { _intentoActual = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Tirada> Marcador
        {
            get { return _marcador; }
            set
            {
                _marcador = value;
                OnPropertyChanged();
            }
        }

        public BoleraManager()
        {
            Marcador = new ObservableCollection<Tirada>();
            for(int i = 0;i< 10; i++)
                Marcador.Add(new Tirada());

            _lineaTiro = 4;
            _energia = 5;
            _tiradaActual = 1;
            _intentoActual = 1;
            puntuacionesTotales = new ObservableCollection<int>();
        }
        public int totalPuntosRonda() {  
            int total = 0;
            for (int i = 0; i < 10; i++)
            {
                total += Marcador.ElementAt(i).TiradaResultado;
            }
            return total;
        }
        public int reiniciarPuntuaciones()
        {
            int total = 0;
            for (int i = 0; i < 10; i++)
            {
                Marcador.ElementAt(i).Intento1 = 0;
                Marcador.ElementAt(i).Intento2 = 0;
                Marcador.ElementAt(i).TiradaResultado = 0;
            }
            return total;
        }

        public bool[] Lanzar(int linea, int energia)
        {
            int puntos = 0;
            Random r = new Random();
            //PRIMER BOLO GOLPEADO
            int tiro = r.Next(0, 99);
            if (linea == 1)
            {
                if (tiro <= 40 && !_bolos[6])
                { 
                    _bolos[6] = true;
                    puntos++;
                }
                else if (tiro > 40 && tiro <= 55 && !_bolos[3])
                {    _bolos[3] = true;
                    puntos++;
                }
                else if (tiro > 55 && tiro <= 65 && !_bolos[1])
                {    _bolos[1] = true;
                    puntos++;
                }
                else if (tiro > 65 && tiro <= 70 && !_bolos[0])
                {   _bolos[0] = true;
                    puntos++;
                }
                else if (tiro > 70 && tiro <= 71 && !_bolos[2])
                {   _bolos[2] = true;
                    puntos++;
                }
                else if (tiro > 71 && tiro <= 72 && !_bolos[5])
                {  _bolos[5] = true;
                    puntos++;
                }
                else if (tiro > 72 && tiro <= 73 && !_bolos[9])
                {  _bolos[9] = true;
                   puntos++;
                }
            }
            else if (linea == 2)
            {
                if (tiro <= 15 && !_bolos[6])
                { _bolos[6] = true; puntos++; }
                else if (tiro > 15 && tiro <= 55 && !_bolos[3])
                { _bolos[3] = true; puntos++; }
                else if (tiro > 55 && tiro <= 70 && !_bolos[1])
                { _bolos[1] = true; puntos++; }
                else if (tiro > 70 && tiro <= 80 && !_bolos[0])
                { _bolos[0] = true; puntos++; }
                else if (tiro > 80 && tiro <= 85 && !_bolos[2])
                { _bolos[2] = true; puntos++; }
                else if (tiro > 86 && tiro <= 87 && !_bolos[5])
                { _bolos[5] = true; puntos++; }
                else if (tiro > 87 && tiro <= 88 && !_bolos[9])
                { _bolos[9] = true; puntos++; }
            }
            else if (linea == 3)
            {
                if (tiro <= 10 && !_bolos[6])
                { _bolos[6] = true; puntos++; }
                else if (tiro > 10 && tiro <= 25 && !_bolos[3])
                { _bolos[3] = true; puntos++; }
                else if (tiro > 25 && tiro <= 65 && !_bolos[1])
                { _bolos[1] = true; puntos++; }
                else if (tiro > 65 && tiro <= 80 && !_bolos[0])
                { _bolos[0] = true; puntos++; }
                else if (tiro > 80 && tiro <= 90 && !_bolos[2])
                { _bolos[2] = true; puntos++; }
                else if (tiro > 90 && tiro <= 95 && !_bolos[5])
                { _bolos[5] = true; puntos++; }
                else if (tiro > 95 && tiro <= 96 && !_bolos[9])
                { _bolos[9] = true; puntos++; }
            }
            else if (linea == 4)
            {
                if (tiro <= 5 && !_bolos[6])
                { _bolos[6] = true; puntos++; }
                else if (tiro > 5 && tiro <= 15 && !_bolos[3])
                { _bolos[3] = true; puntos++; }
                else if (tiro > 15 && tiro <= 30 && !_bolos[1])
                { _bolos[1] = true; puntos++; }
                else if (tiro > 30 && tiro <= 70 && !_bolos[0])
                { _bolos[0] = true; puntos++; }
                else if (tiro > 70 && tiro <= 85 && !_bolos[2])
                { _bolos[2] = true; puntos++; }
                else if (tiro > 85 && tiro <= 95 && !_bolos[5])
                { _bolos[5] = true; puntos++; }
                else if (tiro > 95 && tiro <= 99 && !_bolos[9])
                { _bolos[9] = true; puntos++; }
            }
            else if (linea == 5)
            {
                if (tiro <= 0 && !_bolos[6])
                { _bolos[6] = true; puntos++; }
                else if (tiro > 0 && tiro <= 5 && !_bolos[3])
                { _bolos[3] = true; puntos++; }
                else if (tiro > 5 && tiro <= 10 && !_bolos[1])
                { _bolos[1] = true; puntos++; }
                else if (tiro > 10 && tiro <= 25 && !_bolos[0])
                { _bolos[0] = true; puntos++; }
                else if (tiro > 25 && tiro <= 65 && !_bolos[2])
                { _bolos[2] = true; puntos++; }
                else if (tiro > 65 && tiro <= 80 && !_bolos[5])
                { _bolos[5] = true; puntos++; }
                else if (tiro > 80 && tiro <= 90 && !_bolos[9])
                { _bolos[9] = true; puntos++; }
            }
            else if (linea == 6)
            {
                if (tiro <= 0 && !_bolos[6])
                { _bolos[6] = true; puntos++; }
                else if (tiro > 0 && tiro <= 1 && !_bolos[3])
                { _bolos[3] = true; puntos++; }
                else if (tiro > 1 && tiro <= 6 && !_bolos[1])
                { _bolos[1] = true; puntos++; }
                else if (tiro > 6 && tiro <= 16 && !_bolos[0])
                { _bolos[0] = true; puntos++; }
                else if (tiro > 16 && tiro <= 31 && !_bolos[2])
                { _bolos[2] = true; puntos++; }
                else if (tiro > 31 && tiro <= 71 && !_bolos[5])
                { _bolos[5] = true; puntos++; }
                else if (tiro > 71 && tiro <= 86 && !_bolos[9])
                { _bolos[9] = true; puntos++; }
            }
            else if (linea == 7)
            {
                if (tiro <= 0 && !_bolos[6])
                { _bolos[6] = true; puntos++; }
                else if (tiro > 0 && tiro <= 1 && !_bolos[3])
                { _bolos[3] = true; puntos++; }
                else if (tiro > 1 && tiro <= 2 && !_bolos[1])
                { _bolos[1] = true; puntos++; }
                else if (tiro > 2 && tiro <= 7 && !_bolos[0])
                { _bolos[0] = true; puntos++; }
                else if (tiro > 7 && tiro <= 17 && !_bolos[2])
                { _bolos[2] = true; puntos++; }
                else if (tiro > 17 && tiro <= 32 && !_bolos[5])
                { _bolos[5] = true; puntos++; }
                else if (tiro > 32 && tiro <= 72 && !_bolos[9])
                { _bolos[9] = true; puntos++; }
            }

            //CONSECUENCIA HACIA EL FONDO
            for (int i = 0; i < 6; i++)
            {
                if (_bolos[i] && i == 0)
                {
                    if (r.Next(0, 100) + _energia > 50 && !_bolos[1])
                    {
                        _bolos[1] = true; puntos++;
                    }
                    if (r.Next(0, 100) + _energia > 50 && !_bolos[2])
                    {
                        _bolos[2] = true; puntos++;
                    }
                }
                if (_bolos[i] && i == 1)
                {
                    if (r.Next(0, 100) + _energia > 50 && !_bolos[3])
                    {
                        _bolos[3] = true; puntos++;
                    }
                    if (r.Next(0, 100) + _energia > 50 && !_bolos[4])
                    {
                        _bolos[4] = true; puntos++;
                    }
                }
                if (_bolos[i] && i == 2)
                {
                    if (r.Next(0, 100) + _energia > 50 && !_bolos[4])
                    {
                        _bolos[4] = true; puntos++;
                    }
                    if (r.Next(0, 100) + _energia > 50 && !_bolos[5])
                    {
                        _bolos[5] = true; puntos++;
                    }
                }
                if (_bolos[i] && i == 3)
                {
                    if (r.Next(0, 100) + _energia > 50 && !_bolos[6])
                    {
                        _bolos[6] = true; puntos++;
                    }
                    if (r.Next(0, 100) + _energia > 50 && !_bolos[7])
                    {
                        _bolos[7] = true; puntos++;
                    }
                }
                if (_bolos[i] && i == 4)
                {
                    if (r.Next(0, 100) + _energia > 50 && !_bolos[7])
                    {
                        _bolos[7] = true; puntos++;
                    }
                    if (r.Next(0, 100) + _energia > 50 && !_bolos[8])
                    {
                        _bolos[8] = true; puntos++;
                    }
                }
                if (_bolos[i] && i == 5)
                {
                    if (r.Next(0, 100) + _energia > 50 && !_bolos[8])
                    {
                        _bolos[8] = true; puntos++;
                    }
                    if (r.Next(0, 100) + _energia > 50 && !_bolos[9])
                    {
                        _bolos[9] = true; puntos++;
                    }
                }
            }

            Puntuar(TiradaActual, IntentoActual, puntos);

            return _bolos;
        }
        public void Puntuar(int tirada, int intento, int puntos)
        {
            if (intento == 1)
            {
                Marcador.ElementAt(tirada - 1).Intento1 = puntos;
            }
            if (intento == 2)
            {
                Marcador.ElementAt(tirada - 1).Intento2 = puntos;
                Marcador.ElementAt(tirada - 1).TiradaResultado = Marcador.ElementAt(tirada - 1).Intento1 + puntos;
            }
            //EJERCICIO 4 (1 Punto) en BoleraManager.cs y Tirada.cs
            //La suma total de cada tirada no está apareciendo, averigua por qué y arréglalo.

        }
        public void ReponerBolos()
        {
            for (int i = 0; i < 10; i++)
                Bolos[i] = false;
        }
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
