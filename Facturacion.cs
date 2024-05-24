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
    public partial class Facturacion : Form
    {
        ConexionSQLN conNegocio = new ConexionSQLN();
        public Facturacion()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            //conNegocio.FactIdProd(txt_CodCliente.Text,dataGridView1);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 0)
            {
                conNegocio.FactIdProd2(dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString());
            }
            if (e.RowIndex != -1 && e.ColumnIndex == 2)
            {
                dataGridView1.Rows[e.RowIndex].Cells["Subtotal"].Value = (int)dataGridView1.Rows[e.RowIndex].Cells["Cantidad"].Value * (int)dataGridView1.Rows[e.RowIndex].Cells["Precio"].Value;
            }
        }
    }
}
