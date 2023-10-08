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
        private readonly string filePath;

        public clsProveedor(string filePath)
        {
            this.filePath = filePath;
        }
        public void Registrar(Int32 Numero, string Entidad, DateTime Apertura, Int32 Expediente, string Juzgado, string jurisdiccion, string direccion, string liquidador)
        {
            string archivoProveedor = "Listado de aseguradore.csv";
            try
            {
                // Crear una lista para almacenar los IDs existentes en el archivo
                List<int> idExistente = new List<int>();
                using (StreamReader sr = new StreamReader(archivoProveedor))
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

        public void Main()
        {
            string filePath = "Lista de aseguradores.csv"; // Reemplaza con la ruta de tu archivo CSV

             //Llama al procedimiento para eliminar una línea
            EliminarLineaCSV(filePath, "Número a eliminar");

            MessageBox.Show("Proceso completado.");
        }

        private void EliminarLineaCSV(string filePath, string numeroAEliminar)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("El archivo CSV no existe.");
                return;
            }

            if (string.IsNullOrEmpty(numeroAEliminar))
            {
                MessageBox.Show("Ingresa un número antes de eliminar.");
                return;
            }

            try
            {
                // Lee todas las líneas del archivo CSV
                string[] linea = File.ReadAllLines(filePath);

                // Encuentra la línea que contiene el número a eliminar
                var ActualizarLinea = linea.Where(line => !linea.Contains(numeroAEliminar)).ToList();

                // Escribe las líneas restantes en el archivo CSV (sin la línea a eliminar)
                File.WriteAllLines(filePath, ActualizarLinea);

                MessageBox.Show("Línea eliminada con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la línea: {ex.Message}");
            }
        }

        public void Modificar(int id, string entidad, string Apertura, string expendiente, string juzg, string juri, string direccion, string liquidador)
        {
            // Establece el nombre del archivo CSV que se va a modificar
            string archivoProveedor = "Listado de aseguradores.csv";

            try
            {
                // Crea una lista para almacenar las líneas modificadas y un indicador de primera línea
                List<string> lineas = new List<string>();
                bool primerLinea = true;

                // Abre el archivo CSV
                using (StreamReader lector = new StreamReader(archivoProveedor))
                {
                    string readLine;
                    // Lee cada línea del archivo CSV
                    while ((readLine = lector.ReadLine()) != null)
                    {
                        string[] separador = readLine.Split(';');

                        // Verifica si la línea contiene al menos un campo y si el primer campo se puede convertir a un entero.
                        if (separador.Length > 0 && int.TryParse(separador[0], out int existingID))
                        {
                            // Compara el ID de la línea actual con el ID proporcionado como argumento al método
                            if (existingID == id)
                            {
                                // Crea una nueva línea con los valores actualizados y la agrega a la lista 
                                string nuevaLinea = $"{id};{entidad};{Apertura};{expendiente};{juzg};{juri};{direccion};{liquidador}";
                                lineas.Add(nuevaLinea);
                            }
                            else
                            {
                                // Si el ID no coincide, agrega la línea original a la lista de líneas sin cambios.
                                lineas.Add(readLine);
                            }
                        }
                    }
                }

                // Escribe las líneas en el archivo original
                using (StreamWriter sw = new StreamWriter(archivoProveedor, false))
                {
                    foreach (string linea in lineas)
                    {
                        // Agrega la primera línea con los títulos de las columnas
                        if (primerLinea)
                        {
                            sw.WriteLine(linea);
                            primerLinea = false;
                        }
                        else
                        {
                            sw.WriteLine(linea);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el archivo: " + ex.Message + MessageBoxButtons.OK +MessageBoxIcon.Error);
            }
        }
        public void CargarGrilla(DataGridView grilla, ComboBox cboJuzgado, ComboBox cboJurisdiccion, ComboBox cboLiquidador)
        {
            string archivoProveedor = "Listado de aseguradores.csv";
            grilla.Rows.Clear();

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
                            grilla.Columns.Add(columna, columna);
                        }

                        HashSet<string> jurisdiccionesUnicas = new HashSet<string>();
                        HashSet<string> responsablesUnicos = new HashSet<string>();
                        HashSet<string> juzgadosUnicos = new HashSet<string>();



                        while (!sr.EndOfStream)
                        {
                            readLine = sr.ReadLine();
                            separador = readLine.Split(';');
                            grilla.Rows.Add(separador);

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
    }
}
