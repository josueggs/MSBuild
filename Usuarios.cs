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
    public partial class Usuarios : Form
    {
        ConexionSQLN conNegocio = new ConexionSQLN();
        public Usuarios()
        {
            InitializeComponent();
            //dgv1.DataSource = conNegocio.ConsultaDGV(); // Otra forma para mostrar cuando inicie el form
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            dgv1.DataSource = conNegocio.ConsultaDGV();
            //conNegocio.MostrarDGV(dgv1);
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (conNegocio.AgregarUsuario(txt_Nombre.Text.ToUpper(), txt_Apellidos.Text.ToUpper(), txt_Cedula.Text.ToUpper(), txt_Usuario.Text.ToUpper(), txt_Contrasena.Text) == 1)
            {
                MessageBox.Show(txt_Nombre.Text.ToUpper() + " agregado exitosamente!");

                txt_Nombre.Text = string.Empty;
                txt_Apellidos.Text = string.Empty;
                txt_Cedula.Text = string.Empty;
                txt_Usuario.Text = string.Empty;
                txt_Contrasena.Text = string.Empty;
            }
            else
                MessageBox.Show("No se pudo agregar al usuario!");
            dgv1.DataSource = conNegocio.ConsultaDGV();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (conNegocio.ModificarUsuario(txt_Nombre.Text.ToUpper(), txt_Apellidos.Text.ToUpper(), txt_Cedula.Text.ToUpper(), txt_Usuario.Text.ToUpper(), txt_Contrasena.Text, txt_Id.Text) == 1)
            {
                MessageBox.Show(txt_Nombre.Text.ToUpper() + " modificado exitosamente!");

                txt_Nombre.Text = string.Empty;
                txt_Apellidos.Text = string.Empty;
                txt_Cedula.Text = string.Empty;
                txt_Usuario.Text = string.Empty;
                txt_Contrasena.Text = string.Empty;
                txt_Id.Text = string.Empty;
            }
            else
                MessageBox.Show("No se encontró el usuario!");
            dgv1.DataSource = conNegocio.ConsultaDGV();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (conNegocio.EliminarUsuario(txt_Id.Text) == 1)
            {
                MessageBox.Show(txt_Nombre.Text.ToUpper() + " eliminado exitosamente!");

                txt_Nombre.Text = string.Empty;
                txt_Apellidos.Text = string.Empty;
                txt_Cedula.Text = string.Empty;
                txt_Usuario.Text = string.Empty;
                txt_Contrasena.Text = string.Empty;
                txt_Id.Text = string.Empty;
            }
            else
                MessageBox.Show("No se encontró el usuario!");
            dgv1.DataSource = conNegocio.ConsultaDGV();
        }

        private void txt_Id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (conNegocio.UsuarioEncontrado(txt_Id.Text) != 0)
                    conNegocio.EncontrarId(txt_Nombre, txt_Apellidos, txt_Cedula, txt_Usuario, txt_Contrasena, txt_Id.Text);
                else
                    MessageBox.Show("Usuario no esta registrado!");
        }
    }
}
