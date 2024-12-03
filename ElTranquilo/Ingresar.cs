using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElTranquilo
{
    public partial class Ingresar : Form
    {
        public Ingresar()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=localhost;Initial Catalog=ElTranquiloDB;Integrated Security=SSPI;";
        private void Ingresar_Load(object sender, EventArgs e)
        {

        }
        private void txNuevoID_TextChanged(object sender, EventArgs e)
        {

        }
        private void btIngresar_Click(object sender, EventArgs e)
        {
            // Verificar que los campos necesarios no estén vacíos
            if (string.IsNullOrEmpty(txNombre.Text) || string.IsNullOrEmpty(txPrecio.Text) || string.IsNullOrEmpty(txStock.Text) || string.IsNullOrEmpty(txProveedor.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos necesarios");
                return;
            }

            // Convertir los valores a los tipos apropiados
            decimal precio;
            int stock;
            int proveedorID;

            if (!decimal.TryParse(txPrecio.Text, out precio))
            {
                MessageBox.Show("El precio debe ser un número válido");
                return;
            }

            if (!int.TryParse(txStock.Text, out stock))
            {
                MessageBox.Show("El stock debe ser un número entero válido");
                return;
            }

            if (!int.TryParse(txProveedor.Text, out proveedorID))
            {
                MessageBox.Show("El ID del proveedor debe ser un número entero válido");
                return;
            }

            // Conectar a la base de datos y ejecutar la consulta INSERT con OUTPUT
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                INSERT INTO Productos (Nombre, Precio, Stock, ProveedorID) 
                OUTPUT INSERTED.ProductoID
                VALUES (@Nombre, @Precio, @Stock, @ProveedorID)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Nombre", txNombre.Text);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@Stock", stock);
                    command.Parameters.AddWithValue("@ProveedorID", proveedorID);

                    // Ejecutar la consulta y obtener el ID generado
                    int nuevoID = (int)command.ExecuteScalar();

                    // Mostrar el nuevo ID en el cuadro de texto
                    txNuevoID.Text = nuevoID.ToString();

                    MessageBox.Show("Producto agregado correctamente");

                    // Limpiar campos después de la inserción
                    txNombre.Clear();
                    txPrecio.Clear();
                    txStock.Clear();
                    txProveedor.Clear();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al agregar el producto: " + ex.Message);
                }
            }
            gbDatos.Visible = true;
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
