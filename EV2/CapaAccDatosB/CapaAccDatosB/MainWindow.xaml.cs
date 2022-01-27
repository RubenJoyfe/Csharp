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

namespace CapaAccDatosB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AppManager manager = new AppManager();
        public MainWindow()
        {
            InitializeComponent();
            
            List<object> pelicula = new List<object> { "Pulp Fiction",
            "Unos gangsters de poca monta ven cruzadas sus tramas en circustancias muy duras",
            1995, 1, 1, 3, 4.99, 90, 19.95,
            "G", "Deleted Scenes,Trailers,Commentaries,Behind the Scenes" };
            List<object> salida = new List<object> { };

            salida = manager.InsertarPelicula(pelicula);
        }

    }
}
