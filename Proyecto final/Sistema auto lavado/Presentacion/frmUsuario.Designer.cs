﻿namespace Presentacion
{
    partial class frmUsuario
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.lblestado = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkProveedor = new System.Windows.Forms.CheckBox();
            this.chkVenta = new System.Windows.Forms.CheckBox();
            this.chkProducto = new System.Windows.Forms.CheckBox();
            this.chkMantenimiento = new System.Windows.Forms.CheckBox();
            this.chkUsuario = new System.Windows.Forms.CheckBox();
            this.chkLavado = new System.Windows.Forms.CheckBox();
            this.chkEmpleado = new System.Windows.Forms.CheckBox();
            this.chkCompra = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1076, 29);
            this.panel2.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(778, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(494, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "USUARIO";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Location = new System.Drawing.Point(806, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(26, 30);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 2;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEmpleado);
            this.groupBox2.Controls.Add(this.btnEmpleado);
            this.groupBox2.Controls.Add(this.lblestado);
            this.groupBox2.Controls.Add(this.txtNombreUsuario);
            this.groupBox2.Controls.Add(this.cmbEstado);
            this.groupBox2.Controls.Add(this.lblNombreUsuario);
            this.groupBox2.Controls.Add(this.txtContraseña);
            this.groupBox2.Controls.Add(this.lblContraseña);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(62, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(947, 145);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del proveedor";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(99, 34);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(153, 22);
            this.txtEmpleado.TabIndex = 4;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Location = new System.Drawing.Point(18, 31);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnEmpleado.TabIndex = 12;
            this.btnEmpleado.Text = "Empleado";
            this.btnEmpleado.UseVisualStyleBackColor = true;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(412, 100);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(51, 14);
            this.lblestado.TabIndex = 14;
            this.lblestado.Text = "Estado";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(552, 34);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(154, 22);
            this.txtNombreUsuario.TabIndex = 5;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(552, 92);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(154, 22);
            this.cmbEstado.TabIndex = 13;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(412, 42);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(132, 14);
            this.lblNombreUsuario.TabIndex = 2;
            this.lblNombreUsuario.Text = "Nombre de usuario";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(101, 92);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(151, 22);
            this.txtContraseña.TabIndex = 6;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(13, 95);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(82, 14);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkProveedor);
            this.groupBox3.Controls.Add(this.chkVenta);
            this.groupBox3.Controls.Add(this.chkProducto);
            this.groupBox3.Controls.Add(this.chkMantenimiento);
            this.groupBox3.Controls.Add(this.chkUsuario);
            this.groupBox3.Controls.Add(this.chkLavado);
            this.groupBox3.Controls.Add(this.chkEmpleado);
            this.groupBox3.Controls.Add(this.chkCompra);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(62, 208);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(947, 80);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Permisos";
            // 
            // chkProveedor
            // 
            this.chkProveedor.AutoSize = true;
            this.chkProveedor.Location = new System.Drawing.Point(784, 37);
            this.chkProveedor.Name = "chkProveedor";
            this.chkProveedor.Size = new System.Drawing.Size(95, 18);
            this.chkProveedor.TabIndex = 17;
            this.chkProveedor.Text = "Proveedor";
            this.chkProveedor.UseVisualStyleBackColor = true;
            // 
            // chkVenta
            // 
            this.chkVenta.AutoSize = true;
            this.chkVenta.Location = new System.Drawing.Point(60, 37);
            this.chkVenta.Name = "chkVenta";
            this.chkVenta.Size = new System.Drawing.Size(64, 18);
            this.chkVenta.TabIndex = 10;
            this.chkVenta.Text = "Venta";
            this.chkVenta.UseVisualStyleBackColor = true;
            // 
            // chkProducto
            // 
            this.chkProducto.AutoSize = true;
            this.chkProducto.Location = new System.Drawing.Point(680, 37);
            this.chkProducto.Name = "chkProducto";
            this.chkProducto.Size = new System.Drawing.Size(85, 18);
            this.chkProducto.TabIndex = 16;
            this.chkProducto.Text = "Producto";
            this.chkProducto.UseVisualStyleBackColor = true;
            // 
            // chkMantenimiento
            // 
            this.chkMantenimiento.AutoSize = true;
            this.chkMantenimiento.Location = new System.Drawing.Point(138, 37);
            this.chkMantenimiento.Name = "chkMantenimiento";
            this.chkMantenimiento.Size = new System.Drawing.Size(123, 18);
            this.chkMantenimiento.TabIndex = 11;
            this.chkMantenimiento.Text = "Mantenimiento";
            this.chkMantenimiento.UseVisualStyleBackColor = true;
            // 
            // chkUsuario
            // 
            this.chkUsuario.AutoSize = true;
            this.chkUsuario.Location = new System.Drawing.Point(584, 37);
            this.chkUsuario.Name = "chkUsuario";
            this.chkUsuario.Size = new System.Drawing.Size(77, 18);
            this.chkUsuario.TabIndex = 15;
            this.chkUsuario.Text = "Usuario";
            this.chkUsuario.UseVisualStyleBackColor = true;
            // 
            // chkLavado
            // 
            this.chkLavado.AutoSize = true;
            this.chkLavado.Location = new System.Drawing.Point(267, 37);
            this.chkLavado.Name = "chkLavado";
            this.chkLavado.Size = new System.Drawing.Size(74, 18);
            this.chkLavado.TabIndex = 12;
            this.chkLavado.Text = "Lavado";
            this.chkLavado.UseVisualStyleBackColor = true;
            // 
            // chkEmpleado
            // 
            this.chkEmpleado.AutoSize = true;
            this.chkEmpleado.Location = new System.Drawing.Point(484, 37);
            this.chkEmpleado.Name = "chkEmpleado";
            this.chkEmpleado.Size = new System.Drawing.Size(90, 18);
            this.chkEmpleado.TabIndex = 14;
            this.chkEmpleado.Text = "Empleado";
            this.chkEmpleado.UseVisualStyleBackColor = true;
            // 
            // chkCompra
            // 
            this.chkCompra.AutoSize = true;
            this.chkCompra.Location = new System.Drawing.Point(366, 37);
            this.chkCompra.Name = "chkCompra";
            this.chkCompra.Size = new System.Drawing.Size(77, 18);
            this.chkCompra.TabIndex = 13;
            this.chkCompra.Text = "Compra";
            this.chkCompra.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(62, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 80);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funciones";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(177, 40);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(298, 40);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(419, 40);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(551, 40);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(25, 411);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(1039, 205);
            this.dgvUsuarios.TabIndex = 26;
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellDoubleClick);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 628);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkProveedor;
        private System.Windows.Forms.CheckBox chkVenta;
        private System.Windows.Forms.CheckBox chkProducto;
        private System.Windows.Forms.CheckBox chkMantenimiento;
        private System.Windows.Forms.CheckBox chkUsuario;
        private System.Windows.Forms.CheckBox chkLavado;
        private System.Windows.Forms.CheckBox chkEmpleado;
        private System.Windows.Forms.CheckBox chkCompra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
    }
}