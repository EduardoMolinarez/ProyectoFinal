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
    public partial class AltaForm : Form
    {
        public AltaForm()
        {
            InitializeComponent();

            Conexion con = new Conexion();
            con.abrir();

            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo-alta.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void empleado_RBtn_CheckedChanged(object sender, EventArgs e)
        {
            aplicar_Btn.Location = new Point(197, 370);
            limpiar_Btn.Location = new Point(263, 370);
            empleado_Pnl.Visible = true;
            cliente_Pnl.Visible = false;
            libro_Pnl.Visible = false;
        }

        private void cliente_RBTn_CheckedChanged(object sender, EventArgs e)
        {
            cliente_Pnl.Location = new Point(197,22);
            aplicar_Btn.Location = new Point(197,337);
            limpiar_Btn.Location = new Point(263,337);
            empleado_Pnl.Visible = false;
            cliente_Pnl.Visible = true;
            libro_Pnl.Visible = false;
        }

        private void libro_RBtn_CheckedChanged(object sender, EventArgs e)
        {
            libro_Pnl.Location = new Point(197, 22);
            aplicar_Btn.Location = new Point(197, 250);
            limpiar_Btn.Location = new Point(263, 250);
            empleado_Pnl.Visible = false;
            cliente_Pnl.Visible = false;
            libro_Pnl.Visible = true;
        }

        private void limpiar_Btn_Click(object sender, EventArgs e)
        {

        }

        private void regresar_Btn_Click(object sender, EventArgs e)
        {
            Hide();
            AdministradorForm ad = new AdministradorForm();
            ad.Show();
        }

        public int encotrarDatos()
        {
            if(empleado_RBtn.Checked == false)
            {
                if (cliente_RBTn.Checked == false)
                {
                    if (libro_RBtn.Checked == false)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 1;
            }
        }

        private void aplicar_Btn_Click(object sender, EventArgs e)
        { 
            switch (encotrarDatos())
            {
                case 1:
                    Conexion con = new Conexion();
                    con.abrir();
                    string cadena = "INSERT INTO EMPLEADO(cve_empleado, nombre, apellidos, telefono, correo_elec, domicilio, salario, horario, cve_biblioteca) " +
                        "VALUES(@id,@nombre,@apellido,@telefono,@correo,@domicilio,@salario,@horario,@id_bib)";
                    try
                    {
                        SqlCommand comando = new SqlCommand(cadena, con.conectar);
                        comando.Parameters.AddWithValue("@id", Convert.ToInt32(cveEmp_Tbx.Text));
                        comando.Parameters.AddWithValue("@nombre", Convert.ToString(nomEmp_Tbx.Text));
                        comando.Parameters.AddWithValue("@apellido", Convert.ToString(apeEmp_Tbx.Text));
                        comando.Parameters.AddWithValue("@telefono", Convert.ToInt32(teleEmp_Tbx.Text));
                        comando.Parameters.AddWithValue("@correo", Convert.ToString(correoEmp_Tbx.Text));
                        comando.Parameters.AddWithValue("@domicilio", Convert.ToString(correoEmp_Tbx.Text));
                        comando.Parameters.AddWithValue("@salario", Convert.ToDecimal(salaEmp_Tbx.Text));
                        comando.Parameters.AddWithValue("@horario", Convert.ToString(horEmp_Tbx.Text));
                        comando.Parameters.AddWithValue("@id_bib",Convert.ToInt32(cveBib_Tbx.Text));

                        MessageBox.Show("Se registro el empleado\r" + cveEmp_Tbx.Text + "\r" + nomEmp_Tbx.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar los datos" + ex.Message);
                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 0:
                    break;
                default:
                    break;
            }
        }
    }
}
