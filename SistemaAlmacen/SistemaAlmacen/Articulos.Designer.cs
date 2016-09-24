namespace SistemaAlmacen
{
    partial class Articulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Articulos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.idArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGrupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cortemesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.almacenArticulos = new SistemaAlmacen.almacenArticulos();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeBajaArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.articuloTableAdapter = new SistemaAlmacen.almacenArticulosTableAdapters.ArticuloTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenArticulos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnAñadir);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.btnExportar);
            this.groupBox1.Controls.Add(this.dgvArticulos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Catálogo de artículos:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(667, 40);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 25);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(123, 29);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(37, 37);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.Tag = "";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(86, 29);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(37, 37);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Tag = "";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            this.btnEditar.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(49, 29);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(37, 37);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Tag = "Dar de baja articulo";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.MouseHover += new System.EventHandler(this.btnEliminar_MouseHover);
            // 
            // btnAñadir
            // 
            this.btnAñadir.FlatAppearance.BorderSize = 0;
            this.btnAñadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Image = ((System.Drawing.Image)(resources.GetObject("btnAñadir.Image")));
            this.btnAñadir.Location = new System.Drawing.Point(12, 29);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(37, 37);
            this.btnAñadir.TabIndex = 5;
            this.btnAñadir.Tag = "";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            this.btnAñadir.MouseHover += new System.EventHandler(this.btnAñadir_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(697, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(727, 41);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(199, 24);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.Location = new System.Drawing.Point(126, 29);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(37, 37);
            this.btnExportar.TabIndex = 2;
            this.btnExportar.Tag = "";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            this.btnExportar.MouseHover += new System.EventHandler(this.Exportar_MouseHover);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.AutoGenerateColumns = false;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArticuloDataGridViewTextBoxColumn,
            this.idGrupoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.unidadDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.estatusDataGridViewTextBoxColumn,
            this.cortemesDataGridViewTextBoxColumn});
            this.dgvArticulos.DataSource = this.articuloBindingSource;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 73);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvArticulos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(914, 198);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // idArticuloDataGridViewTextBoxColumn
            // 
            this.idArticuloDataGridViewTextBoxColumn.DataPropertyName = "Id_Articulo";
            this.idArticuloDataGridViewTextBoxColumn.HeaderText = "Id_Articulo";
            this.idArticuloDataGridViewTextBoxColumn.Name = "idArticuloDataGridViewTextBoxColumn";
            this.idArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idGrupoDataGridViewTextBoxColumn
            // 
            this.idGrupoDataGridViewTextBoxColumn.DataPropertyName = "Id_Grupo";
            this.idGrupoDataGridViewTextBoxColumn.HeaderText = "Id_Grupo";
            this.idGrupoDataGridViewTextBoxColumn.Name = "idGrupoDataGridViewTextBoxColumn";
            this.idGrupoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unidadDataGridViewTextBoxColumn
            // 
            this.unidadDataGridViewTextBoxColumn.DataPropertyName = "Unidad";
            this.unidadDataGridViewTextBoxColumn.HeaderText = "Unidad";
            this.unidadDataGridViewTextBoxColumn.Name = "unidadDataGridViewTextBoxColumn";
            this.unidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estatusDataGridViewTextBoxColumn
            // 
            this.estatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus";
            this.estatusDataGridViewTextBoxColumn.HeaderText = "Estatus";
            this.estatusDataGridViewTextBoxColumn.Name = "estatusDataGridViewTextBoxColumn";
            this.estatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cortemesDataGridViewTextBoxColumn
            // 
            this.cortemesDataGridViewTextBoxColumn.DataPropertyName = "Corte_mes";
            this.cortemesDataGridViewTextBoxColumn.HeaderText = "Corte_mes";
            this.cortemesDataGridViewTextBoxColumn.Name = "cortemesDataGridViewTextBoxColumn";
            this.cortemesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataMember = "Articulo";
            this.articuloBindingSource.DataSource = this.almacenArticulos;
            // 
            // almacenArticulos
            // 
            this.almacenArticulos.DataSetName = "almacenArticulos";
            this.almacenArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoArticuloToolStripMenuItem,
            this.darDeBajaArticuloToolStripMenuItem,
            this.actualizarArticuloToolStripMenuItem,
            this.imprimirToolStripMenuItem});
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.accionesToolStripMenuItem.Text = "Acciones";
            // 
            // nuevoArticuloToolStripMenuItem
            // 
            this.nuevoArticuloToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoArticuloToolStripMenuItem.Image")));
            this.nuevoArticuloToolStripMenuItem.Name = "nuevoArticuloToolStripMenuItem";
            this.nuevoArticuloToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.nuevoArticuloToolStripMenuItem.Text = "Nuevo articulo";
            this.nuevoArticuloToolStripMenuItem.Click += new System.EventHandler(this.nuevoArticuloToolStripMenuItem_Click);
            // 
            // darDeBajaArticuloToolStripMenuItem
            // 
            this.darDeBajaArticuloToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("darDeBajaArticuloToolStripMenuItem.Image")));
            this.darDeBajaArticuloToolStripMenuItem.Name = "darDeBajaArticuloToolStripMenuItem";
            this.darDeBajaArticuloToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.darDeBajaArticuloToolStripMenuItem.Text = "Dar de baja articulo";
            this.darDeBajaArticuloToolStripMenuItem.Click += new System.EventHandler(this.darDeBajaArticuloToolStripMenuItem_Click);
            // 
            // actualizarArticuloToolStripMenuItem
            // 
            this.actualizarArticuloToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("actualizarArticuloToolStripMenuItem.Image")));
            this.actualizarArticuloToolStripMenuItem.Name = "actualizarArticuloToolStripMenuItem";
            this.actualizarArticuloToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.actualizarArticuloToolStripMenuItem.Text = "Editar articulo";
            this.actualizarArticuloToolStripMenuItem.Click += new System.EventHandler(this.actualizarArticuloToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripMenuItem.Image")));
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // articuloTableAdapter
            // 
            this.articuloTableAdapter.ClearBeforeFill = true;
            // 
            // Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(976, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Articulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artículos";
            this.Load += new System.EventHandler(this.Artículos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenArticulos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeBajaArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnRefresh;
        private almacenArticulos almacenArticulos;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private almacenArticulosTableAdapters.ArticuloTableAdapter articuloTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGrupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cortemesDataGridViewTextBoxColumn;

    }
}