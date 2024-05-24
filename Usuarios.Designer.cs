
namespace Presentacion
{
    partial class Usuarios
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.txt_Cedula = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Apellidos = new System.Windows.Forms.Label();
            this.lbl_Cedula = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.gb = new System.Windows.Forms.GroupBox();
            this.lbl_Contrasena = new System.Windows.Forms.Label();
            this.txt_Contrasena = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(434, 400);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(98, 38);
            this.btn_Cerrar.TabIndex = 0;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(13, 13);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(944, 303);
            this.dgv1.TabIndex = 1;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(12, 400);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(98, 38);
            this.btn_Agregar.TabIndex = 2;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(123, 38);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(98, 38);
            this.btn_Modificar.TabIndex = 3;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(227, 38);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(98, 38);
            this.btn_Eliminar.TabIndex = 4;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(10, 355);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 22);
            this.txt_Nombre.TabIndex = 5;
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.Location = new System.Drawing.Point(116, 355);
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.Size = new System.Drawing.Size(100, 22);
            this.txt_Apellidos.TabIndex = 6;
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.Location = new System.Drawing.Point(222, 355);
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.Size = new System.Drawing.Size(100, 22);
            this.txt_Cedula.TabIndex = 7;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(328, 355);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(100, 22);
            this.txt_Usuario.TabIndex = 8;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(13, 332);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(58, 17);
            this.lbl_Nombre.TabIndex = 9;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Apellidos
            // 
            this.lbl_Apellidos.AutoSize = true;
            this.lbl_Apellidos.Location = new System.Drawing.Point(113, 332);
            this.lbl_Apellidos.Name = "lbl_Apellidos";
            this.lbl_Apellidos.Size = new System.Drawing.Size(65, 17);
            this.lbl_Apellidos.TabIndex = 10;
            this.lbl_Apellidos.Text = "Apellidos";
            // 
            // lbl_Cedula
            // 
            this.lbl_Cedula.AutoSize = true;
            this.lbl_Cedula.Location = new System.Drawing.Point(219, 332);
            this.lbl_Cedula.Name = "lbl_Cedula";
            this.lbl_Cedula.Size = new System.Drawing.Size(52, 17);
            this.lbl_Cedula.TabIndex = 11;
            this.lbl_Cedula.Text = "Cedula";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(325, 332);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(57, 17);
            this.lbl_Usuario.TabIndex = 12;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(16, 31);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(19, 17);
            this.lbl_Id.TabIndex = 13;
            this.lbl_Id.Text = "Id";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(17, 54);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(100, 22);
            this.txt_Id.TabIndex = 14;
            this.txt_Id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Id_KeyDown);
            // 
            // gb
            // 
            this.gb.Controls.Add(this.btn_Modificar);
            this.gb.Controls.Add(this.txt_Id);
            this.gb.Controls.Add(this.btn_Eliminar);
            this.gb.Controls.Add(this.lbl_Id);
            this.gb.Location = new System.Drawing.Point(626, 327);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(331, 111);
            this.gb.TabIndex = 15;
            this.gb.TabStop = false;
            this.gb.Text = "Criterios";
            // 
            // lbl_Contrasena
            // 
            this.lbl_Contrasena.AutoSize = true;
            this.lbl_Contrasena.Location = new System.Drawing.Point(431, 332);
            this.lbl_Contrasena.Name = "lbl_Contrasena";
            this.lbl_Contrasena.Size = new System.Drawing.Size(81, 17);
            this.lbl_Contrasena.TabIndex = 16;
            this.lbl_Contrasena.Text = "Contraseña";
            // 
            // txt_Contrasena
            // 
            this.txt_Contrasena.Location = new System.Drawing.Point(434, 355);
            this.txt_Contrasena.Name = "txt_Contrasena";
            this.txt_Contrasena.Size = new System.Drawing.Size(100, 22);
            this.txt_Contrasena.TabIndex = 17;
            this.txt_Contrasena.UseSystemPasswordChar = true;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 456);
            this.Controls.Add(this.txt_Contrasena);
            this.Controls.Add(this.lbl_Contrasena);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.lbl_Cedula);
            this.Controls.Add(this.lbl_Apellidos);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.txt_Cedula);
            this.Controls.Add(this.txt_Apellidos);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btn_Cerrar);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellidos;
        private System.Windows.Forms.TextBox txt_Cedula;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Apellidos;
        private System.Windows.Forms.Label lbl_Cedula;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Label lbl_Contrasena;
        private System.Windows.Forms.TextBox txt_Contrasena;
    }
}