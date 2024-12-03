using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace ElTranquilo
{
    public partial class Consulta : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=ElTranquiloDB;Integrated Security=SSPI;";
        public Consulta()
        {
            InitializeComponent();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txNombre.Text) && string.IsNullOrEmpty(txCodigo.Text))
            {
                MessageBox.Show("Ingrese al menos un método de búsqueda");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Productos WHERE ";
                    SqlCommand command = new SqlCommand(query, connection);

                    if (!string.IsNullOrEmpty(txNombre.Text))
                    {
                        command.Parameters.AddWithValue("@Nombre", txNombre.Text);
                        query += "Nombre = @Nombre";
                    }

                    if (!string.IsNullOrEmpty(txCodigo.Text))
                    {
                        if (!string.IsNullOrEmpty(txNombre.Text))
                        {
                            query += " OR ";
                        }

                        command.Parameters.AddWithValue("@codigo", txCodigo.Text);
                        query += "ProductoID = @codigo";
                    }

                    command.CommandText = query;

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        gpConsulta.Visible = true;
                        btNuevaConsulta.Visible = true;
                        txCodigo.Text = reader["ProductoID"].ToString();
                        txNombre.Text = reader["Nombre"].ToString();
                        txID.Text = reader["ProductoID"].ToString();
                        txPrecio.Text = reader["Precio"].ToString();
                        txStock.Text = reader["Stock"].ToString();
                        txProveedor.Text = reader["ProveedorID"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("El producto no existe");
                        txNombre.Clear();
                        txCodigo.Clear();
                        txID.Clear();
                        txPrecio.Clear();
                        txStock.Clear();
                        txProveedor.Clear();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error en la consulta: " + ex.Message);
                }
            }
            btConsultar.Enabled = false;
            btNuevaConsulta.Focus();
            btNuevaConsulta.Enabled = true;
        }

        private void btNuevaConsulta_Click(object sender, EventArgs e)
        {
            txNombre.Clear();
            txCodigo.Clear();
            txID.Clear();
            txPrecio.Clear();
            txStock.Clear();
            txProveedor.Clear();
            btConsultar.Enabled = true;
            btNuevaConsulta.Enabled = false;
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            this.Size = this.MdiParent.ClientSize;
        }
    }
}
