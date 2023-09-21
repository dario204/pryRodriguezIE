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
       
        public CsvFileManager(string filePath)
        {
            this.filePath = filePath;
        }
        
        public List<string[]> ReadCsv()
        {
            List<string[]> records = new List<string[]>();

            try
            {
                // Abre el archivo CSV para lectura.
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    // Lee cada línea del archivo CSV y la divide en campos.
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] fields = line.Split(',');
                        records.Add(fields); // Agrega los campos a la lista de registros.
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo CSV: {ex.Message}");
            }

            return records; // Devuelve la lista de registros leídos.
        }

        public void WriteCsv(List<string[]> records)
        {
            try
            {
                // Abre el archivo CSV para escritura.
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string[] fields in records)
                    {
                        // Convierte los campos de registro en una línea CSV y la escribe en el archivo.
                        string line = string.Join(",", fields);
                        writer.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al escribir en el archivo CSV: {ex.Message}");
            }
        }
        static void Main(string[] args)
        {
            string csvFilePath = "Lista de proveedores.csv"; // Cambia esto a la ruta de tu archivo CSV

            CsvFileManager csvManager = new CsvFileManager(csvFilePath);

            // Leer el archivo CSV existente
            var records = csvManager.ReadCsv();

            // Mostrar los datos actuales
            Console.WriteLine("Datos actuales en el archivo CSV:");
            foreach (var record in records)
            {
                Console.WriteLine(string.Join(", ", record));
            }

            // Pedir al usuario que ingrese datos para modificar el archivo CSV
            Console.WriteLine("Ingrese nuevos datos (separados por comas):");
            string input = Console.ReadLine();
            string[] newData = input.Split(',');

            // Aplicar las modificaciones
            records.Add(newData);

            // Escribir el archivo CSV actualizado
            csvManager.WriteCsv(records);

            Console.WriteLine("Datos actualizados en el archivo CSV:");
            foreach (var record in records)
            {
                Console.WriteLine(string.Join(", ", record));
            }
        }
    }
}
