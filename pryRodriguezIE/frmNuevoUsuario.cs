using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Data.OleDb;

namespace pryRodriguezIE
{
    public partial class frmNuevoUsuario : Form
    {
        public frmNuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            // Convierte la firma dibujada en el PictureBox en un arreglo de bytes
            //byte[] signatureBytes = ConvertPictureBoxToBytes(pbFirma);

            // Cadena de conexión a la base de datos Access
            //string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:BrokerSeguros.accdb";

            //using (OleDbConnection connection = new OleDbConnection(connectionString))
            //{
            //  connection.Open();

            // Consulta SQL para insertar la firma en la base de datos
            // string insertQuery = "INSERT INTO TuTabla (CampoFirma) VALUES (?)";

            //using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
            //{
            // Agrega el parámetro para la firma
            //   command.Parameters.Add("CampoFirma", OleDbType.LongVarBinary, signatureBytes.Length).Value = signatureBytes;

            //  int rowsAffected = command.ExecuteNonQuery();

            // if (rowsAffected > 0)
            //{
            //   MessageBox.Show("Firma registrada con éxito.");
            //}
            //else
            //{
            //    MessageBox.Show("Error al registrar la firma.");
            //}
            //}
            //}
           
            
            
                string NuevoUsuario = txtUsuario.Text;
                string NuevaContraseña = txtContraseña.Text;
                string Rol = cboRol.Text;

                clsLogs objUsuario = new clsLogs();
            objUsuario.RegistrarLogs(NuevoUsuario, NuevaContraseña, Rol);
                frmInicioSesion Inicio = new frmInicioSesion();
                Inicio.ShowDialog();
                this.Hide();
            


        }
        private byte[] ConvertPictureBoxToBytes(PictureBox pictureBox)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                // Convierte la imagen en el PictureBox en un formato de imagen
                pictureBox.Image.Save(memoryStream, ImageFormat.Png);

                // Obtiene los bytes de la imagen
                return memoryStream.ToArray();
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                cboRol.Enabled = true;
            }
            else
            {
                cboRol.Enabled = false;
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text != "")
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }

        private void cboRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRol.SelectedIndex != -1)
            {
                txtContraseña.Enabled = true;
            }
            else
            {
                txtContraseña.Enabled = false;
            }
        }

        private void frmNuevoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmInicioSesion frm = new frmInicioSesion();
            frm.ShowDialog();
        }
    }
}
