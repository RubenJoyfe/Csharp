using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;

namespace AccDatosB
{
    class accesoMySql
    {
        string connectionString;
        //string query = "SELECT * FROM user";
        MySqlConnection databaseConnection;
        MySqlCommand commandDatabase;
        MySqlDataReader reader;

        public void crearConexion(string ip="127.0.0.1", string port="3306", string username="root", string pass="1234", string dbname="sakila")
        {
            connectionString = "datasource=" + ip + ";port=" + port + ";username=" + username + ";password=" + pass + ";database=" + dbname + ";";
            databaseConnection = new MySqlConnection(connectionString);
        }

        public void consulta(string query)
        {
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
        }
        public void IUDactionActor(string query)
        {
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                commandDatabase.ExecuteNonQuery();
            }
            catch (MySqlException sqlEx)
            {
                // Mostrar excepciones MYSQL
                MessageBox.Show(sqlEx.Message);
            }
            catch (Exception ex)
            {
                // Mostrar cualquier excepción
                MessageBox.Show(ex.Message);
            }
        }


        public ObservableCollection<Person> leerConsulta()
        {
            ObservableCollection<Person> data = new ObservableCollection<Person>();
            try
            {
                // Abre la base de datos
                databaseConnection.Open();
                // Ejecuta la consultas
                reader = commandDatabase.ExecuteReader();
                // Hasta el momento todo bien, es decir datos obtenidos o no
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // En nuestra base de datos de ejemplo, el array contiene: ID 0, FIRST_NAME 1,LAST_NAME 2, ADDRESS 3
                        // Hacer algo con cada fila obtenida
                        //string [] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                        data.Add(new Person(){actor_id= reader.GetString(0), first_name= reader.GetString(1), last_name= reader.GetString(2), last_update= reader.GetString(3) });
                    }
                    reader.Close();
                    return data;
                }
                else
                {
                    Console.WriteLine("No se encontraron datos.");
                }
                // Cerrar la conexión
                databaseConnection.Close();
            }
            catch (MySqlException sqlEx)
            {
                // Mostrar excepciones MYSQL
                MessageBox.Show(sqlEx.Message);
            }
            catch (Exception ex)
            {
                // Mostrar cualquier excepción
                MessageBox.Show(ex.Message);
            }
            reader.Close();
            return data;
        }

    }


}
