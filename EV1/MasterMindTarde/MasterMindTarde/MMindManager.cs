using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace MasterMindTarde
{
    public class MMindManager : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //Campos privados
        private int[] _secuencia_objetivo = new int[5];

        private ObservableCollection<Intento> _historico = new ObservableCollection<Intento>();

        //Propiedades

        public int[] Secuencia_objetivo { 
            get {

                return _secuencia_objetivo;
            } 
        }
        public ObservableCollection<Intento> Historico
        {
            get
            {
                return _historico;
            }
            set
            {
                _historico = value;
            }
        }

        //Constructor(es)
        public MMindManager()
        {
            //Generar una nueva secuencia CPU
            Random r = new Random(DateTime.Now.Millisecond);
            _secuencia_objetivo[0] = r.Next(0, 9);
            _secuencia_objetivo[1] = r.Next(0, 9);
            _secuencia_objetivo[2] = r.Next(0, 9);
            _secuencia_objetivo[3] = r.Next(0, 9);
            _secuencia_objetivo[4] = r.Next(0, 9);
        }

        //Metodos
        public string Intentar(int[] secuencia_jugador)
        {
            
            bool acierto_completo = false;
            int aciertos_exactos = 0;
            int aciertos_parciales = 0;
            Intento nuevoIntento = new Intento(secuencia_jugador, "");
            _historico.Add(nuevoIntento);

            for (int i = 0; i < 5; i++)
            {
                acierto_completo = true;
                if (secuencia_jugador[i] != _secuencia_objetivo[i])
                {
                    acierto_completo = false;
                    for (int j = 0; j < 5; j++)
                    {
                        if (secuencia_jugador[i] == _secuencia_objetivo[j])
                        {
                            aciertos_parciales++;
                            break;
                        }
                    }
                }
                else {
                    aciertos_exactos++;
                }
                
            }
            if (acierto_completo)
            {
                nuevoIntento.Resultado = "GG! Acertaste todos los "+ aciertos_exactos.ToString()+" números";
                return nuevoIntento.Resultado;
            }
            nuevoIntento.Resultado = "Aciertos exactos: " + aciertos_exactos.ToString() + " y parciales: " + aciertos_parciales.ToString();
            return nuevoIntento.Resultado;
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}