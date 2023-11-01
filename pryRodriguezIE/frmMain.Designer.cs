namespace pryRodriguezIE
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Gestion = new System.Windows.Forms.ToolStripMenuItem();
            this.Proveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.Proveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuActivos = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Gestion,
            this.listadoReportes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(947, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Gestion
            // 
            this.Gestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Proveedor});
            this.Gestion.Name = "Gestion";
            this.Gestion.Size = new System.Drawing.Size(73, 24);
            this.Gestion.Text = "Gestion";
            // 
            // Proveedor
            // 
            this.Proveedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegistroProveedores});
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Size = new System.Drawing.Size(224, 26);
            this.Proveedor.Text = "Proveedor";
            // 
            // RegistroProveedores
            // 
            this.RegistroProveedores.Name = "RegistroProveedores";
            this.RegistroProveedores.Size = new System.Drawing.Size(254, 26);
            this.RegistroProveedores.Text = "Registro de Proveedores";
            this.RegistroProveedores.Click += new System.EventHandler(this.registroDeProveedoresToolStripMenuItem_Click);
            // 
            // listadoReportes
            // 
            this.listadoReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Proveedores});
            this.listadoReportes.Name = "listadoReportes";
            this.listadoReportes.Size = new System.Drawing.Size(136, 24);
            this.listadoReportes.Text = "Listado/Reportes";
            // 
            // Proveedores
            // 
            this.Proveedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuActivos});
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Size = new System.Drawing.Size(174, 26);
            this.Proveedores.Text = "Proveedores";
            // 
            // menuActivos
            // 
            this.menuActivos.Name = "menuActivos";
            this.menuActivos.Size = new System.Drawing.Size(140, 26);
            this.menuActivos.Text = "Activos";
            this.menuActivos.Click += new System.EventHandler(this.activosToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Hora,
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(19, 0, 1, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(947, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // Hora
            // 
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(42, 20);
            this.Hora.Text = "Hora";
            this.Hora.Click += new System.EventHandler(this.Hora_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 20);
            this.lblUsuario.Text = "Usuario";
            // 
            // temporizador
            // 
            this.temporizador.Enabled = true;
            this.temporizador.Interval = 1000;
            this.temporizador.Tick += new System.EventHandler(this.temporizador_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryRodriguezIE.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 510);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistemas de Gestion de Ventas de Servicios de Seguro";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Gestion;
        private System.Windows.Forms.ToolStripMenuItem listadoReportes;
        private System.Windows.Forms.ToolStripMenuItem Proveedores;
        private System.Windows.Forms.ToolStripMenuItem menuActivos;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem Proveedor;
        private System.Windows.Forms.ToolStripMenuItem RegistroProveedores;
        private System.Windows.Forms.Timer temporizador;
        private System.Windows.Forms.ToolStripStatusLabel Hora;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
    }
}

