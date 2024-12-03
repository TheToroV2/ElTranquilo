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
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=localhost;Initial Catalog=ElTranquiloDB;Integrated Security=SSPI;";
        private void btEliminarProducto_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrEmpty(txNombre.Text) && string.IsNullOrEmpty(txCodigo.Text))
                {
                    MessageBox.Show("Ingrese al menos un método de búsqueda");
                    return;
                }
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar el producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return; // No se ejecuta la eliminación si el usuario elige "No"
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM Productos WHERE ";

                        if (!string.IsNullOrEmpty(txNombre.Text))
                        {
                            query += "Nombre = @Nombre";
                        }

                        if (!string.IsNullOrEmpty(txCodigo.Text))
                        {
                            if (!string.IsNullOrEmpty(txNombre.Text))
                            {
                                query += " OR ";
                            }

                            query += "ProductoID = @codigo";
                        }

                        SqlCommand command = new SqlCommand(query, connection);

                        if (!string.IsNullOrEmpty(txNombre.Text))
                        {
                            command.Parameters.AddWithValue("@Nombre", txNombre.Text);
                        }

                        if (!string.IsNullOrEmpty(txCodigo.Text))
                        {
                            command.Parameters.AddWithValue("@codigo", txCodigo.Text);
                        }

                        command.ExecuteNonQuery();

                        MessageBox.Show("Producto eliminado correctamente");

                        // Limpiar campos después de eliminar
                        txNombre.Clear();
                        txCodigo.Clear();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error al eliminar el producto: " + ex.Message);
                    }
                }
            }
        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }
