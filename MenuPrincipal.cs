using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Facturacion fact = new Facturacion();
            fact.ShowDialog();
            this.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra toda la APLICACION
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios usuarios = new Usuarios();
            usuarios.ShowDialog();
            this.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventario inventario = new Inventario();
            inventario.ShowDialog();
            this.Show();
        }
    }
}
