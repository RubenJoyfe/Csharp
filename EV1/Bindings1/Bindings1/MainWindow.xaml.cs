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

namespace Bindings1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Persona p = new Persona("Wenceslao", 40);
        public MainWindow()
        {
            InitializeComponent();
            p.Edad = 25;

            //IMPORTANTISIMO el DataContext
            DataContext = p;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            p.Edad++;
            //MessageBox.Show("La edad en el modelo vale:" + p.Edad);
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("La edad en el modelo vale:" + p.Edad);
        }
    }
    


}
