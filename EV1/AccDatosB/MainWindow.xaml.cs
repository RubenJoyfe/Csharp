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


namespace AccDatosB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private ObservableCollection<Person> actor;
        accesoMySql conx;

        public MainWindow()
        {
            InitializeComponent();
            selectActor();
        }
        private void selectActor()
        {
            actor = new ObservableCollection<Person>();
            conx = new accesoMySql();
            conx.crearConexion();
            conx.consulta("SELECT * FROM actor");
            actor = conx.leerConsulta();
            lstNames.ItemsSource = actor;
        }
        private void btnInsert_click(object sender, RoutedEventArgs e)
        {
            string newid = maxActorId(), fname = txtFirstName.Text, lname = txtLastName.Text, actualDate = DateTime.Now.ToString(), adFormat = DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss");
            string insertQuery = "INSERT INTO actor VALUES(" + newid + ", '" + fname + "', '" + lname + "', '" + adFormat + "')";

            conx.IUDactionActor(insertQuery);
            actor.Add(new Person() { actor_id = newid, first_name = fname, last_name = lname, last_update = actualDate });
            clearTxts();
        }
        private void btnUpdate_click(object sender, RoutedEventArgs e)
        {
            string aid = txtID.Text;
            if (aid == "")
            {
                getSelectedRow();
                aid = txtID.Text;
            }
            string fname = txtFirstName.Text, lname = txtLastName.Text, actualDate = DateTime.Now.ToString(), adFormat = DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss");
            string updateQuery = "UPDATE actor SET first_name='"+fname+ "', last_name='" + lname + "', last_update='"+ adFormat + "' WHERE actor_id = "+ aid + "";
            conx.IUDactionActor(updateQuery);
            selectActor();
            clearTxts();
        }
        private void btnDelete_click(object sender, RoutedEventArgs e)
        {
            string idDEL = txtID.Text;
            if (idDEL == "")
            {
                getSelectedRow();
                idDEL = txtID.Text;
            }
            string deleteQuery = "DELETE FROM actor WHERE actor_id = "+ idDEL + "";

            conx.IUDactionActor(deleteQuery);
            removeFromList(idDEL);
            clearTxts();
        }

        private string maxActorId()
        {
            int maxId=0;
            foreach (Person pp in actor)
            {
                if (int.Parse(pp.actor_id) > maxId)
                {
                    maxId = int.Parse(pp.actor_id);
                }
            }
            return (maxId + 1).ToString();
        }
        private void removeFromList(string id_remove)
        {
            try{
                foreach (Person pp in actor)
                {
                    if (pp.actor_id.Equals(id_remove))
                    {
                        actor.Remove(pp);
                    }
                }
            }
            catch(Exception e)
            {
                //MessageBox.Show(e.Message, "UGABUGA");
            }

            
        }

        private void btn_cargar(object sender, EventArgs e)
        {
            getSelectedRow();
        }

        private void getSelectedRow()
        {
            Person a = (Person)lstNames.SelectedItem;
            if (a != null)
            {
                txtID.Text = a.actor_id;
                txtFirstName.Text = a.first_name;
                txtLastName.Text = a.last_name;
            }
            else
            {
                MessageBox.Show("Selecciona un actor para poder cargar sus datos", "Actor no seleccionado:");
            }
        }
        private void clearTxts()
        {
            txtID.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
        }

    }
}

