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
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string NombreUsuario { get; set; }
        public string Rol { get; set; }
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

        public void RegistrarLogs(string Usuario, string Contrasena, string Rol)
        {
           

            using (OleDbConnection conn = new OleDbConnection(CadenaConexion))
            {
                conn.Open();

                string sqlCheckUser = "SELECT Usuario FROM Usuarios WHERE Usuario = ?";
                using (OleDbCommand cmdCheckUser = new OleDbCommand(sqlCheckUser, conn))
                {
                    cmdCheckUser.Parameters.AddWithValue("param1", Usuario);
                    using (OleDbDataReader reader = cmdCheckUser.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Usuario Existente");
                            return;
                        }
                    }
                }

                string sqlInsertUser = "INSERT INTO Usuarios(Usuario, Contraseña, Rol) VALUES (?, ?, ?)";
                using (OleDbCommand cmdInsertUser = new OleDbCommand(sqlInsertUser, conn))
                {
                    cmdInsertUser.Parameters.AddWithValue("param1", Usuario);
                    cmdInsertUser.Parameters.AddWithValue("param2", Contrasena);
                    cmdInsertUser.Parameters.AddWithValue("param3", Rol);

                    cmdInsertUser.ExecuteNonQuery();
                }
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
        public static clsLogs Login(string usuario, string contrasena)
        {
            string rutaArchivo = @"../../archivos/usuarios.accdb";
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT IdUsuario, Usuario, Contraseña, Rol FROM Usuarios WHERE Usuario = ? AND Contraseña = ?";
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@p1", usuario);
                        cmd.Parameters.AddWithValue("@p2", contrasena);
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                clsLogs currentUser = new clsLogs
                                {
                                    Id = reader.GetInt32(0),
                                    Usuario = reader.GetString(1),
                                    Contrasena = reader.GetString(2),
                                    Rol = reader.GetString(3)
                                };
                                return currentUser;
                            }
                        }
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show(ex.Message);
                        throw;
                    }
                }
            }
            return null;
        }





    }
}
