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
    public partial class RegistroForm : Form
    {
        public RegistroForm()
        {
            InitializeComponent();

            Conexion con = new Conexion();
            con.abrir();

            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo-registro.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
