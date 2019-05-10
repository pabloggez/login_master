namespace Login
{
    partial class FLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.eUsuario = new System.Windows.Forms.TextBox();
            this.eContrasena = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.LUsuario = new System.Windows.Forms.Label();
            this.LContrasena = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eUsuario
            // 
            this.eUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.eUsuario.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.eUsuario, "eUsuario");
            this.eUsuario.Name = "eUsuario";
            // 
            // eContrasena
            // 
            this.eContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eContrasena.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.eContrasena, "eContrasena");
            this.eContrasena.Name = "eContrasena";
            this.eContrasena.UseSystemPasswordChar = true;
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btAceptar, "btAceptar");
            this.btAceptar.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btAceptar.FlatAppearance.BorderSize = 0;
            this.btAceptar.ForeColor = System.Drawing.Color.White;
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.TabStop = false;
            this.btAceptar.UseVisualStyleBackColor = false;
            this.btAceptar.Click += new System.EventHandler(this.BtAceptar_Click);
            // 
            // LUsuario
            // 
            resources.ApplyResources(this.LUsuario, "LUsuario");
            this.LUsuario.ForeColor = System.Drawing.Color.Black;
            this.LUsuario.Name = "LUsuario";
            // 
            // LContrasena
            // 
            resources.ApplyResources(this.LContrasena, "LContrasena");
            this.LContrasena.ForeColor = System.Drawing.Color.Black;
            this.LContrasena.Name = "LContrasena";
            // 
            // FLogin
            // 
            this.AcceptButton = this.btAceptar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LContrasena);
            this.Controls.Add(this.LUsuario);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.eContrasena);
            this.Controls.Add(this.eUsuario);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FLogin";
            this.Load += new System.EventHandler(this.FLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eUsuario;
        private System.Windows.Forms.TextBox eContrasena;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.Label LContrasena;
    }
}

