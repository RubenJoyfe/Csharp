using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EX2021P1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int v_slot1 = 0;
        int v_slot2 = 0;
        int v_slot3 = 0;

        public int Puntos = 0;
        public ObservableCollection<Jugador> listaJugadores = new ObservableCollection<Jugador>();
        public MainWindow()
        {
            InitializeComponent();
            
            //listaJugadores.Add(new Jugador("Manolo",12000));
            //listaJugadores.Add(new Jugador("Benito",9000));
            DataContext = listaJugadores;
            //EJERCICIO 5 (2 Puntos) Los puntos no se reflejan correctamente en la vista (en la lista de jugadores)
            //            Averigua por qué y corrígelo
        }

        private void btnSpin(object sender, RoutedEventArgs e)
        {
            Random generador = new Random();

            v_slot1 = generador.Next(0, 4);
            v_slot2 = generador.Next(0, 4);
            v_slot3 = generador.Next(0, 4);

            if (v_slot1 == 0)
            {
                Uri imgUri = new Uri("siete.png", UriKind.Relative);
                Slot1.Source = new BitmapImage(imgUri);
            }
            if (v_slot1 == 1)
            {
                Uri imgUri = new Uri("bell.png", UriKind.Relative);
                Slot1.Source = new BitmapImage(imgUri);
            }
            if (v_slot1 == 2)
            {
                Uri imgUri = new Uri("cereza.png", UriKind.Relative);
                Slot1.Source = new BitmapImage(imgUri);
            }
            if (v_slot1 == 3)
            {
                Uri imgUri = new Uri("sandia.png", UriKind.Relative);
                Slot1.Source = new BitmapImage(imgUri);
            }
            if (v_slot2 == 0)
            {
                Uri imgUri = new Uri("siete.png", UriKind.Relative);
                Slot2.Source = new BitmapImage(imgUri);
            }
            if (v_slot2 == 1)
            {
                Uri imgUri = new Uri("bell.png", UriKind.Relative);
                Slot2.Source = new BitmapImage(imgUri);
            }
            if (v_slot2 == 2)
            {
                Uri imgUri = new Uri("cereza.png", UriKind.Relative);
                Slot2.Source = new BitmapImage(imgUri);
            }
            if (v_slot2 == 3)
            {
                Uri imgUri = new Uri("sandia.png", UriKind.Relative);
                Slot2.Source = new BitmapImage(imgUri);
            }
            if (v_slot3 == 0)
            {
                Uri imgUri = new Uri("siete.png", UriKind.Relative);
                Slot3.Source = new BitmapImage(imgUri);
            }
            if (v_slot3 == 1)
            {
                Uri imgUri = new Uri("bell.png", UriKind.Relative);
                Slot3.Source = new BitmapImage(imgUri);
            }
            if (v_slot3 == 2)
            {
                Uri imgUri = new Uri("cereza.png", UriKind.Relative);
                Slot3.Source = new BitmapImage(imgUri);
            }
            if (v_slot3 == 3)
            {
                Uri imgUri = new Uri("sandia.png", UriKind.Relative);
                Slot3.Source = new BitmapImage(imgUri);
            }
            //EJERCICIO 4 (1 punto) Implementa la funcionalidad que permita moverse al tercer slot
            //
            //


            ComprobarResultado();
        }

        private void ComprobarResultado()
        {
            if (v_slot1 == 0 &&
                v_slot2 == 0 &&
                v_slot3 == 0)
            {
                MessageBox.Show("TRIPLE 7!!!");
                Puntos += 1000;
                tbPuntos.Text = Puntos.ToString();
            }

            if (v_slot1 == 1 &&
                v_slot2 == 1 &&
                v_slot3 == 1)
            {
                MessageBox.Show("TRIPLE Campana!!!");
                Puntos += 500;
                tbPuntos.Text = Puntos.ToString();
            }
            if (v_slot1 == 2 &&
                v_slot2 == 2 &&
                v_slot3 == 2)
            {
                MessageBox.Show("TRIPLE Cereza!!!");
                Puntos += 200;
                tbPuntos.Text = Puntos.ToString();
            }
            if (v_slot1 == 3 &&
                v_slot2 == 3 &&
                v_slot3 == 3)
            {
                MessageBox.Show("TRIPLE Sandia!!!");
                Puntos += 100;
                tbPuntos.Text = Puntos.ToString();
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            //EJERCICIO 3.b (1 Punto) Añade el código necesario para que funcione el botón del
            //              ejercicio 3.a y se guarde en listaJugadores
            //              el nombre del textbox y la puntuacion que lleve jugada.
            if (Puntos != 0) { 
                if (Nombre.Text=="" || Nombre.Text == null) {
                    listaJugadores.Add(new Jugador("Anonymous", Puntos));
                }
                else {
                    listaJugadores.Add(new Jugador(Nombre.Text, Puntos));
                }
            
                Nombre.Text = "";
                Puntos = 0;
                tbPuntos.Text = Puntos.ToString();
            }
        }
            

    }
}
