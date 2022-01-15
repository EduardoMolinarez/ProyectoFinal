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
    public partial class AdministradorForm : Form
    {
        ConsultasForm con = new ConsultasForm();
        AltaForm alta = new AltaForm();
        BajaFrom baja = new BajaFrom();
        CambiosForm camb = new CambiosForm();
        public AdministradorForm()
        {
            InitializeComponent();
        }

        private void AdministradorForm_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.abrir();

            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo-admin.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void regresar_Btn_Click(object sender, EventArgs e)
        {
            BibliotecaForm bib = new BibliotecaForm();
            Hide();
            bib.Show();
        }

        private void consulta_Btn_Click(object sender, EventArgs e)
        {
            Hide();
            con.Show();
        }

        private void alta_Btn_Click(object sender, EventArgs e)
        {
            Hide();
            alta.Show();
        }

        private void baja_Btn_Click(object sender, EventArgs e)
        {
            Hide();
            baja.Show();
        }

        private void cambios_Btn_Click(object sender, EventArgs e)
        {
            Hide();
            camb.Show();
        }
    }
}
