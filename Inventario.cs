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
    public partial class Inventario : Form
    {
        ConexionSQLN negocio = new ConexionSQLN();
        public Inventario()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (negocio.AgregarProducto(txt_Producto.Text.ToUpper(), txt_Categoria.Text.ToUpper(), txt_Precio.Text, 
                txt_Cantidad.Text, txt_Codigo.Text.ToUpper()) == 1)
            {
                negocio.MostrarDGVProductos(dataGridView1);
                MessageBox.Show(txt_Producto.Text.ToUpper() + " agregado exitosamente!");

                txt_Producto.Text = string.Empty;
                txt_Codigo.Text = string.Empty;
                txt_Categoria.Text = string.Empty;
                txt_Precio.Text = string.Empty;
                txt_Cantidad.Text = string.Empty;
            }
            else
                MessageBox.Show("No se pudo agregar el producto");

        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            negocio.MostrarDGVProductos(dataGridView1);
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (negocio.ModificarProducto(txt_Producto.Text.ToUpper(), txt_Categoria.Text.ToUpper(), txt_Precio.Text, 
                txt_Cantidad.Text, txt_Codigo.Text.ToUpper(), txt_Id.Text) == 1)
            {
                MessageBox.Show(txt_Producto.Text.ToUpper() + " modificado exitosamente!");
                negocio.MostrarDGVProductos(dataGridView1);

                txt_Producto.Text = string.Empty;
                txt_Codigo.Text = string.Empty;
                txt_Categoria.Text = string.Empty;
                txt_Precio.Text = string.Empty;
                txt_Cantidad.Text = string.Empty;
                txt_Id.Text = string.Empty;
            }
            else
                MessageBox.Show("No se pudo modificar el producto");
        }

        private void txt_Id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (negocio.ProductoEncontrado(txt_Id.Text) == 1)
                    negocio.EncontrarIdProducto(txt_Producto,txt_Categoria,txt_Precio,txt_Cantidad,txt_Codigo, txt_Id.Text);
                else
                    MessageBox.Show("Producto no registrado!");
        }
    }
}
