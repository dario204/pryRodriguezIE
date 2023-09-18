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
            string ArchivoProveedor = "Listado de aseguradores.csv";
            try
            {
                using (StreamReader sr = new StreamReader(ArchivoProveedor))
                {
                    string readLine = sr.ReadLine();
                    if (readLine != null)
                    {
                        string[] separador = readLine.Split(';');

                        foreach (string columna in separador)
                        {
                            dgvProveedores.Columns.Add(columna, columna);
                        }
                        HashSet<string> juridicciones = new HashSet<string>();
                        HashSet<string> responsablesUnicos = new HashSet<string>();

                        while (!sr.EndOfStream)
                        {
                            readLine = sr.ReadLine();
                            separador = readLine.Split(';');
                            dgvProveedores.Rows.Add(separador);
                            juridicciones.Add(separador[3]);
                            responsablesUnicos.Add(separador[7]);
                        }

                        //Carga de jurisdicciones unicas sin repetir
                        foreach (string jurisdiccion in juridicciones)
                        {
                            cboJurisdiccion.Items.Add(jurisdiccion);
                        }

                        foreach (string responsable in responsablesUnicos)
                        {
                            cboLiquidador.Items.Add(responsable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex + MessageBoxButtons.OK +MessageBoxIcon.Warning);
                
            }
        }
    }
}
