using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clientes
{
    public partial class FClientes : Form
    {
        

        public FClientes()
        {
            InitializeComponent();
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FClientes_Load(object sender, EventArgs e)
        {

        }

        private void btRefrescar_Click(object sender, EventArgs e)
        {
            CClientes_c clientes_c = new CClientes_c();

            clientes_c.iCliente_id = 0;
            if (clientes_c.Obtener())
            {
                dataGridView1.DataSource = clientes_c.getDataTable();

                dataGridView1.Columns["cliente_id"].Visible = false;
            }
            else
                MessageBox.Show("Error al cargar la tabla clientes." + clientes_c.getException());
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            FClientesMantenimiento fClientesMantenimiento = new FClientesMantenimiento();

            fClientesMantenimiento.iCliente_id = 0; 

            if (fClientesMantenimiento.ShowDialog() == DialogResult.OK)
            {
                btRefrescar_Click(sender, e);
            }
        }
    }
}
