using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace pryRodriguezIE
{
    internal class clsProveedor
    {
        public void Registrar( Int32 Numero, string Entidad, DateTime Apertura, Int32 Expediente, string Juzgado, string jurisdiccion, string direccion, string liquidador)
        {
            string archivoProveedor = "Listado de aseguradore.csv";
            try
            {
                // Crear una lista para almacenar los IDs existentes en el archivo
                List<int> idExistente = new List<int>();
                using (StreamReader sr= new StreamReader(archivoProveedor))
                {
                    string readLine;
                    while ((readLine = sr.ReadLine()) != null)
                    {
                        string[] separador = readLine.Split(';');

                        // Verificar si se pueden convertir los elementos de la línea a los tipos adecuados
                        if (separador.Length >= 1 && int.TryParse(separador[0], out int IdExistentes))
                        {
                            // Agregar el ID a la lista de IDs existentes
                            idExistente.Add(IdExistentes);
                        }
                    }
                }
                // Verificar si el ID ya existe en la lista de IDs existentes
                if (!idExistente.Contains(Numero))
                {
                    string RegistroNuevo = $"{Numero};{Entidad};{Apertura};{Expediente};{Juzgado};{jurisdiccion};{direccion};{liquidador}";
                    using (StreamWriter sw = new StreamWriter(archivoProveedor, true))
                    {
                        sw.WriteLine(RegistroNuevo);
                    }
                }
                else
                {
                    MessageBox.Show("Este numero ya existe en el archivo" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        } 
        

    }
}
