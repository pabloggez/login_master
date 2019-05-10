using System;
using System.Data;
using System.Data.SqlClient;

namespace BaseDatos
{
    public class CBD_m : CConexion_m
    {
        private SqlDataReader sqlDataReader;
        private DataTable dataTable = new DataTable();
        private Exception exception;
        private int iRowsCount;
        private bool bResultado;

        public bool Seleccionar(String sSql)
        {
            bResultado = true;

            using (var con = Conexion())
            {
                con.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = con;
                    comando.CommandText = sSql;
                    try
                    {
                        sqlDataReader = comando.ExecuteReader();

                        dataTable.Load(sqlDataReader);

                        iRowsCount = dataTable.Rows.Count;
                    }
                    catch (Exception ex)
                    {
                        bResultado = false;
                        exception = ex;
                    }
                }
            }

            return bResultado;
        }

        public bool Ejecutar(String sSql)
        {
            bResultado = true;

            using (var con = Conexion())
            {
                con.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = con;
                    comando.CommandText = sSql;

                    try
                    {
                        iRowsCount = comando.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        bResultado = false;
                        exception = ex;
                    }
                }
            }

            return bResultado;
        }

        public Exception getException()
        {
            return exception;
        }

        public DataTable getDataTable()
        {
            return dataTable;
        }

        public int getRowsCount()
        {
            return iRowsCount;
        }
    }
}
