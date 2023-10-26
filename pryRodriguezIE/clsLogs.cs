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
                Comando = new OleDbCommand();
                Comando.Connection = Conexion;
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "";
                Lector = Comando.ExecuteReader();

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
    }
}
