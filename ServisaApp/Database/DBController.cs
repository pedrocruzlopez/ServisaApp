using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;




namespace ServisaApp
{
    class DBController
    {
        private string connStr = "server=localhost;user=root;database=servisa;port=3306;password=1234;";
        
        public void Probar()
        {
            
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                // Perform database operations
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");

        }

        public ArrayList getUsuarios()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            ArrayList usuarios = new ArrayList();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM servisa.usuario";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    string nombre;
                    string password;
                    string rol;

                    nombre = (string) rdr[1];
                    password = (string)rdr[2];
                    rol = (string)rdr[3];
                    Usuario u = new Usuario(nombre, password, rol);
                    usuarios.Add(u);
                   
                }
                rdr.Close();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Existe un problema en la conexión con la base de datos.", "SERVISA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return usuarios;
            }

            conn.Close();
            return usuarios;

            
        }

        public bool insertarNuevoUsuario(Usuario nuevoUsuario)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            ArrayList usuarios = new ArrayList();
            try
            {
                conn.Open();

                string sql = "INSERT INTO servisa.usuario (nombre, password, rol) values ('" + nuevoUsuario.getNombre() + "','" + nuevoUsuario.getPassword() + "','" + nuevoUsuario.getRol() + "')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Existe un problema en la conexión con la base de datos.", "SERVISA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            conn.Close();
            return true;
        }
    }
}
