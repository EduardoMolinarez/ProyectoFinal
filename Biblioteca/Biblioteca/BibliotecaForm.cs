using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class BibliotecaForm : Form
    {
        AdministradorForm admin = new AdministradorForm();
        ClienteForm clie = new ClienteForm();
        public BibliotecaForm()
        {
            InitializeComponent();
        }

        private void BibliotecaForm_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.abrir();

            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void login_Btn_Click(object sender, EventArgs e)
        {
            if (nombre_Tbx.Text == "rita")
            {
                admin.Show();
                    Hide();
            }
            else
            {
                MessageBox.Show("Los datos no son correctos");
            }
            
        }

        private void cerrar_Btn_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.cerrar();
            Close();
        }

        private void invitado_Btn_Click(object sender, EventArgs e)
        {
            clie.Show();
            Hide();
        }
    }
}
