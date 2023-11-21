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
using System.Reflection;

namespace pryRodriguezIE
{
    public partial class frmNuevoUsuario : Form
    {
        // Se declara una lista de puntos para almacenar las coordenadas de la firma.
        private List<Point> Punto = new List<Point>();

        //Indica si se esta dibujando
        private bool Dibuja = false;
        clsLogs objBD = new clsLogs();
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
            
            string Usuario = txtUsuario.Text;
            string Contraseña = txtContraseña.Text;
            string rol = cboRol.Text;
            objBD.CargarUsuario(Usuario, Contraseña, rol, ObtenerFirma());
            MessageBox.Show("Registro exisitoso" ,"", MessageBoxButtons.OK);
            this.Hide();
            frmInicioSesion Inicio = new frmInicioSesion();
            Inicio.ShowDialog();



        }
        //private byte[] ConvertPictureBoxToBytes(PictureBox pictureBox)
        //{
          //  using (MemoryStream memoryStream = new MemoryStream())
           // {
                // Convierte la imagen en el PictureBox en un formato de imagen
             //   pictureBox.Image.Save(memoryStream, ImageFormat.Png);

                // Obtiene los bytes de la imagen
               // return memoryStream.ToArray();
            //}
        //}

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
        private byte[] ObtenerFirma()
        {   // Se crea un nuevo objeto Bitmap con las dimensiones del control pbFirma.
            Bitmap FirmaBitmap = new Bitmap(pbFirma.Width, pbFirma.Height);

            // Se utiliza un objeto Graphics para dibujar en la imagen signatureBitmap.
            using (Graphics Grafico = Graphics.FromImage(FirmaBitmap))
            {
                // Se limpia el fondo de la imagen con color blanco.
                Grafico.Clear(Color.White);

                // Se verifica si hay más de un punto en la colección Punto.
                if (Punto.Count > 1)
                {
                    using (Pen Lapiz = new Pen(Color.Black, 2))
                    {
                        Grafico.DrawCurve(Lapiz, Punto.ToArray());
                    }
                }
            }
            // Se utiliza un MemoryStream para almacenar la representación binaria de la firma en formato PNG.
            using (MemoryStream Memoria = new MemoryStream())
            {
                //Se guarda la imagen de la firma en el MemoryStream
                FirmaBitmap.Save(Memoria, System.Drawing.Imaging.ImageFormat.Png);
                //Devuelve la imagen en bytes
                return Memoria.ToArray();
            }
        }
        private void pbFirma_MouseMove(object sender, MouseEventArgs e)
        {
            //Verifica si se esta dibujando
            if (Dibuja)
            {
                Punto.Add(e.Location);
                pbFirma.Invalidate(); // Redibuja el PictureBox
            }
        }

        private void pbFirma_MouseDown(object sender, MouseEventArgs e)
        {
            Dibuja = true;
            Punto.Add(e.Location);
        }

        private void pbFirma_MouseUp(object sender, MouseEventArgs e)
        {
            Dibuja = false;
        }

        private void pbFirma_Paint(object sender, PaintEventArgs e)
        {
            if (Punto.Count > 1)
            {
                using (Pen Lapiz = new Pen(Color.Black, 2))
                {
                    e.Graphics.DrawCurve(Lapiz, Punto.ToArray());
                }
            }
        }
    }
}
