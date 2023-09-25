using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace pryRodriguezIE
{
    internal class clsAccesoBD
    {
        private readonly string filePath;
       
        public clsAccesoBD(string filePath)
        {
            this.filePath = filePath;
        }
        
        public List<string[]> LeerCsv()
        {
            List<string[]> registros = new List<string[]>(); //Crea una lista para guardar los datos

            try
            {
                // Abre el archivo CSV para lectura.
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string linea;
                    // Lee cada línea del archivo CSV y la divide en campos.
                    while ((linea = reader.ReadLine()) != null)
                    {
                        string[] campos = linea.Split(',');
                        registros.Add(campos); // Agrega los campos a la lista de registros.
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo CSV: {ex.Message}");
            }

            return registros; // Devuelve la lista de registros leídos.
        }

        public void EscribirCsv(List<string[]> registros)
        {
            try
            {
                // Abre el archivo CSV para escritura.
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string[] campos in registros)
                    {
                        // Convierte los campos de registro en una línea CSV y la escribe en el archivo.
                        string linea = string.Join(",", campos);
                        writer.WriteLine(linea);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al escribir en el archivo CSV: {ex.Message}");
            }
        }
        static void Main(string[] args)
        {
            string csvFilePath = "Lista de proveedores.csv"; 

            clsAccesoBD csvManager = new clsAccesoBD(csvFilePath);

            // Leer el archivo CSV existente
            var registros = csvManager.LeerCsv();

            // Mostrar los datos actuales
            MessageBox.Show("Datos actuales en el archivo CSV:");
            foreach (var record in registros)
            {
                MessageBox.Show(string.Join(", ", registros));
            }

            // Pedir al usuario que ingrese datos para modificar el archivo CSV
            MessageBox.Show("Ingrese nuevos datos (separados por comas):");
            string input = Console.ReadLine();
            string[] DatoNuevo = input.Split(';');

            // Aplicar las modificaciones
            registros.Add(DatoNuevo);

            // Escribir el archivo CSV actualizado
            csvManager.EscribirCsv(registros);

            MessageBox.Show("Datos actualizados en el archivo CSV:");
            foreach (var record in registros)
            {
                MessageBox.Show(string.Join(", ", registros));
            }
        }
        static void Main()
        {
            string filePath = "Lista de aseguradores.csv"; // Reemplaza con la ruta de tu archivo CSV

            // Llama al procedimiento para eliminar una línea
            EliminarLineaCSV(filePath, "Número a eliminar");

            MessageBox.Show("Proceso completado.");
        }

        static void EliminarLineaCSV(string filePath, string numeroAEliminar)
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
    }

}

