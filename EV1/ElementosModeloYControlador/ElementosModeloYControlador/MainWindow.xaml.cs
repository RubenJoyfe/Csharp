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

namespace ElementosModeloYControlador
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        Perfil perf = new Perfil();
 
        
        public MainWindow()
        {
            InitializeComponent();
            perf.ResolucionAltura = 600;
            perf.DificultadPrograma = Perfil.Dificultad.Medio;

            DateTime fecha_nac = new DateTime(2013, 1, 1);

            if(perf.RegistrarFecha(fecha_nac))
            {
                MessageBox.Show("La fecha se registro bien");
            }
            else
            {
                MessageBox.Show("Es menor de edad.");
            }

        }
        public void Metodo_Click(object sender, RoutedEventArgs e)
        {
            tb_esquina.Text = "Texto después del Click";
        }
        

    }

        
}
