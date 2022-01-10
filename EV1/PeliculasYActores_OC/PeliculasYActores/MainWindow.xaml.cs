using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace PeliculasYActores
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Pelicula> listaPeliculas = new ObservableCollection<Pelicula>();
        public MainWindow()
        {
            InitializeComponent();
            ObservableCollection<Actor> listaActoresBatman = new ObservableCollection<Actor>();
            listaActoresBatman.Add(new Actor("Christian Bale", "Está mamadisimo", 1974));
            listaActoresBatman.Add(new Actor("Michael Caine", "Es el mayordomo", 1933));
            listaActoresBatman.Add(new Actor("Liam Neeson", string.Empty, 1952));
            listaActoresBatman.Add(new Actor("Katie Holmes", string.Empty, 1978));
            listaActoresBatman.Add(new Actor("Morgan Freeman", string.Empty, 1937));
            listaActoresBatman.Add(new Actor("Gary Oldman", string.Empty, 1958));

            ObservableCollection<Actor> listaActoresChicago = new ObservableCollection<Actor>();
            listaActoresChicago.Add(new Actor("Renée Zellweger", string.Empty, 1969));
            listaActoresChicago.Add(new Actor("Catherine Zeta-Jones", string.Empty, 1969));
            listaActoresChicago.Add(new Actor("Richard Gere", string.Empty, 1949));
            listaActoresChicago.Add(new Actor("John C. Reilly", string.Empty, 1965));


            listaPeliculas.Add(new Pelicula("Batman Begins", "Inicio de la nueva saga de Batman", 2005, listaActoresBatman));
            listaPeliculas.Add(new Pelicula("Chicago", "Musical sobre dos reclusas en los años 20", 2002, listaActoresChicago));

            DataContext = listaPeliculas;
        }
        private void btnAddPeli_Click(object sender, RoutedEventArgs e)
        {
            if (tbTitulo.Text != "" && tbDesc.Text != "" && tbAnno.Text != "")
            {
                try
                {
                    listaPeliculas.Add(new Pelicula(tbTitulo.Text, tbDesc.Text, int.Parse(tbAnno.Text), new ObservableCollection<Actor>()));
                    tbTitulo.Text = "";
                    tbDesc.Text = "";
                    tbAnno.Text = "";
                }
                catch
                {
                    MessageBox.Show("Introduce un año valido");
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los campos para añadir la pelicula.");
            }
        }
        private void btnAddActor_Click(object sender, RoutedEventArgs e)
        {
            if (tbNombre.Text != "" && tbBiografia.Text != "" && tbNacimiento.Text != "")
            {
                Pelicula currentItem = (Pelicula)listBox1.SelectedItem;
                try
                {
                    currentItem.Actores.Add(new Actor(tbNombre.Text, tbBiografia.Text, int.Parse(tbNacimiento.Text)));
                    tbNombre.Text = "";
                    tbBiografia.Text = "";
                    tbNacimiento.Text = "";
                }
                catch
                {
                    MessageBox.Show("Introduce un año de nacimiento valido");
                }

            }
            else
            {
                MessageBox.Show("Rellene todos los campos para añadir un Actor.");
            }

        }
        private void btnRemoveActor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Pelicula currentFilm = (Pelicula)listBox1.SelectedItem;
                Actor currentActor = (Actor)listBox2.SelectedItem;
                if (currentActor != null)
                {
                    currentFilm.Actores.Remove(currentActor);
                }
                else { throw new Exception(""); }
            } catch {
                MessageBox.Show("Actor no seleccionado.");
            }

        }
        private void btnRemovePeli_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Pelicula currentFilm = (Pelicula)listBox1.SelectedItem;
                if (currentFilm != null)
                {
                    listaPeliculas.Remove(currentFilm);
                }
                else { throw new Exception(""); }
            } catch {
                MessageBox.Show("Ninguna pelicula seleccionada");
            }
            
        }
    }
}