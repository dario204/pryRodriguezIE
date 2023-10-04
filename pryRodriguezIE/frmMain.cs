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
            string Ruta = "logsMain.txt";
            using (StreamReader reader = new StreamReader(Ruta))
            {

                string linea;
                while ((linea = reader.ReadLine()) != null)
                {

                    string[] partes = linea.Split('-');
                    if (partes.Length == 2)
                    {
                        string usuario = partes[0].Trim();
                        string horaIngreso = partes[1].Trim();

                        lblUsuario.Text = usuario;
                    }
                }
            }
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
            frmProveedoresActivos f = new frmProveedoresActivos();
            f.ShowDialog();

            string user = lblUsuario.Text;
            string Hora = Convert.ToString(DateTime.Now);
            string Ruta = "logsMenu.txt";
            string menu = menuActivos.Text;

            using (StreamWriter writer = new StreamWriter(Ruta, true))
            {
                writer.WriteLine($"{user} - Hora de ingreso: {Hora} - Ingreso: {menu}");
            }

        }

        private void registroDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPas P = new frmPas();
            P.ShowDialog();

            string user = lblUsuario.Text;
            string Hora = Convert.ToString(DateTime.Now);
            string Ruta = "logsMenu.txt";
            string menu = RegistroProveedores.Text;

            using (StreamWriter writer = new StreamWriter(Ruta, true))
            {
                writer.WriteLine($"{user} - Hora de ingreso: {Hora} - Ingreso: {menu}");
            }
        }
    }
}
