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
        clsProveedor Proveedor = new clsProveedor();
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void frmPas_Load(object sender, EventArgs e)
        {
            
        }
        private void cargarGrilla()
        {
            string archivoProveedor = "Listado de aseguradores.csv";
            dgvProveedores.Rows.Clear();

            try
            {
                using (StreamReader sr = new StreamReader(archivoProveedor))
                {
                    string readLine = sr.ReadLine();
                    if (readLine != null)
                    {
                        string[] separador = readLine.Split(';');

                        foreach (string columna in separador)
                        {
                            dgvProveedores.Columns.Add(columna, columna);
                        }

                        HashSet<string> jurisdiccionesUnicas = new HashSet<string>();
                        HashSet<string> responsablesUnicos = new HashSet<string>();
                        HashSet<string> juzgadosUnicos = new HashSet<string>();



                        while (!sr.EndOfStream)
                        {
                            readLine = sr.ReadLine();
                            separador = readLine.Split(';');
                            dgvProveedores.Rows.Add(separador);

                            juzgadosUnicos.Add(separador[4]);
                            jurisdiccionesUnicas.Add(separador[5]);
                            responsablesUnicos.Add(separador[7]);

                        }

                        //Carga de jurisdiccions unicas sin repetir
                        foreach (string jurisdiccion in jurisdiccionesUnicas)
                        {
                            cboJurisdiccion.Items.Add(jurisdiccion);
                        }

                        foreach (string responsable in responsablesUnicos)
                        {
                            cboLiquidador.Items.Add(responsable);
                        }

                        foreach (string juzgado in juzgadosUnicos)
                        {
                            cboJuzgado.Items.Add(juzgado);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvProveedores_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int Numero = int.Parse(txtNumero.Text);
            string Entidad = txtEntidad.Text;
            int Expediente = int.Parse(txtExpediente.Text);
            string Juzgado = cboJuzgado.Text;
            string Jurisdiccion = cboJurisdiccion.Text;
            string Direccion = txtDireccion.Text;
            string Liquidador = cboLiquidador.Text;
            DateTime fechaApertura = dtpApertura.Value;

            clsProveedor registroProveedor = new clsProveedor();
            registroProveedor.Registrar(Numero, Entidad, fechaApertura, Expediente, Juzgado, Jurisdiccion, Direccion, Liquidador);
            cargarGrilla();
        }
    }
}
