using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class CLogin_c
    {
        private CLogin_m login = new CLogin_m();

        public bool Correcto(String sUsuario, String sContrasena)
        {
            if (login.Obtener(sUsuario, sContrasena))
            {
                if (login.getRowsCount() > 0)
                    return true;
            }

            return false;
        }
    }
}
