namespace Presentacion
{
    partial class frmreporteventas
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reporteventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Presentacion.DataSet1();
            this.getdetalleventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteventaTableAdapter = new Presentacion.DataSet1TableAdapters.reporteventaTableAdapter();
            this.getdetalleventaTableAdapter = new Presentacion.DataSet1TableAdapters.getdetalleventaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getdetalleventaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteventaBindingSource
            // 
            this.reporteventaBindingSource.DataMember = "reporteventa";
            this.reporteventaBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getdetalleventaBindingSource
            // 
            this.getdetalleventaBindingSource.DataMember = "getdetalleventa";
            this.getdetalleventaBindingSource.DataSource = this.DataSet1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporteventaBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.getdetalleventaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(537, 566);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // reporteventaTableAdapter
            // 
            this.reporteventaTableAdapter.ClearBeforeFill = true;
            // 
            // getdetalleventaTableAdapter
            // 
            this.getdetalleventaTableAdapter.ClearBeforeFill = true;
            // 
            // frmreporteventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 566);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmreporteventas";
            this.Text = "frmreporteventas";
            this.Load += new System.EventHandler(this.frmreporteventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getdetalleventaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteventaBindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource getdetalleventaBindingSource;
        private DataSet1TableAdapters.reporteventaTableAdapter reporteventaTableAdapter;
        private DataSet1TableAdapters.getdetalleventaTableAdapter getdetalleventaTableAdapter;
    }
}