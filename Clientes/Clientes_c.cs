using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Clientes
{

    class CClientes_c
    {
        private CClientes_m clientes_m = new CClientes_m();

        public int iCliente_id;
        public String sCliente;
        public String sCif;
        public String sDireccion;
        public String sCP;
        public String sPoblacion;
        public String sProvincia;

        public bool Obtener()
        {
            clientes_m.iCliente_id = iCliente_id;

            return clientes_m.Obtener();
        }

        public bool Insertar()
        {
            clientes_m.sCliente = sCliente;
            clientes_m.sCif = sCif;
            clientes_m.sDireccion = sDireccion;
            clientes_m.sCP = sCP;
            clientes_m.sPoblacion = sPoblacion;
            clientes_m.sProvincia = sProvincia;

            return clientes_m.Insertar();
        }

        public bool Modificar()
        {
            return true;
        }

        public bool Borrar()
        {
            return true;
        }

        public DataTable getDataTable()
        {
            return clientes_m.getDataTable();
        }

        public Exception getException()
        {
            return clientes_m.getException();
        }
    }
}
