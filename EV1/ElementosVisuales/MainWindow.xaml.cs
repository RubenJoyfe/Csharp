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

namespace ElementosVisuales
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Perfil perf = new Perfil(DateTime.Parse("2002/04/20"));

        public MainWindow()
        {
            InitializeComponent();
            
        }
        public void verEdad(object sender, RoutedEventArgs e)
        {
            bonjour.Text = perf.RegistrarFecha(DateTime.Now).ToString();
        }
    }
}
