using System;
using System.Collections.Generic;
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

namespace Enunciado2122P1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BoleraManager manager = new BoleraManager();
        
        public MainWindow()
        {
            InitializeComponent();
            DataContext = manager;
        }
        public void Lanzar_Click(object sender, RoutedEventArgs e)
        {

            bool[] resultado = manager.Lanzar((int)sld_linea.Value, (int)sld_energia.Value);
            RefrescarYPintar();

            if (manager.IntentoActual == 1)
                manager.IntentoActual = 2;
            else
            {
                manager.IntentoActual = 1;
                manager.TiradaActual++;
                manager.ReponerBolos();
            }

            if (manager.TiradaActual == 11)
            {
                ReiniciarJuego();
            }
            //EJERCICIO 5 (2 Puntos) en MainWindow.xaml.cs
            //Si llegas al final de la partida, notarás que el programa falla.
            //Consigue que al terminar el programa salga un mensaje de FIN DE PARTIDA
            //con un texto en la Vista o directamente un MessageBox que refleje la suma total de todas las tiradas.
            //Luego haz que se vacíe el marcador y que el juego comience de nuevo.
        }

        private void ReiniciarJuego() {
            manager.TiradaActual = 1;
            manager.IntentoActual = 1;
            MessageBox.Show("Partida Finalizada, puntos conseguidos: " + manager.totalPuntosRonda().ToString(), "FIN DE PARTIDA");
            manager.puntuacionesTotales.Add(manager.totalPuntosRonda());
            //MessageBox.Show("" + manager.puntuacionesTotales.ElementAt(0).ToString());
            manager.reiniciarPuntuaciones();
            RefrescarYPintar();
            
        }

        private void RefrescarYPintar()
        {
            ////REFRESCAR IMAGEN Y PINTAR

            SolidColorBrush colorTirado = new SolidColorBrush();
            colorTirado.Color = Colors.OrangeRed;
            SolidColorBrush colorEnPie = new SolidColorBrush();
            colorEnPie.Color = Colors.WhiteSmoke;

            e_bolo_1.Fill = colorEnPie;
            e_bolo_2.Fill = colorEnPie;
            e_bolo_3.Fill = colorEnPie;
            e_bolo_4.Fill = colorEnPie;
            e_bolo_5.Fill = colorEnPie;
            e_bolo_6.Fill = colorEnPie;
            e_bolo_7.Fill = colorEnPie;
            e_bolo_8.Fill = colorEnPie;
            e_bolo_9.Fill = colorEnPie;
            e_bolo_10.Fill = colorEnPie;

            for (int i = 0; i < 10; i++)
            {
                if (manager.Bolos[i] && i == 0)
                    e_bolo_1.Fill = colorTirado;
                if (manager.Bolos[i] && i == 1)
                    e_bolo_2.Fill = colorTirado;
                if (manager.Bolos[i] && i == 2)
                    e_bolo_3.Fill = colorTirado;
                if (manager.Bolos[i] && i == 3)
                    e_bolo_4.Fill = colorTirado;
                if (manager.Bolos[i] && i == 4)
                    e_bolo_5.Fill = colorTirado;
                if (manager.Bolos[i] && i == 5)
                    e_bolo_6.Fill = colorTirado;
                if (manager.Bolos[i] && i == 6)
                    e_bolo_7.Fill = colorTirado;
                if (manager.Bolos[i] && i == 7)
                    e_bolo_8.Fill = colorTirado;
                if (manager.Bolos[i] && i == 8)
                    e_bolo_9.Fill = colorTirado;
                if (manager.Bolos[i] && i == 9)
                    e_bolo_10.Fill = colorTirado;
            }
        }
    }
}
