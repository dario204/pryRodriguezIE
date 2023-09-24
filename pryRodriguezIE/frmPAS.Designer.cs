namespace pryRodriguezIE
{
    partial class frmPas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPas));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.mcrDatos = new System.Windows.Forms.GroupBox();
            this.lblJurisdiccion = new System.Windows.Forms.Label();
            this.cboJurisdiccion = new System.Windows.Forms.ComboBox();
            this.cboJuzgado = new System.Windows.Forms.ComboBox();
            this.cboLiquidador = new System.Windows.Forms.ComboBox();
            this.txtExpediente = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblLiquidador = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblJuzgado = new System.Windows.Forms.Label();
            this.lblExpediente = new System.Windows.Forms.Label();
            this.lblApertura = new System.Windows.Forms.Label();
            this.lblEntidad = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.dtpApertura = new System.Windows.Forms.DateTimePicker();
            this.mcrDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(156, 11);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(532, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registro de Proveedor de Seguro (PAS)";
            // 
            // mcrDatos
            // 
            this.mcrDatos.Controls.Add(this.dtpApertura);
            this.mcrDatos.Controls.Add(this.lblJurisdiccion);
            this.mcrDatos.Controls.Add(this.cboJurisdiccion);
            this.mcrDatos.Controls.Add(this.cboJuzgado);
            this.mcrDatos.Controls.Add(this.cboLiquidador);
            this.mcrDatos.Controls.Add(this.txtExpediente);
            this.mcrDatos.Controls.Add(this.txtDireccion);
            this.mcrDatos.Controls.Add(this.txtEntidad);
            this.mcrDatos.Controls.Add(this.txtNumero);
            this.mcrDatos.Controls.Add(this.lblLiquidador);
            this.mcrDatos.Controls.Add(this.lblDireccion);
            this.mcrDatos.Controls.Add(this.lblJuzgado);
            this.mcrDatos.Controls.Add(this.lblExpediente);
            this.mcrDatos.Controls.Add(this.lblApertura);
            this.mcrDatos.Controls.Add(this.lblEntidad);
            this.mcrDatos.Controls.Add(this.lblNumero);
            this.mcrDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcrDatos.Location = new System.Drawing.Point(16, 73);
            this.mcrDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mcrDatos.Name = "mcrDatos";
            this.mcrDatos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mcrDatos.Size = new System.Drawing.Size(696, 369);
            this.mcrDatos.TabIndex = 1;
            this.mcrDatos.TabStop = false;
            this.mcrDatos.Text = "Datos del Proveedor";
            // 
            // lblJurisdiccion
            // 
            this.lblJurisdiccion.AutoSize = true;
            this.lblJurisdiccion.Location = new System.Drawing.Point(20, 240);
            this.lblJurisdiccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJurisdiccion.Name = "lblJurisdiccion";
            this.lblJurisdiccion.Size = new System.Drawing.Size(128, 24);
            this.lblJurisdiccion.TabIndex = 20;
            this.lblJurisdiccion.Text = "Jurisdiccion:";
            // 
            // cboJurisdiccion
            // 
            this.cboJurisdiccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJurisdiccion.FormattingEnabled = true;
            this.cboJurisdiccion.Location = new System.Drawing.Point(205, 236);
            this.cboJurisdiccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboJurisdiccion.Name = "cboJurisdiccion";
            this.cboJurisdiccion.Size = new System.Drawing.Size(235, 32);
            this.cboJurisdiccion.TabIndex = 19;
            // 
            // cboJuzgado
            // 
            this.cboJuzgado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJuzgado.FormattingEnabled = true;
            this.cboJuzgado.Location = new System.Drawing.Point(205, 186);
            this.cboJuzgado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboJuzgado.Name = "cboJuzgado";
            this.cboJuzgado.Size = new System.Drawing.Size(235, 32);
            this.cboJuzgado.TabIndex = 18;
            this.cboJuzgado.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cboLiquidador
            // 
            this.cboLiquidador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLiquidador.FormattingEnabled = true;
            this.cboLiquidador.Location = new System.Drawing.Point(281, 326);
            this.cboLiquidador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboLiquidador.Name = "cboLiquidador";
            this.cboLiquidador.Size = new System.Drawing.Size(239, 32);
            this.cboLiquidador.TabIndex = 17;
            // 
            // txtExpediente
            // 
            this.txtExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpediente.Location = new System.Drawing.Point(205, 148);
            this.txtExpediente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtExpediente.Name = "txtExpediente";
            this.txtExpediente.Size = new System.Drawing.Size(153, 29);
            this.txtExpediente.TabIndex = 13;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(205, 278);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(371, 29);
            this.txtDireccion.TabIndex = 11;
            // 
            // txtEntidad
            // 
            this.txtEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntidad.Location = new System.Drawing.Point(205, 65);
            this.txtEntidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(371, 29);
            this.txtEntidad.TabIndex = 10;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(205, 26);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(145, 29);
            this.txtNumero.TabIndex = 9;
            // 
            // lblLiquidador
            // 
            this.lblLiquidador.AutoSize = true;
            this.lblLiquidador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiquidador.Location = new System.Drawing.Point(20, 326);
            this.lblLiquidador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLiquidador.Name = "lblLiquidador";
            this.lblLiquidador.Size = new System.Drawing.Size(236, 24);
            this.lblLiquidador.TabIndex = 8;
            this.lblLiquidador.Text = "Liquidador responsable:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDireccion.Location = new System.Drawing.Point(20, 278);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(105, 24);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblJuzgado
            // 
            this.lblJuzgado.AutoSize = true;
            this.lblJuzgado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuzgado.Location = new System.Drawing.Point(20, 196);
            this.lblJuzgado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJuzgado.Name = "lblJuzgado";
            this.lblJuzgado.Size = new System.Drawing.Size(163, 24);
            this.lblJuzgado.TabIndex = 6;
            this.lblJuzgado.Text = "Juzgado Jurisd.:";
            // 
            // lblExpediente
            // 
            this.lblExpediente.AutoSize = true;
            this.lblExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpediente.Location = new System.Drawing.Point(20, 156);
            this.lblExpediente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpediente.Name = "lblExpediente";
            this.lblExpediente.Size = new System.Drawing.Size(100, 24);
            this.lblExpediente.TabIndex = 5;
            this.lblExpediente.Text = "Nº Expe.:";
            // 
            // lblApertura
            // 
            this.lblApertura.AutoSize = true;
            this.lblApertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApertura.Location = new System.Drawing.Point(20, 111);
            this.lblApertura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApertura.Name = "lblApertura";
            this.lblApertura.Size = new System.Drawing.Size(96, 24);
            this.lblApertura.TabIndex = 4;
            this.lblApertura.Text = "Apertura:";
            // 
            // lblEntidad
            // 
            this.lblEntidad.AutoSize = true;
            this.lblEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntidad.Location = new System.Drawing.Point(20, 65);
            this.lblEntidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(87, 24);
            this.lblEntidad.TabIndex = 3;
            this.lblEntidad.Text = "Entidad:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(20, 30);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(91, 24);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Número:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(733, 117);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 43);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(733, 208);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(117, 43);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(733, 309);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 43);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(733, 399);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 43);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(16, 500);
            this.dgvProveedores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.RowHeadersWidth = 51;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(835, 260);
            this.dgvProveedores.TabIndex = 6;
            this.dgvProveedores.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProveedores_CellMouseDoubleClick);
            // 
            // dtpApertura
            // 
            this.dtpApertura.Location = new System.Drawing.Point(205, 111);
            this.dtpApertura.Name = "dtpApertura";
            this.dtpApertura.Size = new System.Drawing.Size(235, 29);
            this.dtpApertura.TabIndex = 21;
            // 
            // frmPas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(876, 812);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.mcrDatos);
            this.Controls.Add(this.lblTitulo);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Proveedor de Seguro (PAS)";
            this.Load += new System.EventHandler(this.frmPas_Load);
            this.mcrDatos.ResumeLayout(false);
            this.mcrDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox mcrDatos;
        private System.Windows.Forms.TextBox txtExpediente;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblLiquidador;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblJuzgado;
        private System.Windows.Forms.Label lblExpediente;
        private System.Windows.Forms.Label lblApertura;
        private System.Windows.Forms.Label lblEntidad;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ComboBox cboJuzgado;
        private System.Windows.Forms.ComboBox cboLiquidador;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Label lblJurisdiccion;
        private System.Windows.Forms.ComboBox cboJurisdiccion;
        private System.Windows.Forms.DateTimePicker dtpApertura;
    }
}