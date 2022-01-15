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
    public partial class CambiosForm : Form
    {
        public CambiosForm()
        {
            InitializeComponent();

            Conexion con = new Conexion();
            con.abrir();

            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo-cambios.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void empleado_RBtn_CheckedChanged(object sender, EventArgs e)
        {
            aplicar_Btn.Location = new Point(165, 300);
            limpiar_Btn.Location = new Point(232, 300);
            empleado_Pnl.Visible = true;
            cliente_Pnl.Visible = false;
            libro_Pnl.Visible = false;
        }

        private void cliente_RBTn_CheckedChanged(object sender, EventArgs e)
        {
            cliente_Pnl.Location = new Point(170, 52);
            aplicar_Btn.Location = new Point(165, 300);
            limpiar_Btn.Location = new Point(232, 300);
            empleado_Pnl.Visible = false;
            cliente_Pnl.Visible = true;
            libro_Pnl.Visible = false;
        }

        private void libro_RBtn_CheckedChanged(object sender, EventArgs e)
        {
            libro_Pnl.Location = new Point(170, 52);
            aplicar_Btn.Location = new Point(165, 235);
            limpiar_Btn.Location = new Point(232, 235);
            empleado_Pnl.Visible = false;
            cliente_Pnl.Visible = false;
            libro_Pnl.Visible = true;
        }

        private void regresar_Btn_Click(object sender, EventArgs e)
        {
            Hide();
            AdministradorForm ad = new AdministradorForm();
            ad.Show();
        }
    }
    
}
