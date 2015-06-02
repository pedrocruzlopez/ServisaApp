using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usuario; 
            String pass;
            bool valido;
            LoginController lc;
            Usuario usuarioActual;

            usuario = this.usuarioTextBox.Text;
            pass = this.passwordTextBox.Text;
            usuarioActual = new Usuario(usuario, pass);
            valido = false;
            lc = new LoginController();
            valido = lc.validarLogin(usuarioActual);

            if (valido)
            {
                usuarioActual = lc.getUsuarioActual();
                this.Hide();
                MainForm mf = new MainForm(usuarioActual);

                mf.Show();
            }
            else
            {
                MessageBox.Show("El usuario y/o la contraseña no son válidos.", "SERVISA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
