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
        clsProveedor proveedor = new clsProveedor("Listado de aseguradores.csv");
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPas_Load(object sender, EventArgs e)
        {
            proveedor.CargarGrilla(dgvProveedores, cboJurisdiccion, cboJuzgado, cboLiquidador);
        }

        private void dgvProveedores_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            string entidad = txtEntidad.Text;
            string apertura = dtpApertura.Value.ToShortDateString();
            string expediente = txtExpediente.Text;
            string juzgado = cboJuzgado.Text;
            string juris = cboJurisdiccion.Text;
            string liqui = cboLiquidador.Text;
            string direccion = txtDireccion.Text;


            try
            {
                proveedor.Modificar(numero, entidad, apertura, expediente, juzgado, juris, direccion, liqui);
                dgvProveedores.Rows.Clear();
                proveedor.CargarGrilla(dgvProveedores, cboJuzgado, cboJurisdiccion, cboLiquidador);
                btnAgregar.Enabled = false;
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "", MessageBoxButtons.OK);
            }
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

            try
            {
                proveedor.Registrar(Numero, Entidad, fechaApertura, Expediente, Juzgado, Jurisdiccion, Direccion, Liquidador);
                proveedor.CargarGrilla(dgvProveedores, cboJuzgado, cboJurisdiccion, cboLiquidador);
                btnAgregar.Enabled = false;
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "", MessageBoxButtons.OK);
            }
        }
        private void Limpiar()
        {
                txtDireccion.Text = "";
                txtEntidad.Text = "";
                txtExpediente.Text = "";
                txtNumero.Text = "";
                cboJuzgado.SelectedIndex = -1;
                cboJurisdiccion.SelectedIndex = -1;
                cboLiquidador.SelectedIndex = -1;
            dgvProveedores.Rows.Clear();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            proveedor.Main();
        }
    }
}
