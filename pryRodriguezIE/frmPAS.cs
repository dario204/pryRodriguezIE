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
    public partial class frmPas : Form
    {
        public frmPas()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void frmPas_Load(object sender, EventArgs e)
        {
            //traer todos los proveedores registrados
            dgvProveedores.Columns.Add("1", "Titulo");
            StreamReader lector = new StreamReader("Libro1.csv");
            string leerRenglon="";
            string[] seprarDatos;
            leerRenglon = lector.ReadLine();    //
            seprarDatos = leerRenglon.Split() ; //divide el renglon
            bool primeraFila = true;
            while (!lector.EndOfStream)
            {
                if (primeraFila == true)
                {
                    for (int indice = 0; indice < seprarDatos.Length; indice++)
                    {
                        dgvProveedores.Rows.Add(seprarDatos[indice], "titulos");
                    }

                   
                }
                else
                {
                    dgvProveedores.Rows.Add(seprarDatos);
                }
            }

            lector.Close();
        }
    }
}
