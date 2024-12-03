using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ElTranquilo.Menu;

namespace ElTranquilo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private async void btIngresar_Click(object sender, EventArgs e)
        {
            string username = txUsuario.Text;
            string password = txContrasena.Text;

            var loginData = new { Username = username, PasswordH = password };
            var jsonData = JsonConvert.SerializeObject(loginData);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync("http://localhost:54979/api/Usuarios/Authenticate", content);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Response content: {responseContent}");
                    dynamic responseData = JsonConvert.DeserializeObject(responseContent);

                    if (responseData != null && responseData.success == true)
                    {
                        string rol = responseData.rol; // Obtener el rol del usuario desde la respuesta
                        MessageBox.Show($"Rol del usuario: {rol}");

                        // Variables para habilitar o deshabilitar funciones según el rol
                        bool consulta = false;
                        bool ingreso = false;
                        bool eliminacion = false;
                        bool actualizacion = false;

                        switch (rol)
                        {
                            case "Administrador":
                                consulta = true;
                                ingreso = true;
                                eliminacion = true;
                                actualizacion = true;
                                break;
                            case "Gerente":
                                consulta = true;
                                actualizacion = true;
                                break;
                            case "Empleado":
                                consulta = true;
                                break;
                        }
                        MessageBox.Show($"Consulta: {consulta}, Ingreso: {ingreso}, Eliminacion: {eliminacion}, Actualizacion: {actualizacion}");
                        Menu menuForm = new Menu();
                        // Llamar al método HabilitarFunciones con las variables correspondientes
                        menuForm.HabilitarFunciones(consulta, ingreso, eliminacion, actualizacion);
                        menuForm.Show();
                        MessageBox.Show("Acceso Concedido");
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña inválido");
                    }
                }
                else
                {
                    MessageBox.Show("Error al autenticar");
                }
            }
        }
        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}