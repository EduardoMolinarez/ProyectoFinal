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
    public partial class ClienteForm : Form
    {
        RegistroForm reg = new RegistroForm();
        public ClienteForm()
        {
            InitializeComponent();

            Conexion con = new Conexion();
            con.abrir();

            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo-cliente.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.abrir();

            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void registrar_Btn_Click(object sender, EventArgs e)
        {
            Hide();
            reg.Show();
        }
    }
}
