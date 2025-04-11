using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//cambiar nomre a los consructores

namespace WindowsFormsApp1.Clases
{


    public class Crud
    {





        public string Nombre { get; set; }
        public string Seccion { get; set; }
        public string Correo { get; set; }
     


        string connectionString = "Server=MSI\\SQLEXPRESS;Database=UMGdb;Integrated Security=True; TrustServerCertificate=True;";


        public Crud MostrarInformacion(string carnet)
        {

            Crud micrud = new Crud
            {
                Nombre = "No existe",
                Seccion = "No existe",
                Correo = "No existe"
            };

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Tb_alumnos WHERE carnet = @carnet";
                try
                {
                    SqlCommand comand = new SqlCommand(query, connection);
                    comand.Parameters.AddWithValue("@carnet", carnet);
                    connection.Open();
                    SqlDataReader reader = comand.ExecuteReader();

                    while (reader.Read())
                    {

                        micrud.Nombre = reader["estudiante"].ToString();
                        micrud.Seccion = reader["seccion"].ToString();
                        micrud.Correo = reader["email"].ToString();
                    }
                }
                catch (Exception ex)
                {

                    micrud.Nombre = "Error";
                    micrud.Seccion = "Error";
                    micrud.Correo = "Error";
                    Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                }


                connection.Close();

            }

            return micrud;
        }


        public string InsertarInformacion(string carnet, string nombre, string seccion, string correo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Tb_alumnos (carnet, estudiante, seccion, email) VALUES (@carnet, @nombre, @seccion, @correo)";
                try
                {
                    SqlCommand comand = new SqlCommand(query, connection);
                    comand.Parameters.AddWithValue("@carnet", carnet);
                    comand.Parameters.AddWithValue("@nombre", nombre);
                    comand.Parameters.AddWithValue("@seccion", seccion);
                    comand.Parameters.AddWithValue("@correo", correo);

                    connection.Open();
                    comand.ExecuteNonQuery();
                    return "Registro insertado Correctamente";

                }

                catch (Exception ex)

                {

                    return "Error al insertar el registro : " + ex.Message;
                }
                connection.Close();
            }
        }

        public string EliminarInformacion(string carnet)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Tb_alumnos WHERE carnet = @carnet";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);

                    connection.Open();
                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        return "Estudiante eliminado correctamente.";
                    }
                    else
                    {
                        return "No se encontró un estudiante con ese carnet.";
                    }
                }
                catch (Exception ex)
                {
                    return "Error al eliminar: " + ex.Message;
                }
                finally
                {
                    connection.Close();
                }
            }
        }



        public string ActualizarInformacion(string carnet, string nombre, string seccion, string correo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Tb_alumnos SET estudiante = @nombre, seccion = @seccion, email = @correo WHERE carnet = @carnet";

                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@seccion", seccion);
                    command.Parameters.AddWithValue("@correo", correo);

                    connection.Open();
                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                        return "Estudiante actualizado correctamente.";
                    else
                        return "No se encontró un estudiante con ese carnet.";
                }
                catch (Exception ex)
                {
                    return "Error al actualizar el registro: " + ex.Message;
                }
                finally
                {
                    connection.Close();
                }
            }
        }










    }

} 




