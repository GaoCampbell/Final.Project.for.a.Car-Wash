namespace Presentacion
{
    partial class frmLavado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtgrupo = new System.Windows.Forms.TextBox();
            this.btnidgrupo = new System.Windows.Forms.Button();
            this.txtlavado = new System.Windows.Forms.TextBox();
            this.btnbuscaridLavadoV = new System.Windows.Forms.Button();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.lblplaca = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.dgvLavado = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLavado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 29);
            this.panel2.TabIndex = 21;
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
            this.label8.Location = new System.Drawing.Point(357, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "LAVADO";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Image = global::Presentacion.Properties.Resources.X;
            this.pictureBox8.Location = new System.Drawing.Point(806, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(26, 30);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 2;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblusuario);
            this.groupBox1.Controls.Add(this.txttotal);
            this.groupBox1.Controls.Add(this.lbltotal);
            this.groupBox1.Controls.Add(this.txtgrupo);
            this.groupBox1.Controls.Add(this.btnidgrupo);
            this.groupBox1.Controls.Add(this.txtlavado);
            this.groupBox1.Controls.Add(this.btnbuscaridLavadoV);
            this.groupBox1.Controls.Add(this.txtplaca);
            this.groupBox1.Controls.Add(this.lblplaca);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 162);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del proveedor";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(27, 135);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(58, 14);
            this.lblusuario.TabIndex = 10;
            this.lblusuario.Text = "Usuario";
            this.lblusuario.Click += new System.EventHandler(this.lblusuario_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(455, 81);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(136, 22);
            this.txttotal.TabIndex = 9;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(381, 90);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(40, 14);
            this.lbltotal.TabIndex = 8;
            this.lbltotal.Text = "Total";
            // 
            // txtgrupo
            // 
            this.txtgrupo.Location = new System.Drawing.Point(166, 81);
            this.txtgrupo.Name = "txtgrupo";
            this.txtgrupo.Size = new System.Drawing.Size(191, 22);
            this.txtgrupo.TabIndex = 7;
            // 
            // btnidgrupo
            // 
            this.btnidgrupo.Location = new System.Drawing.Point(30, 82);
            this.btnidgrupo.Name = "btnidgrupo";
            this.btnidgrupo.Size = new System.Drawing.Size(126, 23);
            this.btnidgrupo.TabIndex = 6;
            this.btnidgrupo.Text = "Asignar grupo";
            this.btnidgrupo.UseVisualStyleBackColor = true;
            this.btnidgrupo.Click += new System.EventHandler(this.btnidgrupo_Click);
            // 
            // txtlavado
            // 
            this.txtlavado.Location = new System.Drawing.Point(698, 25);
            this.txtlavado.Name = "txtlavado";
            this.txtlavado.Size = new System.Drawing.Size(102, 22);
            this.txtlavado.TabIndex = 5;
            // 
            // btnbuscaridLavadoV
            // 
            this.btnbuscaridLavadoV.Location = new System.Drawing.Point(603, 24);
            this.btnbuscaridLavadoV.Name = "btnbuscaridLavadoV";
            this.btnbuscaridLavadoV.Size = new System.Drawing.Size(75, 23);
            this.btnbuscaridLavadoV.TabIndex = 4;
            this.btnbuscaridLavadoV.Text = "Lavado vehiculo";
            this.btnbuscaridLavadoV.UseVisualStyleBackColor = true;
            this.btnbuscaridLavadoV.Click += new System.EventHandler(this.btnbuscaridLavadoV_Click);
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(455, 27);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(136, 22);
            this.txtplaca.TabIndex = 3;
            // 
            // lblplaca
            // 
            this.lblplaca.AutoSize = true;
            this.lblplaca.Location = new System.Drawing.Point(381, 35);
            this.lblplaca.Name = "lblplaca";
            this.lblplaca.Size = new System.Drawing.Size(43, 14);
            this.lblplaca.TabIndex = 2;
            this.lblplaca.Text = "Placa";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(166, 29);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 22);
            this.dtpFecha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnguardar);
            this.groupBox2.Controls.Add(this.btncancelar);
            this.groupBox2.Controls.Add(this.btnmodificar);
            this.groupBox2.Controls.Add(this.btnnuevo);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(806, 80);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funciones";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(409, 31);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(95, 28);
            this.btnguardar.TabIndex = 9;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(518, 31);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(95, 28);
            this.btncancelar.TabIndex = 8;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(301, 31);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(95, 28);
            this.btnmodificar.TabIndex = 6;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(191, 31);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(95, 28);
            this.btnnuevo.TabIndex = 5;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // dgvLavado
            // 
            this.dgvLavado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLavado.Location = new System.Drawing.Point(12, 346);
            this.dgvLavado.Name = "dgvLavado";
            this.dgvLavado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLavado.Size = new System.Drawing.Size(806, 204);
            this.dgvLavado.TabIndex = 25;
            this.dgvLavado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLavado_CellDoubleClick);
            // 
            // frmLavado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 577);
            this.Controls.Add(this.dgvLavado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLavado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLavado";
            this.Load += new System.EventHandler(this.frmLavado_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLavado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.DataGridView dgvLavado;
        private System.Windows.Forms.TextBox txtlavado;
        private System.Windows.Forms.Button btnbuscaridLavadoV;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Label lblplaca;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtgrupo;
        private System.Windows.Forms.Button btnidgrupo;
    }
}