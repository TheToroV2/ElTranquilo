namespace ElTranquilo
{
    partial class Login
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbContrasena = new System.Windows.Forms.Label();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.txContrasena = new System.Windows.Forms.TextBox();
            this.btIngresar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(99, 18);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(259, 23);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Aplicación El Tranquilo";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(53, 76);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(77, 20);
            this.lbUsuario.TabIndex = 1;
            this.lbUsuario.Text = "Usuario: ";
            // 
            // lbContrasena
            // 
            this.lbContrasena.AutoSize = true;
            this.lbContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContrasena.Location = new System.Drawing.Point(53, 119);
            this.lbContrasena.Name = "lbContrasena";
            this.lbContrasena.Size = new System.Drawing.Size(114, 20);
            this.lbContrasena.TabIndex = 2;
            this.lbContrasena.Text = "Constraseña: ";
            // 
            // txUsuario
            // 
            this.txUsuario.Location = new System.Drawing.Point(169, 76);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(144, 22);
            this.txUsuario.TabIndex = 3;
            // 
            // txContrasena
            // 
            this.txContrasena.Location = new System.Drawing.Point(169, 116);
            this.txContrasena.Name = "txContrasena";
            this.txContrasena.Size = new System.Drawing.Size(144, 22);
            this.txContrasena.TabIndex = 4;
            this.txContrasena.UseSystemPasswordChar = true;
            // 
            // btIngresar
            // 
            this.btIngresar.Location = new System.Drawing.Point(57, 189);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(91, 37);
            this.btIngresar.TabIndex = 5;
            this.btIngresar.Text = "Ingresar";
            this.btIngresar.UseVisualStyleBackColor = true;
            this.btIngresar.Click += new System.EventHandler(this.btIngresar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(222, 189);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(91, 37);
            this.btSalir.TabIndex = 7;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(451, 285);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btIngresar);
            this.Controls.Add(this.txContrasena);
            this.Controls.Add(this.txUsuario);
            this.Controls.Add(this.lbContrasena);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbTitulo);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logueo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbContrasena;
        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.TextBox txContrasena;
        private System.Windows.Forms.Button btIngresar;
        private System.Windows.Forms.Button btSalir;
    }
}

