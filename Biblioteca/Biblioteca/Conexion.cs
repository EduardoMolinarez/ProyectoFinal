using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Biblioteca
{
    class Conexion
    {
        public string cadena = "Data Source=DESKTOP-JOV052D\\SQLEXPRESS;Initial Catalog=Biblioteca; Integrated Security=True";
        public SqlConnection conectar = new SqlConnection();

        public Conexion()
        {
            conectar.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conectar.Open();
                Console.WriteLine("Conexion abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo conectar" + ex.Message);
            }
        }

        public void cerrar()
        {
            conectar.Close();
        }
    }
}
