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
    public partial class FClientesMantenimiento : Form
    {
        public int iCliente_id;

        public FClientesMantenimiento()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            CClientes_c cliente = new CClientes_c();

            cliente.sCliente = tbCliente.Text;
            cliente.sCif = tbCif.Text;
            cliente.sDireccion = tbDireccion.Text;
            cliente.sCP = tbCp.Text;
            cliente.sProvincia = cbProvincia.Text;

            

            if (cliente.Insertar())
            {
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Error al insertar el cliente. \n\n" + cliente.getException());
            
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        private void FClientesMantenimiento_Load(object sender, EventArgs e)
        {
            if (iCliente_id == 0)
            {
                Text = "CLIENTES :: NUEVO";
            }
            else
                Text = "CLIENTES :: MODIFICAR";
        }
    }
}
