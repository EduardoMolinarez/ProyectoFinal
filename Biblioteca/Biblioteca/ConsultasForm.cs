using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Biblioteca
{
    public partial class ConsultasForm : Form
    {
        Conexion con = new Conexion();
        public ConsultasForm()
        {
            InitializeComponent();

            Conexion con = new Conexion();
            con.abrir();

            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo-consultas.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void regresar_Btn_Click(object sender, EventArgs e)
        {
            Hide();
            AdministradorForm ad = new AdministradorForm();
            ad.Show();
        }

        private void empleado_Btn_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.abrir();

            string msg = "Clave / Nombre / Apellido / Correo / Salario\r";
            string cadena = "SELECT * FROM VISTA_EMPLEADOS";
            try{
                SqlCommand comando = new SqlCommand(cadena, con.conectar);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                     msg += lector.GetValue(0).ToString() + " " + lector.GetValue(1).ToString() + " " +
                        lector.GetValue(2).ToString() + " " + lector.GetValue(3).ToString() + " " + lector.GetValue(4).ToString() + "\r";
                }

                MessageBox.Show(msg);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta");
            }
        }

        private void clientes_Btn_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.abrir();

            string msg = "Clave / Nombre / Apellido / Correo / Libros prestados/ Pendientes\r";
            string cadena = "SELECT * FROM VISTA_CLIENTE";
            try
            {
                SqlCommand comando = new SqlCommand(cadena, con.conectar);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    msg += lector.GetValue(0).ToString() + " " + lector.GetValue(1).ToString() + " " +
                       lector.GetValue(2).ToString() + " " + lector.GetValue(3).ToString() + " " + 
                       lector.GetValue(4).ToString() + " " + lector.GetValue(5).ToString() + "\r";
                }

                MessageBox.Show(msg);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta");
            }
        }

        private void libros_Btn_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.abrir();

            string msg = "Clave / Titulo / Genero / Seccion / Autor / Unidades\r";
            string cadena = "SELECT * FROM VISTA_LIBRO";
            try
            {
                SqlCommand comando = new SqlCommand(cadena, con.conectar);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    msg += lector.GetValue(0).ToString() + " " + lector.GetValue(1).ToString() + " " +
                       lector.GetValue(2).ToString() + " " + lector.GetValue(3).ToString() + " " +
                       lector.GetValue(4).ToString() + " " + lector.GetValue(5).ToString() + "\r";
                }

                MessageBox.Show(msg);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta");
            }
        }

        private void prestamos_Btn_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.abrir();

            string msg = "Clave / Titulo / Genero / Autor / Unidades / Fecha prestamo / Fecha entrega\r";
            string cadena = "SELECT * FROM VISTA_PRESTAMOS";
            try
            {
                SqlCommand comando = new SqlCommand(cadena, con.conectar);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    msg += lector.GetValue(0).ToString() + " " + lector.GetValue(1).ToString() + " " +
                       lector.GetValue(2).ToString() + " " + lector.GetValue(3).ToString() + " " +
                       lector.GetValue(4).ToString() + " " + lector.GetValue(5).ToString() + " " + 
                       lector.GetValue(6).ToString() + "\r";
                }

                MessageBox.Show(msg);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta");
            }
        }
    }
}
