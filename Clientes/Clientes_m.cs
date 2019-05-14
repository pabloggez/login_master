using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDatos;

namespace Clientes
{
    public class CClientes_m : CBD_m
    {
        private String sSql;

        public int iCliente_id;
        public String sCliente;
        public String sCif;
        public String sDireccion;
        public String sCP;
        public String sPoblacion;
        public String sProvincia;

        public bool Obtener()
        {
            sSql = "SELECT * FROM clientes";

            if (iCliente_id != 0)
                sSql += " WHERE cliente_id=" + iCliente_id;
            else
                sSql += " ORDER BY cliente";

            return Seleccionar(sSql);

        }

        public bool Insertar()
        {
            sSql = String.Format("INSERT INTO clientes VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                sCliente, sCif, sDireccion, sCP, sPoblacion, sProvincia);

            return Ejecutar(sSql);
        }
    }
}          