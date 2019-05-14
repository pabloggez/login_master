namespace Clientes
{
    partial class FClientesMantenimiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.tbPoblacion = new System.Windows.Forms.TextBox();
            this.tbCp = new System.Windows.Forms.TextBox();
            this.tbCif = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.cbProvincia = new System.Windows.Forms.ComboBox();
            this.lbCliente = new System.Windows.Forms.Label();
            this.lbCif = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbCp = new System.Windows.Forms.Label();
            this.lbPoblacion = new System.Windows.Forms.Label();
            this.lbProvincia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(70, 247);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 0;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(301, 246);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(75, 23);
            this.btCerrar.TabIndex = 1;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // tbCliente
            // 
            this.tbCliente.Location = new System.Drawing.Point(133, 22);
            this.tbCliente.MaxLength = 50;
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(100, 20);
            this.tbCliente.TabIndex = 0;
            // 
            // tbPoblacion
            // 
            this.tbPoblacion.Location = new System.Drawing.Point(133, 126);
            this.tbPoblacion.MaxLength = 50;
            this.tbPoblacion.Name = "tbPoblacion";
            this.tbPoblacion.Size = new System.Drawing.Size(100, 20);
            this.tbPoblacion.TabIndex = 4;
            // 
            // tbCp
            // 
            this.tbCp.Location = new System.Drawing.Point(133, 100);
            this.tbCp.MaxLength = 5;
            this.tbCp.Name = "tbCp";
            this.tbCp.Size = new System.Drawing.Size(100, 20);
            this.tbCp.TabIndex = 3;
            // 
            // tbCif
            // 
            this.tbCif.Location = new System.Drawing.Point(133, 48);
            this.tbCif.MaxLength = 5;
            this.tbCif.Name = "tbCif";
            this.tbCif.Size = new System.Drawing.Size(100, 20);
            this.tbCif.TabIndex = 1;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(133, 74);
            this.tbDireccion.MaxLength = 50;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(100, 20);
            this.tbDireccion.TabIndex = 2;
            // 
            // cbProvincia
            // 
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Items.AddRange(new object[] {
            "Alicante",
            "Valencia",
            "Castellon"});
            this.cbProvincia.Location = new System.Drawing.Point(133, 152);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(121, 21);
            this.cbProvincia.TabIndex = 5;
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(70, 22);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(39, 13);
            this.lbCliente.TabIndex = 10;
            this.lbCliente.Text = "Cliente";
            // 
            // lbCif
            // 
            this.lbCif.AutoSize = true;
            this.lbCif.Location = new System.Drawing.Point(70, 48);
            this.lbCif.Name = "lbCif";
            this.lbCif.Size = new System.Drawing.Size(23, 13);
            this.lbCif.TabIndex = 11;
            this.lbCif.Text = "CIF";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(70, 74);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(52, 13);
            this.lbDireccion.TabIndex = 12;
            this.lbDireccion.Text = "Direccion";
            // 
            // lbCp
            // 
            this.lbCp.AutoSize = true;
            this.lbCp.Location = new System.Drawing.Point(70, 100);
            this.lbCp.Name = "lbCp";
            this.lbCp.Size = new System.Drawing.Size(24, 13);
            this.lbCp.TabIndex = 13;
            this.lbCp.Text = "C.P";
            // 
            // lbPoblacion
            // 
            this.lbPoblacion.AutoSize = true;
            this.lbPoblacion.Location = new System.Drawing.Point(70, 126);
            this.lbPoblacion.Name = "lbPoblacion";
            this.lbPoblacion.Size = new System.Drawing.Size(54, 13);
            this.lbPoblacion.TabIndex = 14;
            this.lbPoblacion.Text = "Poblacion";
            // 
            // lbProvincia
            // 
            this.lbProvincia.AutoSize = true;
            this.lbProvincia.Location = new System.Drawing.Point(70, 152);
            this.lbProvincia.Name = "lbProvincia";
            this.lbProvincia.Size = new System.Drawing.Size(59, 13);
            this.lbProvincia.TabIndex = 15;
            this.lbProvincia.Text = "Provicincia";
            // 
            // FClientesMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 329);
            this.Controls.Add(this.lbProvincia);
            this.Controls.Add(this.lbPoblacion);
            this.Controls.Add(this.lbCp);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbCif);
            this.Controls.Add(this.lbCliente);
            this.Controls.Add(this.cbProvincia);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbCif);
            this.Controls.Add(this.tbCp);
            this.Controls.Add(this.tbPoblacion);
            this.Controls.Add(this.tbCliente);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btAceptar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FClientesMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.FClientesMantenimiento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.TextBox tbPoblacion;
        private System.Windows.Forms.TextBox tbCp;
        private System.Windows.Forms.TextBox tbCif;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.ComboBox cbProvincia;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label lbCif;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbCp;
        private System.Windows.Forms.Label lbPoblacion;
        private System.Windows.Forms.Label lbProvincia;
    }
}