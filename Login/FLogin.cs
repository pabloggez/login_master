using System;
using System.Windows.Forms;

namespace Login
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            eUsuario.Focus();
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            if (eUsuario.Text == "")
            {
                MessageBox.Show("El campo usuario no puede estar vacío.");
                eUsuario.Focus();
                return;
            }

            if (eContrasena.Text == "")
            {
                MessageBox.Show("El campo contraseña no puede estar vacío.");
                eContrasena.Focus();
                return;
            }

            CLogin_c login = new CLogin_c();

            if (login.Correcto(eUsuario.Text, eContrasena.Text))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Incorrecto.");
                eUsuario.Focus();
            }
        }
    }
}
