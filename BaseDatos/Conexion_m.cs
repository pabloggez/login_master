using System.Data.SqlClient;

namespace BaseDatos
{
    public abstract class CConexion_m
    {
        private readonly string conString;

        public CConexion_m()
        {
            conString = @"Server=A4-08\SQLEXPRESS;DataBase=practicas;Integrated Security=True";
        }

        protected SqlConnection Conexion()
        {
            return new SqlConnection(conString);
        }
    }
}
