using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisaApp
{
    public class Usuario
    {
        public string nombre, password, rol;

        public Usuario(string nombre, string password)
        {
            this.nombre = nombre;
            this.password = password;
            this.rol = "";
        }

        public Usuario(string nombre, string password, string rol)
        {
            this.nombre = nombre;
            this.password = password;
            this.rol = rol;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public string getPassword()
        {
            return this.password;
        }

        public string getRol()
        {
            return this.rol;
        }
    }
}
