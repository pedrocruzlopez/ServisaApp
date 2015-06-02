using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisaApp
{
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* cierra ventana al presionar "Cancelar" */
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario;
            string rol;
            string password;
            string confpassword;

            usuario = this.usuarioBox.Text;
            rol = this.rolComboBox.SelectedItem.ToString();
            password = this.passBox.Text;
            confpassword = this.confpassText.Text;

            DBController dbc = new DBController();
            ArrayList usuarios = dbc.getUsuarios();

            /*valida que la contrasña no exceda los 8 caracteres */

            if (password.Length > 8)
            {
                MessageBox.Show("La contraseña no debe exceder los 8 caracteres", "SERVISA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            /* valida que las contraseñas coincidan */
            if (password != confpassword)
            {
                MessageBox.Show("Las constraseñas no coinciden", "SERVISA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
   
            /* valida que el usuario no exista en la base de datos */
            foreach (Usuario u in usuarios)
            {
                if (usuario == u.getNombre())
                {
                    MessageBox.Show("El nombre de usuario ya está registrado.", "SERVISA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            /* inserta nuevo usuario en la base de datos */

            Usuario nuevoUsuario = new Usuario(usuario, password, rol);
            bool exito = dbc.insertarNuevoUsuario(nuevoUsuario);

            if (exito)
            {
                MessageBox.Show("Usuario creado exitósamente", "SERVISA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
