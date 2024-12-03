using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ElTranquilo.Menu;

namespace ElTranquilo
{
    public partial class Menu : Form
    {
        private void Menu_Load(object sender, EventArgs e)
        {
        }
        public Menu()
        {
            InitializeComponent();
        }
        public void HabilitarFunciones(bool consulta, bool ingreso, bool eliminacion, bool actualizacion)
        {
            consultaCodigoNombreToolStripMenuItem.Enabled = consulta;
            ingresarProductoToolStripMenuItem.Enabled = ingreso;
            eliminarProductoToolStripMenuItem.Enabled = eliminacion;
            actualizarProductoToolStripMenuItem.Enabled = actualizacion;
            MessageBox.Show("Usuario Obtenido");
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Menu menuForm = new Menu();
            menuForm.MdiParent = this;
            menuForm.Show();
        }
        private void consultaCodigoNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta consultaForm = new Consulta(); // Crea una nueva instancia del formulario Consulta
            consultaForm.MdiParent = this; // Establece el formulario MDI padre
            consultaForm.Show();
        }

        private void ingresarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingresar ingresarForm = new Ingresar();
            ingresarForm.MdiParent = this;
            ingresarForm.Show();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eliminar eliminarForm = new Eliminar();
            eliminarForm.MdiParent = this;
            eliminarForm.Show();
        }

        private void actualizarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actualizar actualizarForm = new Actualizar();
            actualizarForm.MdiParent = this;
            actualizarForm.Show();
        }

        private void salirAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void novedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

        
    

