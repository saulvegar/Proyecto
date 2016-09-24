namespace SistemaAlmacen
{
    partial class ActualizarArticulo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbUnidad = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.tbId_Grupo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbIdLocalizacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbUnidad);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.rbInactivo);
            this.groupBox1.Controls.Add(this.rbActivo);
            this.groupBox1.Controls.Add(this.tbId_Grupo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbCantidad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbIdLocalizacion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbDescripcion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actualice los siguientes datos:";
            // 
            // cbUnidad
            // 
            this.cbUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnidad.FormattingEnabled = true;
            this.cbUnidad.Items.AddRange(new object[] {
            "Pieza",
            "kg",
            "Litros",
            "m3"});
            this.cbUnidad.Location = new System.Drawing.Point(143, 157);
            this.cbUnidad.Name = "cbUnidad";
            this.cbUnidad.Size = new System.Drawing.Size(235, 26);
            this.cbUnidad.TabIndex = 28;
            this.cbUnidad.Text = "Seleccionar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(70, 224);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 18);
            this.label14.TabIndex = 27;
            this.label14.Text = "Estatus:";
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInactivo.Location = new System.Drawing.Point(281, 222);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(76, 22);
            this.rbInactivo.TabIndex = 26;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "Inactivo";
            this.rbInactivo.UseVisualStyleBackColor = true;
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActivo.Location = new System.Drawing.Point(157, 222);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(66, 22);
            this.rbActivo.TabIndex = 25;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            // 
            // tbId_Grupo
            // 
            this.tbId_Grupo.Enabled = false;
            this.tbId_Grupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId_Grupo.Location = new System.Drawing.Point(143, 36);
            this.tbId_Grupo.Name = "tbId_Grupo";
            this.tbId_Grupo.Size = new System.Drawing.Size(235, 24);
            this.tbId_Grupo.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Id Grupo:";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidad.Location = new System.Drawing.Point(143, 189);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(235, 24);
            this.tbCantidad.TabIndex = 10;
            this.tbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Unidad:";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcion.Location = new System.Drawing.Point(143, 126);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(235, 24);
            this.tbDescripcion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripcion:";
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(143, 96);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(235, 24);
            this.tbNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(67, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SistemaAlmacen.Properties.Resources.updateArticle;
            this.pictureBox2.Location = new System.Drawing.Point(431, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 255);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = global::SistemaAlmacen.Properties.Resources.update;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(222, 299);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(111, 40);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::SistemaAlmacen.Properties.Resources.cancelar1;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(339, 299);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 40);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // tbIdLocalizacion
            // 
            this.tbIdLocalizacion.Enabled = false;
            this.tbIdLocalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdLocalizacion.Location = new System.Drawing.Point(143, 66);
            this.tbIdLocalizacion.Name = "tbIdLocalizacion";
            this.tbIdLocalizacion.Size = new System.Drawing.Size(235, 24);
            this.tbIdLocalizacion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Id Localización:";
            // 
            // ActualizarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaAlmacen.Properties.Resources.fondoLogin;
            this.ClientSize = new System.Drawing.Size(714, 353);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ActualizarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar articulo";
            this.Load += new System.EventHandler(this.ActualizarArticulo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbId_Grupo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbUnidad;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbIdLocalizacion;
        private System.Windows.Forms.Label label4;
    }
}