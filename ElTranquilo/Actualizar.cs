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
    public partial class Actualizar : Form
    {
        public Actualizar()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=localhost;Initial Catalog=ElTranquiloDB;Integrated Security=SSPI;";

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txID.Text))
            {
                MessageBox.Show("Ingrese el ID del producto a buscar");
                return;
            }

            int productoID;
            if (!int.TryParse(txID.Text, out productoID))
            {
                MessageBox.Show("El ID del producto debe ser un número entero válido");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Productos WHERE ProductoID = @ProductoID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductoID", productoID);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // Producto encontrado, mostrar los detalles en los campos de texto
                        txNombre.Text = reader["Nombre"].ToString();
                        txPrecio.Text = reader["Precio"].ToString();
                        txStock.Text = reader["Stock"].ToString();
                        txProveedor.Text = reader["ProveedorID"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado");
                        txNombre.Clear();
                        txPrecio.Clear();
                        txStock.Clear();
                        txProveedor.Clear();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al buscar el producto: " + ex.Message);
                }
            }
            gbActualizar.Visible = true;
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            {
                // Verificar que los campos necesarios no estén vacíos
                if (string.IsNullOrEmpty(txID.Text) || string.IsNullOrEmpty(txNombre.Text) || string.IsNullOrEmpty(txPrecio.Text) || string.IsNullOrEmpty(txStock.Text) || string.IsNullOrEmpty(txProveedor.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos necesarios");
                    return;
                }

                // Convertir los valores a los tipos apropiados
                decimal precio;
                int stock;
                int proveedorID;
                int productoID;

                if (!int.TryParse(txID.Text, out productoID))
                {
                    MessageBox.Show("El ID del producto debe ser un número entero válido");
                    return;
                }

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

                // Conectar a la base de datos y ejecutar la consulta UPDATE
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = @"
                UPDATE Productos
                SET Nombre = @Nombre,
                    Precio = @Precio,
                    Stock = @Stock,
                    ProveedorID = @ProveedorID
                WHERE ProductoID = @ProductoID";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Nombre", txNombre.Text);
                        command.Parameters.AddWithValue("@Precio", precio);
                        command.Parameters.AddWithValue("@Stock", stock);
                        command.Parameters.AddWithValue("@ProveedorID", proveedorID);
                        command.Parameters.AddWithValue("@ProductoID", productoID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Producto actualizado correctamente");

                            // Limpiar campos después de la actualización
                            txID.Clear();
                            txNombre.Clear();
                            txPrecio.Clear();
                            txStock.Clear();
                            txProveedor.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el producto con el ID especificado");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error al actualizar el producto: " + ex.Message);
                    }
                }
            }
        }       
    }
}
