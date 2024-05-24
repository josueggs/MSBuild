
namespace Presentacion
{
    partial class Inventario
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
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.txt_Producto = new System.Windows.Forms.TextBox();
            this.txt_Categoria = new System.Windows.Forms.TextBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.lbl_Producto = new System.Windows.Forms.Label();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(683, 379);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(100, 32);
            this.btn_Cerrar.TabIndex = 0;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 262);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(13, 379);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(100, 32);
            this.btn_Agregar.TabIndex = 2;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(683, 337);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(100, 32);
            this.btn_Modificar.TabIndex = 4;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // txt_Producto
            // 
            this.txt_Producto.Location = new System.Drawing.Point(13, 347);
            this.txt_Producto.Name = "txt_Producto";
            this.txt_Producto.Size = new System.Drawing.Size(100, 22);
            this.txt_Producto.TabIndex = 5;
            // 
            // txt_Categoria
            // 
            this.txt_Categoria.Location = new System.Drawing.Point(225, 347);
            this.txt_Categoria.Name = "txt_Categoria";
            this.txt_Categoria.Size = new System.Drawing.Size(100, 22);
            this.txt_Categoria.TabIndex = 6;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(331, 347);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(100, 22);
            this.txt_Precio.TabIndex = 7;
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(437, 347);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(100, 22);
            this.txt_Cantidad.TabIndex = 8;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(683, 309);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(100, 22);
            this.txt_Id.TabIndex = 9;
            this.txt_Id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Id_KeyDown);
            // 
            // lbl_Producto
            // 
            this.lbl_Producto.AutoSize = true;
            this.lbl_Producto.Location = new System.Drawing.Point(13, 324);
            this.lbl_Producto.Name = "lbl_Producto";
            this.lbl_Producto.Size = new System.Drawing.Size(65, 17);
            this.lbl_Producto.TabIndex = 10;
            this.lbl_Producto.Text = "Producto";
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Location = new System.Drawing.Point(226, 324);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(69, 17);
            this.lbl_Categoria.TabIndex = 11;
            this.lbl_Categoria.Text = "Categoria";
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Location = new System.Drawing.Point(328, 324);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(48, 17);
            this.lbl_Precio.TabIndex = 12;
            this.lbl_Precio.Text = "Precio";
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(434, 324);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(64, 17);
            this.lbl_Cantidad.TabIndex = 13;
            this.lbl_Cantidad.Text = "Cantidad";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(680, 285);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(19, 17);
            this.lbl_Id.TabIndex = 14;
            this.lbl_Id.Text = "Id";
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Location = new System.Drawing.Point(116, 324);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(52, 17);
            this.lbl_Codigo.TabIndex = 16;
            this.lbl_Codigo.Text = "Codigo";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(119, 347);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(100, 22);
            this.txt_Codigo.TabIndex = 15;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.lbl_Codigo);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_Cantidad);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.lbl_Categoria);
            this.Controls.Add(this.lbl_Producto);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.txt_Categoria);
            this.Controls.Add(this.txt_Producto);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Cerrar);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.TextBox txt_Producto;
        private System.Windows.Forms.TextBox txt_Categoria;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label lbl_Producto;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.TextBox txt_Codigo;
    }
}