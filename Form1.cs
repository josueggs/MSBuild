using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        ConexionSQLN conNegocio = new ConexionSQLN();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            this.Hide(); // oculta el form pero queda en memoria
            MenuPrincipal main = new MenuPrincipal(); // Para usar el otro form, el NAMESPACE debe ser el mismo en ambos forms
            main.Show();
            /*if (conNegocio.conSQL(txt_Usuario.Text.ToUpper(), txt_Contraseña.Text.ToUpper()) == 1)
            {
                MessageBox.Show("Bienvenido " + txt_Usuario.Text.ToUpper() + "!");

                this.Hide(); // oculta el form pero queda en memoria
                MenuPrincipal main = new MenuPrincipal(); // Para usar el otro form, el NAMESPACE debe ser el mismo en ambos forms
                main.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta, vuelva a intentarlo!");

                txt_Contraseña.Text = string.Empty;
            }*/
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
