namespace SistemaAlmacen
{
    partial class Facturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNueva = new System.Windows.Forms.Button();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.almacenFacturas = new SistemaAlmacen.almacenFacturas();
            this.facturaConArticulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturaConArticulosTableAdapter = new SistemaAlmacen.almacenFacturasTableAdapters.FacturaConArticulosTableAdapter();
            this.idFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaÚltimaEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaConArticulosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnNueva);
            this.groupBox1.Controls.Add(this.dgvFacturas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1149, 433);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de facturas:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(886, 38);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 25);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(916, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(946, 38);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(189, 24);
            this.txtBuscar.TabIndex = 5;
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(140, 25);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(37, 37);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(97, 25);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(37, 37);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(56, 25);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(37, 37);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNueva
            // 
            this.btnNueva.FlatAppearance.BorderSize = 0;
            this.btnNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNueva.Image = ((System.Drawing.Image)(resources.GetObject("btnNueva.Image")));
            this.btnNueva.Location = new System.Drawing.Point(15, 25);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(37, 37);
            this.btnNueva.TabIndex = 1;
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            this.btnNueva.MouseHover += new System.EventHandler(this.btnNueva_MouseHover);
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.AutoGenerateColumns = false;
            this.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFacturaDataGridViewTextBoxColumn,
            this.idArticuloDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioUnitarioDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.fechaEntradaDataGridViewTextBoxColumn,
            this.fechaÚltimaEntradaDataGridViewTextBoxColumn,
            this.conceptoDataGridViewTextBoxColumn,
            this.importeDataGridViewTextBoxColumn,
            this.articuloDataGridViewTextBoxColumn});
            this.dgvFacturas.DataSource = this.facturaConArticulosBindingSource;
            this.dgvFacturas.Location = new System.Drawing.Point(15, 68);
            this.dgvFacturas.Name = "dgvFacturas";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFacturas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturas.Size = new System.Drawing.Size(1120, 345);
            this.dgvFacturas.TabIndex = 0;
            this.dgvFacturas.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // almacenFacturas
            // 
            this.almacenFacturas.DataSetName = "almacenFacturas";
            this.almacenFacturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturaConArticulosBindingSource
            // 
            this.facturaConArticulosBindingSource.DataMember = "FacturaConArticulos";
            this.facturaConArticulosBindingSource.DataSource = this.almacenFacturas;
            // 
            // facturaConArticulosTableAdapter
            // 
            this.facturaConArticulosTableAdapter.ClearBeforeFill = true;
            // 
            // idFacturaDataGridViewTextBoxColumn
            // 
            this.idFacturaDataGridViewTextBoxColumn.DataPropertyName = "Id Factura";
            this.idFacturaDataGridViewTextBoxColumn.HeaderText = "Id Factura";
            this.idFacturaDataGridViewTextBoxColumn.Name = "idFacturaDataGridViewTextBoxColumn";
            // 
            // idArticuloDataGridViewTextBoxColumn
            // 
            this.idArticuloDataGridViewTextBoxColumn.DataPropertyName = "Id Articulo";
            this.idArticuloDataGridViewTextBoxColumn.HeaderText = "Id Articulo";
            this.idArticuloDataGridViewTextBoxColumn.Name = "idArticuloDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // precioUnitarioDataGridViewTextBoxColumn
            // 
            this.precioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "Precio unitario";
            this.precioUnitarioDataGridViewTextBoxColumn.HeaderText = "Precio unitario";
            this.precioUnitarioDataGridViewTextBoxColumn.Name = "precioUnitarioDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // fechaEntradaDataGridViewTextBoxColumn
            // 
            this.fechaEntradaDataGridViewTextBoxColumn.DataPropertyName = "Fecha entrada";
            this.fechaEntradaDataGridViewTextBoxColumn.HeaderText = "Fecha entrada";
            this.fechaEntradaDataGridViewTextBoxColumn.Name = "fechaEntradaDataGridViewTextBoxColumn";
            // 
            // fechaÚltimaEntradaDataGridViewTextBoxColumn
            // 
            this.fechaÚltimaEntradaDataGridViewTextBoxColumn.DataPropertyName = "Fecha última entrada";
            this.fechaÚltimaEntradaDataGridViewTextBoxColumn.HeaderText = "Fecha última entrada";
            this.fechaÚltimaEntradaDataGridViewTextBoxColumn.Name = "fechaÚltimaEntradaDataGridViewTextBoxColumn";
            // 
            // conceptoDataGridViewTextBoxColumn
            // 
            this.conceptoDataGridViewTextBoxColumn.DataPropertyName = "Concepto";
            this.conceptoDataGridViewTextBoxColumn.HeaderText = "Concepto";
            this.conceptoDataGridViewTextBoxColumn.Name = "conceptoDataGridViewTextBoxColumn";
            // 
            // importeDataGridViewTextBoxColumn
            // 
            this.importeDataGridViewTextBoxColumn.DataPropertyName = "Importe";
            this.importeDataGridViewTextBoxColumn.HeaderText = "Importe";
            this.importeDataGridViewTextBoxColumn.Name = "importeDataGridViewTextBoxColumn";
            // 
            // articuloDataGridViewTextBoxColumn
            // 
            this.articuloDataGridViewTextBoxColumn.DataPropertyName = "Articulo";
            this.articuloDataGridViewTextBoxColumn.HeaderText = "Articulo";
            this.articuloDataGridViewTextBoxColumn.Name = "articuloDataGridViewTextBoxColumn";
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 468);
            this.Controls.Add(this.groupBox1);
            this.Name = "Facturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.Facturas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaConArticulosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnRefresh;
        private almacenFacturas almacenFacturas;
        private System.Windows.Forms.BindingSource facturaConArticulosBindingSource;
        private almacenFacturasTableAdapters.FacturaConArticulosTableAdapter facturaConArticulosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaÚltimaEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conceptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articuloDataGridViewTextBoxColumn;
    }
}