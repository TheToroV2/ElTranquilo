namespace ElTranquilo
{
    partial class Eliminar
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
            this.lbEliminar = new System.Windows.Forms.Label();
            this.gbEliminar = new System.Windows.Forms.GroupBox();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.btRegresar = new System.Windows.Forms.Button();
            this.btEliminarProducto = new System.Windows.Forms.Button();
            this.gbEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEliminar
            // 
            this.lbEliminar.AutoSize = true;
            this.lbEliminar.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEliminar.Location = new System.Drawing.Point(315, 23);
            this.lbEliminar.Name = "lbEliminar";
            this.lbEliminar.Size = new System.Drawing.Size(203, 23);
            this.lbEliminar.TabIndex = 0;
            this.lbEliminar.Text = "Eliminar Producto";
            // 
            // gbEliminar
            // 
            this.gbEliminar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbEliminar.Controls.Add(this.txNombre);
            this.gbEliminar.Controls.Add(this.txCodigo);
            this.gbEliminar.Controls.Add(this.lbCodigo);
            this.gbEliminar.Controls.Add(this.lbNombre);
            this.gbEliminar.ForeColor = System.Drawing.Color.Black;
            this.gbEliminar.Location = new System.Drawing.Point(30, 67);
            this.gbEliminar.Name = "gbEliminar";
            this.gbEliminar.Size = new System.Drawing.Size(447, 100);
            this.gbEliminar.TabIndex = 2;
            this.gbEliminar.TabStop = false;
            this.gbEliminar.Text = "Eliminar";
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(310, 38);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(120, 22);
            this.txNombre.TabIndex = 3;
            // 
            // txCodigo
            // 
            this.txCodigo.Location = new System.Drawing.Point(79, 35);
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.Size = new System.Drawing.Size(100, 22);
            this.txCodigo.TabIndex = 2;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCodigo.Location = new System.Drawing.Point(6, 35);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(57, 16);
            this.lbCodigo.TabIndex = 1;
            this.lbCodigo.Text = "Código: ";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbNombre.Location = new System.Drawing.Point(242, 38);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(62, 16);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre: ";
            // 
            // btRegresar
            // 
            this.btRegresar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btRegresar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btRegresar.Location = new System.Drawing.Point(643, 241);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(115, 51);
            this.btRegresar.TabIndex = 6;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = false;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // btEliminarProducto
            // 
            this.btEliminarProducto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminarProducto.Location = new System.Drawing.Point(643, 67);
            this.btEliminarProducto.Name = "btEliminarProducto";
            this.btEliminarProducto.Size = new System.Drawing.Size(115, 54);
            this.btEliminarProducto.TabIndex = 7;
            this.btEliminarProducto.Text = "Eliminar";
            this.btEliminarProducto.UseVisualStyleBackColor = false;
            this.btEliminarProducto.Click += new System.EventHandler(this.btEliminarProducto_Click);
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.gbEliminar);
            this.Controls.Add(this.lbEliminar);
            this.Controls.Add(this.btEliminarProducto);
            this.Name = "Eliminar";
            this.Text = "Eliminar";
            this.gbEliminar.ResumeLayout(false);
            this.gbEliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEliminar;
        private System.Windows.Forms.GroupBox gbEliminar;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.TextBox txCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Button btEliminarProducto;
    }
}