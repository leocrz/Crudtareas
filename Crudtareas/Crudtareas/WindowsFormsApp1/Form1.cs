using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Clases.Crud;
using WindowsFormsApp1.Clases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{


    public partial class Form1 : Form
    {
        Crud miCrud = new Crud();
        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1saludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola te saludo desde el formulario");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxCarnet_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
           // Console.WriteLine($"{}")
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string carnet = textBoxCarnet.Text.Trim(); // obtener carnet del TextBox

            Crud crud = new Crud();
            Crud datos = crud.MostrarInformacion(carnet);

            // Asignar los valores obtenidos a los TextBox
            textBoxNombre.Text = datos.Nombre;
            comboBoxseccion.Text = datos.Seccion;
            textBoxcorreo.Text = datos.Correo;


        }

        

        private void buttonCrear_Click(object sender, EventArgs e)
        {
           
            string carnet = textBoxCarnet.Text.Trim();
            string nombre = textBoxNombre.Text.Trim();
            string seccion = comboBoxseccion.Text.Trim();
            string correo = textBoxcorreo.Text.Trim();

            Crud crud = new Crud();
            string resultado = crud.InsertarInformacion(carnet, nombre, seccion, correo);

            MessageBox.Show(resultado);

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string carnet = textBoxCarnet.Text.Trim();

            if (string.IsNullOrEmpty(carnet))
            {
                MessageBox.Show("Por favor, ingrese un carnet.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Crud crud = new Crud();
            string resultado = crud.EliminarInformacion(carnet);

            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxCarnet.Clear();



        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            string carnet = textBoxCarnet.Text.Trim();
            string nombre = textBoxNombre.Text.Trim();
            string seccion = comboBoxseccion.Text.Trim();
            string correo = textBoxcorreo.Text.Trim();

            // Validación básica (opcional)
            if (string.IsNullOrWhiteSpace(carnet))
            {
                MessageBox.Show("Por favor ingresa el carnet del estudiante.");
                return;
            }

            // Instancia de la clase donde está el método
            Crud conexion = new Crud(); // reemplaza con tu clase real

            string resultado = conexion.ActualizarInformacion(carnet, nombre, seccion, correo);

            MessageBox.Show(resultado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string carnet = textBoxCarnet.Text.Trim(); // obtener carnet del TextBox
            Crud crudt = new Crud();
            Crud datosn = crudt.MostrarInformacion(carnet);
            textBoxNombre.Text = datosn.Nombre;
            comboBoxseccion.Text = datosn.Seccion;
            textBoxcorreo.Text = datosn.Correo;


            Crudtareas crud = new Crudtareas();
            Crudtareas datos = crud.MostrarInformacion(carnet);

            // Asignar los valores obtenidos a los TextBox
            textBoxidtarea.Text = datos.id_tarea;
            textBoxCarnet.Text = datos.Carnet;
            textBoxnota1.Text = datos.nota1;
            textBoxnota2.Text = datos.nota2;
            textBoxnota3.Text = datos.nota3;
            textBoxnota4.Text = datos.nota4;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttoninsertar_Click(object sender, EventArgs e)
        {

            string carnet = textBoxCarnet.Text.Trim();
            string nombre = textBoxNombre.Text.Trim();
            string seccion = comboBoxseccion.Text.Trim();
            string correo = textBoxcorreo.Text.Trim();

            Crud crudDatos = new Crud();
            string resultado = crudDatos.InsertarInformacion(carnet, nombre, seccion, correo);




            
            string carnett = textBoxCarnet.Text.Trim();
            string nota1 = textBoxnota1.Text.Trim();
            string nota2 = textBoxnota2.Text.Trim();
            string nota3 = textBoxnota3.Text.Trim();
            string nota4 = textBoxnota4.Text.Trim();


            Crudtareas crudNotas = new Crudtareas();
            string resultadot = crudNotas.InsertarInformacion(carnett, nota1, nota2, nota3, nota4);

            MessageBox.Show(resultado);
        }

        private void comboBoxseccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxCarnet.Clear();
            textBoxNombre.Clear();
            comboBoxseccion.SelectedIndex = -1;
            textBoxcorreo.Clear();
            textBoxidtarea.Clear();
            textBoxnota1.Clear();
            textBoxnota2.Clear();
            textBoxnota3.Clear();
            textBoxnota4.Clear();

        }
    }
}
