using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryRodriguezIE
{
    internal class clsLogs
    {
        string rutaArchivo;
        string CadenaConexion;

        OleDbConnection Conexion;
        OleDbCommand Comando;
        OleDbDataReader Lector;

        public string estadoConexion;

        public clsLogs()
        {
            rutaArchivo = @"../../BD/BrokerSeguros.accdb";
            CadenaConexion = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + rutaArchivo;
            estadoConexion = "Cerrado";

            ConectarBD();
        }

        public void ConectarBD()
        {
            try
            {
                Conexion = new OleDbConnection();
                Conexion.ConnectionString = CadenaConexion;
                Conexion.Open();
                estadoConexion = "Abierto";
                //Comando = new OleDbCommand();
                //Comando.Connection = Conexion;
                //Comando.CommandType = System.Data.CommandType.Text;
                //Comando.CommandText = "";
                //Lector = Comando.ExecuteReader();

            }
            catch (Exception ex)
            {
                estadoConexion = ex.Message;

            }
        }
        //class EntradaLog
        //{
        //  public string Usuario { get; set; }
        //  public string Contraseña { get; set; }
        //}

        //class InsertarBD
        //{
        //  public void Main(string[] args)
        // {
        //   string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Ruta\TuBaseDeDatos.accdb";
        // using (OleDbConnection connection = new OleDbConnection(connectionString))
        //{
        //   connection.Open();

        // Supongamos que tienes un objeto LogEntry con información de usuario y contraseña.
        //  EntradaLog logEntry = new EntradaLog
        // {
        //    Usuario = "NombreUsuario",
        //    Contraseña = "ContraseñaSegura"
        //};

        // string insertQuery = "INSERT INTO Usuario (Usuario, Contraseña) VALUES (?, ?)";
        //using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
        //{
        //   command.Parameters.AddWithValue("@usuario", logEntry.Usuario);
        //   command.Parameters.AddWithValue("@contraseña", logEntry.Contraseña);
        //   command.ExecuteNonQuery();
        //}

        //connection.Close();
        // }
        //}
        //}

        public void RegistrarLogs()
        {
            try
            {
                Comando = new OleDbCommand();
                Comando.Connection = Conexion;

                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "INSERT INTO Logs" +
                    "(Usario,FechaHora,Categoria,Descripcion)" +
                    "VALUES ('Prueba', '10/10/2022', 'prueba','Descripcion')";

                // Comando.Parameters.AddWithValue("@Usuario", usuario);
                // Comando.Parameters.AddWithValue("@FechaHora", FechaHora);
                // Comando.Parameters.AddWithValue("@Categoria", categoria);
                // Comando.Parameters.AddWithValue("@Descripcion", descripcion);


                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                estadoConexion = ex.Message;
            }
        }

        public bool Validarusuarios(string usuario, string contrasena)
        {
            
            using (OleDbConnection conn = new OleDbConnection(CadenaConexion))
            {
                try
                {
                    
                    conn.Open();

                    // consulta SQL para buscar un usuario en la base de datos que coincida con el nombre de usuario proporcionado.
                    string query = "SELECT Nombre, Contrasena FROM Usuarios WHERE Nombre = ?";

                    
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        // Se agrega un parámetro "Nombre" a la consulta con el valor del parámetro "usuario".
                        cmd.Parameters.Add(new OleDbParameter("Nombre", usuario));

                        // Se ejecuta la consulta en la base de datos y se obtiene un lector de datos (OleDbDataReader) para procesar los resultados.
                        using (OleDbDataReader rd = cmd.ExecuteReader())
                        {
                            // Se verifica si se encontró una fila en los resultados.
                            if (rd.Read())
                            {
                                // Se extrae el nombre de usuario y la contraseña de la base de datos.
                                string usuarioBD = rd["Nombre"].ToString();
                                string contraBD = rd["Contrasena"].ToString();

                                // Se compara el usuario y contraseña de la BD.
                                // devuelve true, si son validos el usuario y la contraseña
                                return usuarioBD == usuario && contraBD == contrasena;
                            }
                            else
                            {
                                // Si no se encontró una fila en los resultados, se devuelve false, indicando que el usuario no existe en la base de datos.
                                return false;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    // Si se produce una excepción en cualquier punto del proceso, se devuelve false para indicar que la validación falló.
                    return false;
                }
            }
        }
        Estos comentarios describen el propósito y el funcionamiento de cada línea del código en el método Validarusuarios.




        Is this conversation helpful so far?




    }
    }
