using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.MonthCalendar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp1.Clases
{
    public class Crudtareas
    {
        public string id_tarea { get; set; }
        public string Carnet { get; set; }
        public string nota1 { get; set; }
        public string nota2 { get; set; }
        public string nota3 { get; set; }
        public string nota4 { get; set; }

        string connectionString = "Server=MSI\\SQLEXPRESS;Database=UMGdb;Integrated Security=True; TrustServerCertificate=True;";
        public Crudtareas MostrarInformacion(string carnet)
        {

            Crudtareas micrud = new Crudtareas
            {
                id_tarea = "No existe",
                Carnet = "No existe",
                nota1 = "No existe",
                nota2 = "No existe",
                nota3 = "No existe",
                nota4 = "No existe",
            };

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM tareas WHERE carnet = @carnet";
                try
                {
                    SqlCommand comand = new SqlCommand(query, connection);
                    comand.Parameters.AddWithValue("@carnet", carnet);
                    connection.Open();
                    SqlDataReader reader = comand.ExecuteReader();

                    while (reader.Read())
                    {

                        micrud.id_tarea = reader["id_tarea"].ToString();
                        micrud.Carnet = reader["Carnet"].ToString();
                        micrud.nota1 = reader["nota1"].ToString();
                        micrud.nota2 = reader["nota2"].ToString();
                        micrud.nota3 = reader["nota3"].ToString();
                        micrud.nota4 = reader["nota4"].ToString();
                    }
                }
                catch (Exception ex)
                {

                    micrud.id_tarea = "Error";
                    micrud.Carnet = "Error";
                    micrud.nota1 = "Error";
                    micrud.nota2 = "Error";
                    micrud.nota3 = "Error";
                    micrud.nota4 = "Error";

                    Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                }
                connection.Close();
            }
            return micrud;
        }


        public string InsertarInformacion( string Carnet, string nota1, string nota2, string nota3, string nota4)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tareas (Carnet, nota1, nota2, nota3, nota4) VALUES (@Carnet, @nota1, @nota2, @nota3, @nota4)";
                try
                {
                    SqlCommand comand = new SqlCommand(query, connection);
                    //comand.Parameters.AddWithValue("@idtarea", idtarea);
                    comand.Parameters.AddWithValue("@Carnet", Carnet);
                    comand.Parameters.AddWithValue("@nota1", nota1);
                    comand.Parameters.AddWithValue("@nota2", nota2);
                    comand.Parameters.AddWithValue("@nota3", nota3);
                    comand.Parameters.AddWithValue("@nota4", nota4);


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





    }
}
