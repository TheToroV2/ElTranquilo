namespace ElTranquilo
{
    partial class Ingresar
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
            this.label1 = new System.Windows.Forms.Label();
            this.gpIngreso = new System.Windows.Forms.GroupBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txProveedor = new System.Windows.Forms.TextBox();
            this.lbProveedor = new System.Windows.Forms.Label();
            this.txStock = new System.Windows.Forms.TextBox();
            this.lbStock = new System.Windows.Forms.Label();
            this.txPrecio = new System.Windows.Forms.TextBox();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lbNuevoProducto = new System.Windows.Forms.Label();
            this.txNuevoID = new System.Windows.Forms.TextBox();
            this.lbIDNuevo = new System.Windows.Forms.Label();
            this.btIngresar = new System.Windows.Forms.Button();
            this.btRegresar = new System.Windows.Forms.Button();
            this.gpIngreso.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Nuevo Producto";
            // 
            // gpIngreso
            // 
            this.gpIngreso.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gpIngreso.Controls.Add(this.lbNombre);
            this.gpIngreso.Controls.Add(this.txProveedor);
            this.gpIngreso.Controls.Add(this.lbProveedor);
            this.gpIngreso.Controls.Add(this.txStock);
            this.gpIngreso.Controls.Add(this.lbStock);
            this.gpIngreso.Controls.Add(this.txPrecio);
            this.gpIngreso.Controls.Add(this.lbPrecio);
            this.gpIngreso.Controls.Add(this.txNombre);
            this.gpIngreso.Location = new System.Drawing.Point(22, 73);
            this.gpIngreso.Name = "gpIngreso";
            this.gpIngreso.Size = new System.Drawing.Size(447, 173);
            this.gpIngreso.TabIndex = 3;
            this.gpIngreso.TabStop = false;
            this.gpIngreso.Text = "Ingresar Campos";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(6, 37);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(62, 16);
            this.lbNombre.TabIndex = 8;
            this.lbNombre.Text = "Nombre: ";
            // 
            // txProveedor
            // 
            this.txProveedor.Location = new System.Drawing.Point(105, 125);
            this.txProveedor.Name = "txProveedor";
            this.txProveedor.Size = new System.Drawing.Size(100, 22);
            this.txProveedor.TabIndex = 7;
            // 
            // lbProveedor
            // 
            this.lbProveedor.AutoSize = true;
            this.lbProveedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbProveedor.Location = new System.Drawing.Point(6, 131);
            this.lbProveedor.Name = "lbProveedor";
            this.lbProveedor.Size = new System.Drawing.Size(93, 16);
            this.lbProveedor.TabIndex = 6;
            this.lbProveedor.Text = "Proveedor ID: ";
            // 
            // txStock
            // 
            this.txStock.Location = new System.Drawing.Point(105, 91);
            this.txStock.Name = "txStock";
            this.txStock.Size = new System.Drawing.Size(100, 22);
            this.txStock.TabIndex = 5;
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbStock.Location = new System.Drawing.Point(6, 99);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(47, 16);
            this.lbStock.TabIndex = 4;
            this.lbStock.Text = "Stock: ";
            // 
            // txPrecio
            // 
            this.txPrecio.Location = new System.Drawing.Point(105, 63);
            this.txPrecio.Name = "txPrecio";
            this.txPrecio.Size = new System.Drawing.Size(100, 22);
            this.txPrecio.TabIndex = 3;
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbPrecio.Location = new System.Drawing.Point(6, 69);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(52, 16);
            this.lbPrecio.TabIndex = 2;
            this.lbPrecio.Text = "Precio: ";
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(105, 31);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(100, 22);
            this.txNombre.TabIndex = 1;
            // 
            // gbDatos
            // 
            this.gbDatos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbDatos.Controls.Add(this.lbNuevoProducto);
            this.gbDatos.Controls.Add(this.txNuevoID);
            this.gbDatos.Controls.Add(this.lbIDNuevo);
            this.gbDatos.Location = new System.Drawing.Point(22, 293);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(245, 69);
            this.gbDatos.TabIndex = 4;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos Basicos";
            this.gbDatos.Visible = false;
            // 
            // lbNuevoProducto
            // 
            this.lbNuevoProducto.AutoSize = true;
            this.lbNuevoProducto.Location = new System.Drawing.Point(6, 34);
            this.lbNuevoProducto.Name = "lbNuevoProducto";
            this.lbNuevoProducto.Size = new System.Drawing.Size(126, 16);
            this.lbNuevoProducto.TabIndex = 5;
            this.lbNuevoProducto.Text = "ID Nuevo Producto: ";
            // 
            // txNuevoID
            // 
            this.txNuevoID.Location = new System.Drawing.Point(161, 28);
            this.txNuevoID.Name = "txNuevoID";
            this.txNuevoID.Size = new System.Drawing.Size(56, 22);
            this.txNuevoID.TabIndex = 1;
            this.txNuevoID.TextChanged += new System.EventHandler(this.txNuevoID_TextChanged);
            // 
            // lbIDNuevo
            // 
            this.lbIDNuevo.Location = new System.Drawing.Point(0, 0);
            this.lbIDNuevo.Name = "lbIDNuevo";
            this.lbIDNuevo.Size = new System.Drawing.Size(100, 23);
            this.lbIDNuevo.TabIndex = 4;
            this.lbIDNuevo.Text = "Datos Basicos";
            // 
            // btIngresar
            // 
            this.btIngresar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btIngresar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btIngresar.Location = new System.Drawing.Point(527, 73);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(124, 51);
            this.btIngresar.TabIndex = 5;
            this.btIngresar.Text = "Ingresar";
            this.btIngresar.UseVisualStyleBackColor = false;
            this.btIngresar.Click += new System.EventHandler(this.btIngresar_Click);
            // 
            // btRegresar
            // 
            this.btRegresar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btRegresar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btRegresar.Location = new System.Drawing.Point(527, 311);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(124, 51);
            this.btRegresar.TabIndex = 7;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = false;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // Ingresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.btIngresar);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.gpIngreso);
            this.Controls.Add(this.label1);
            this.Name = "Ingresar";
            this.Text = "Ingresar";
            this.Load += new System.EventHandler(this.Ingresar_Load);
            this.gpIngreso.ResumeLayout(false);
            this.gpIngreso.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpIngreso;
        private System.Windows.Forms.TextBox txProveedor;
        private System.Windows.Forms.Label lbProveedor;
        private System.Windows.Forms.TextBox txStock;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.TextBox txPrecio;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lbIDNuevo;
        private System.Windows.Forms.TextBox txNuevoID;
        private System.Windows.Forms.Button btIngresar;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Label lbNuevoProducto;
    }
}