using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisaApp
{
    class LoginController
    {
        private Usuario usuarioActual;

        public bool validarLogin(Usuario usuario)
        {
            DBController dbc = new DBController();
            ArrayList usuarios;
            usuarios = dbc.getUsuarios();
            foreach (Usuario u in usuarios)
            {
                if (usuario.getNombre() == u.getNombre() && usuario.getPassword() == u.getPassword())
                {
                    this.usuarioActual = u;
                    return true;
                }
            }
            return false;
        }

        public Usuario getUsuarioActual()
        {
            return this.usuarioActual;
        }

    }
}
