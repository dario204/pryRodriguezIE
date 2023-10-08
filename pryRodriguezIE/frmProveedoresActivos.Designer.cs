namespace pryRodriguezIE
{
    partial class frmProveedoresActivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedoresActivos));
            this.tvArchivos = new System.Windows.Forms.TreeView();
            this.rtbContenido = new System.Windows.Forms.RichTextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tvArchivos
            // 
            this.tvArchivos.Location = new System.Drawing.Point(137, 73);
            this.tvArchivos.Margin = new System.Windows.Forms.Padding(4);
            this.tvArchivos.Name = "tvArchivos";
            this.tvArchivos.Size = new System.Drawing.Size(369, 234);
            this.tvArchivos.TabIndex = 0;
            this.tvArchivos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // rtbContenido
            // 
            this.rtbContenido.Location = new System.Drawing.Point(137, 342);
            this.rtbContenido.Name = "rtbContenido";
            this.rtbContenido.Size = new System.Drawing.Size(369, 215);
            this.rtbContenido.TabIndex = 1;
            this.rtbContenido.Text = "";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(130, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(376, 39);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Seleccione un Archivo";
            // 
            // frmProveedoresActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(644, 569);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.rtbContenido);
            this.Controls.Add(this.tvArchivos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProveedoresActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de Proveedores";
            this.Load += new System.EventHandler(this.frmCargaProveedorescs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvArchivos;
        private System.Windows.Forms.RichTextBox rtbContenido;
        private System.Windows.Forms.Label lblTitulo;
    }
}