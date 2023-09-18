using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryRodriguezIE
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (lblUsuario.Text=="")
            {
                listadoReportes.Visible = false;
            }
            Hora.Text = DateTime.Now.ToLongTimeString();

            temporizador.Interval = 1000;
            temporizador.Start();
        }

        private void Hora_Click(object sender, EventArgs e)
        {

        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            DateTime fechayHoraActual = DateTime.Now;

            Hora.Text=fechayHoraActual.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void activosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            StreamWriter sw = new StreamWriter("logGeneral", true);
            sw.WriteLine(lblUsuario.Text + "-Fecha:" + DateTime.Now + "- Accede:");
            sw.Close();
            frmCargaProveedores proveedores = new frmCargaProveedores();
            proveedores.ShowDialog();
        }

        private void registroDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPas pas = new frmPas();
            pas.ShowDialog();
        }
    }
}
