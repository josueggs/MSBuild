
namespace Presentacion
{
    partial class Facturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_Subtotal = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_SubTotalResult = new System.Windows.Forms.Label();
            this.lbl_TotalResult = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Facturar = new System.Windows.Forms.Button();
            this.lbl_CodCliente = new System.Windows.Forms.Label();
            this.txt_CodCliente = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_NombreCliente = new System.Windows.Forms.Label();
            this.txt_CedulaCliente = new System.Windows.Forms.TextBox();
            this.lbl_CedulaCliente = new System.Windows.Forms.Label();
            this.txt_CorreoCliente = new System.Windows.Forms.TextBox();
            this.lbl_CorreoCliente = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Cantidad,
            this.Precio,
            this.Descuento,
            this.Impuesto,
            this.SubTotal});
            this.dataGridView1.Location = new System.Drawing.Point(21, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(931, 281);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.AutoSize = true;
            this.lbl_Subtotal.Location = new System.Drawing.Point(19, 326);
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(65, 17);
            this.lbl_Subtotal.TabIndex = 1;
            this.lbl_Subtotal.Text = "SubTotal";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(190, 326);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(40, 17);
            this.lbl_Total.TabIndex = 2;
            this.lbl_Total.Text = "Total";
            // 
            // lbl_SubTotalResult
            // 
            this.lbl_SubTotalResult.AutoSize = true;
            this.lbl_SubTotalResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTotalResult.Location = new System.Drawing.Point(12, 357);
            this.lbl_SubTotalResult.Name = "lbl_SubTotalResult";
            this.lbl_SubTotalResult.Size = new System.Drawing.Size(122, 55);
            this.lbl_SubTotalResult.TabIndex = 3;
            this.lbl_SubTotalResult.Text = "0.00";
            // 
            // lbl_TotalResult
            // 
            this.lbl_TotalResult.AutoSize = true;
            this.lbl_TotalResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalResult.Location = new System.Drawing.Point(183, 357);
            this.lbl_TotalResult.Name = "lbl_TotalResult";
            this.lbl_TotalResult.Size = new System.Drawing.Size(122, 55);
            this.lbl_TotalResult.TabIndex = 4;
            this.lbl_TotalResult.Text = "0.00";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(961, 383);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(186, 55);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Facturar
            // 
            this.btn_Facturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Facturar.Location = new System.Drawing.Point(961, 322);
            this.btn_Facturar.Name = "btn_Facturar";
            this.btn_Facturar.Size = new System.Drawing.Size(186, 55);
            this.btn_Facturar.TabIndex = 6;
            this.btn_Facturar.Text = "Facturar";
            this.btn_Facturar.UseVisualStyleBackColor = true;
            // 
            // lbl_CodCliente
            // 
            this.lbl_CodCliente.AutoSize = true;
            this.lbl_CodCliente.Location = new System.Drawing.Point(958, 18);
            this.lbl_CodCliente.Name = "lbl_CodCliente";
            this.lbl_CodCliente.Size = new System.Drawing.Size(99, 17);
            this.lbl_CodCliente.TabIndex = 7;
            this.lbl_CodCliente.Text = "Codigo Cliente";
            // 
            // txt_CodCliente
            // 
            this.txt_CodCliente.Location = new System.Drawing.Point(961, 39);
            this.txt_CodCliente.Name = "txt_CodCliente";
            this.txt_CodCliente.Size = new System.Drawing.Size(100, 22);
            this.txt_CodCliente.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(961, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 10;
            // 
            // lbl_NombreCliente
            // 
            this.lbl_NombreCliente.AutoSize = true;
            this.lbl_NombreCliente.Location = new System.Drawing.Point(958, 75);
            this.lbl_NombreCliente.Name = "lbl_NombreCliente";
            this.lbl_NombreCliente.Size = new System.Drawing.Size(58, 17);
            this.lbl_NombreCliente.TabIndex = 9;
            this.lbl_NombreCliente.Text = "Nombre";
            // 
            // txt_CedulaCliente
            // 
            this.txt_CedulaCliente.Location = new System.Drawing.Point(963, 156);
            this.txt_CedulaCliente.Name = "txt_CedulaCliente";
            this.txt_CedulaCliente.Size = new System.Drawing.Size(100, 22);
            this.txt_CedulaCliente.TabIndex = 12;
            // 
            // lbl_CedulaCliente
            // 
            this.lbl_CedulaCliente.AutoSize = true;
            this.lbl_CedulaCliente.Location = new System.Drawing.Point(960, 135);
            this.lbl_CedulaCliente.Name = "lbl_CedulaCliente";
            this.lbl_CedulaCliente.Size = new System.Drawing.Size(52, 17);
            this.lbl_CedulaCliente.TabIndex = 11;
            this.lbl_CedulaCliente.Text = "Cedula";
            // 
            // txt_CorreoCliente
            // 
            this.txt_CorreoCliente.Location = new System.Drawing.Point(963, 217);
            this.txt_CorreoCliente.Name = "txt_CorreoCliente";
            this.txt_CorreoCliente.Size = new System.Drawing.Size(100, 22);
            this.txt_CorreoCliente.TabIndex = 14;
            // 
            // lbl_CorreoCliente
            // 
            this.lbl_CorreoCliente.AutoSize = true;
            this.lbl_CorreoCliente.Location = new System.Drawing.Point(960, 196);
            this.lbl_CorreoCliente.Name = "lbl_CorreoCliente";
            this.lbl_CorreoCliente.Size = new System.Drawing.Size(51, 17);
            this.lbl_CorreoCliente.TabIndex = 13;
            this.lbl_CorreoCliente.Text = "Correo";
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 125;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.MinimumWidth = 6;
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            this.Descuento.Width = 125;
            // 
            // Impuesto
            // 
            this.Impuesto.HeaderText = "Impuesto";
            this.Impuesto.MinimumWidth = 6;
            this.Impuesto.Name = "Impuesto";
            this.Impuesto.ReadOnly = true;
            this.Impuesto.Width = 125;
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "Subtotal";
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 125;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 450);
            this.Controls.Add(this.txt_CorreoCliente);
            this.Controls.Add(this.lbl_CorreoCliente);
            this.Controls.Add(this.txt_CedulaCliente);
            this.Controls.Add(this.lbl_CedulaCliente);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_NombreCliente);
            this.Controls.Add(this.txt_CodCliente);
            this.Controls.Add(this.lbl_CodCliente);
            this.Controls.Add(this.btn_Facturar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_TotalResult);
            this.Controls.Add(this.lbl_SubTotalResult);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_Subtotal);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_Subtotal;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_SubTotalResult;
        private System.Windows.Forms.Label lbl_TotalResult;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Facturar;
        private System.Windows.Forms.Label lbl_CodCliente;
        private System.Windows.Forms.TextBox txt_CodCliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_NombreCliente;
        private System.Windows.Forms.TextBox txt_CedulaCliente;
        private System.Windows.Forms.Label lbl_CedulaCliente;
        private System.Windows.Forms.TextBox txt_CorreoCliente;
        private System.Windows.Forms.Label lbl_CorreoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}