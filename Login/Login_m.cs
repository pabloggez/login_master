using System;
using BaseDatos;

namespace Login
{
    public class CLogin_m : CBD_m
    {
        String sSql = "";

        public bool Obtener(String sUsuario, String sContrasena)
        {
            sSql = "SELECT * FROM usuarios WHERE usuario='" + sUsuario + "' AND contrasena='" + sContrasena + "'";

            return Seleccionar(sSql);
        }
    }
}
