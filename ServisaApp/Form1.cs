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
    public partial class MainForm : Form
    {
        private Usuario usuarioActual;

        public MainForm(Usuario usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(usuarioActual.getNombre() + " ::: " + usuarioActual.getRol());
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*funcionalidad autorizada únicamente para usuarios administradores*/

            string rol = this.usuarioActual.getRol();

            if (rol == "administrador")
            {
                CrearUsuario cu = new CrearUsuario();
                cu.Show();
            }
            else
            {
                MessageBox.Show("No tiene privelegios para utilizar ésta funcionalidad", "SERVISA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
