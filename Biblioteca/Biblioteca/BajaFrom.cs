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
    public partial class BajaFrom : Form
    {
        public BajaFrom()
        {
            InitializeComponent();

            Conexion con = new Conexion();
            con.abrir();

            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo-baja.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void regresar_Btn_Click(object sender, EventArgs e)
        {
            Hide();
            AdministradorForm ad = new AdministradorForm();
            ad.Show();
        }
    }
}
