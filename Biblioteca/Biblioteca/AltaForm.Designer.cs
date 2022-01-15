
namespace Biblioteca
{
    partial class AltaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.empleado_RBtn = new System.Windows.Forms.RadioButton();
            this.inicio_Lbl = new System.Windows.Forms.Label();
            this.cliente_RBTn = new System.Windows.Forms.RadioButton();
            this.libro_RBtn = new System.Windows.Forms.RadioButton();
            this.cveEmp_Lbl = new System.Windows.Forms.Label();
            this.nomEmp_Lbl = new System.Windows.Forms.Label();
            this.apeEmp_Lbl = new System.Windows.Forms.Label();
            this.teleEmp_Lbl = new System.Windows.Forms.Label();
            this.correoEmp_Lbl = new System.Windows.Forms.Label();
            this.domiEmp_Lbl = new System.Windows.Forms.Label();
            this.salaEmp_Lbl = new System.Windows.Forms.Label();
            this.horEmp_Lb = new System.Windows.Forms.Label();
            this.cveBib_Lbl = new System.Windows.Forms.Label();
            this.cveEmp_Tbx = new System.Windows.Forms.TextBox();
            this.nomEmp_Tbx = new System.Windows.Forms.TextBox();
            this.apeEmp_Tbx = new System.Windows.Forms.TextBox();
            this.teleEmp_Tbx = new System.Windows.Forms.TextBox();
            this.correoEmp_Tbx = new System.Windows.Forms.TextBox();
            this.domiEmp_Tbx = new System.Windows.Forms.TextBox();
            this.empleado_Pnl = new System.Windows.Forms.Panel();
            this.cveBib_Tbx = new System.Windows.Forms.TextBox();
            this.horEmp_Tbx = new System.Windows.Forms.TextBox();
            this.salaEmp_Tbx = new System.Windows.Forms.TextBox();
            this.cliente_Pnl = new System.Windows.Forms.Panel();
            this.cveCli_Lbl = new System.Windows.Forms.Label();
            this.libPerdidos_Tbx = new System.Windows.Forms.TextBox();
            this.nomCli_Lb = new System.Windows.Forms.Label();
            this.libPresCli_Tbx = new System.Windows.Forms.TextBox();
            this.apeCli_Lbl = new System.Windows.Forms.Label();
            this.teleCli_Lbl = new System.Windows.Forms.Label();
            this.domiCli_Tbx = new System.Windows.Forms.TextBox();
            this.correoCli_Lbl = new System.Windows.Forms.Label();
            this.correoCli_Tbx = new System.Windows.Forms.TextBox();
            this.domiCli_Lbl = new System.Windows.Forms.Label();
            this.teleCli_Tbx = new System.Windows.Forms.TextBox();
            this.libPreCli_Lbl = new System.Windows.Forms.Label();
            this.apeCli_Tbx = new System.Windows.Forms.TextBox();
            this.libPerdidos_Lbl = new System.Windows.Forms.Label();
            this.nomCli_Tbx = new System.Windows.Forms.TextBox();
            this.cveCli_Tbx = new System.Windows.Forms.TextBox();
            this.libro_Pnl = new System.Windows.Forms.Panel();
            this.cveLib_Lbl = new System.Windows.Forms.Label();
            this.titLib_Lbl = new System.Windows.Forms.Label();
            this.genLib_Lbl = new System.Windows.Forms.Label();
            this.secLib_Lbl = new System.Windows.Forms.Label();
            this.uniLib_Tbx = new System.Windows.Forms.TextBox();
            this.autLib_Lbl = new System.Windows.Forms.Label();
            this.autLib_Tbx = new System.Windows.Forms.TextBox();
            this.uniLib_Lbl = new System.Windows.Forms.Label();
            this.secLib_Tbx = new System.Windows.Forms.TextBox();
            this.genLib_Tbx = new System.Windows.Forms.TextBox();
            this.titLib_Tbx = new System.Windows.Forms.TextBox();
            this.cveLib_Tbx = new System.Windows.Forms.TextBox();
            this.aplicar_Btn = new System.Windows.Forms.Button();
            this.limpiar_Btn = new System.Windows.Forms.Button();
            this.regresar_Btn = new System.Windows.Forms.Button();
            this.empleado_Pnl.SuspendLayout();
            this.cliente_Pnl.SuspendLayout();
            this.libro_Pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // empleado_RBtn
            // 
            this.empleado_RBtn.AutoSize = true;
            this.empleado_RBtn.Location = new System.Drawing.Point(80, 171);
            this.empleado_RBtn.Name = "empleado_RBtn";
            this.empleado_RBtn.Size = new System.Drawing.Size(92, 21);
            this.empleado_RBtn.TabIndex = 0;
            this.empleado_RBtn.TabStop = true;
            this.empleado_RBtn.Text = "Empleado";
            this.empleado_RBtn.UseVisualStyleBackColor = true;
            this.empleado_RBtn.CheckedChanged += new System.EventHandler(this.empleado_RBtn_CheckedChanged);
            // 
            // inicio_Lbl
            // 
            this.inicio_Lbl.AutoSize = true;
            this.inicio_Lbl.Location = new System.Drawing.Point(43, 27);
            this.inicio_Lbl.Name = "inicio_Lbl";
            this.inicio_Lbl.Size = new System.Drawing.Size(203, 17);
            this.inicio_Lbl.TabIndex = 1;
            this.inicio_Lbl.Text = "A que tabla desea dar de alta?";
            // 
            // cliente_RBTn
            // 
            this.cliente_RBTn.AutoSize = true;
            this.cliente_RBTn.Location = new System.Drawing.Point(80, 225);
            this.cliente_RBTn.Name = "cliente_RBTn";
            this.cliente_RBTn.Size = new System.Drawing.Size(72, 21);
            this.cliente_RBTn.TabIndex = 2;
            this.cliente_RBTn.TabStop = true;
            this.cliente_RBTn.Text = "Cliente";
            this.cliente_RBTn.UseVisualStyleBackColor = true;
            this.cliente_RBTn.CheckedChanged += new System.EventHandler(this.cliente_RBTn_CheckedChanged);
            // 
            // libro_RBtn
            // 
            this.libro_RBtn.AutoSize = true;
            this.libro_RBtn.Location = new System.Drawing.Point(80, 281);
            this.libro_RBtn.Name = "libro_RBtn";
            this.libro_RBtn.Size = new System.Drawing.Size(61, 21);
            this.libro_RBtn.TabIndex = 3;
            this.libro_RBtn.TabStop = true;
            this.libro_RBtn.Text = "Libro";
            this.libro_RBtn.UseVisualStyleBackColor = true;
            this.libro_RBtn.CheckedChanged += new System.EventHandler(this.libro_RBtn_CheckedChanged);
            // 
            // cveEmp_Lbl
            // 
            this.cveEmp_Lbl.AutoSize = true;
            this.cveEmp_Lbl.Location = new System.Drawing.Point(3, 0);
            this.cveEmp_Lbl.Name = "cveEmp_Lbl";
            this.cveEmp_Lbl.Size = new System.Drawing.Size(129, 17);
            this.cveEmp_Lbl.TabIndex = 5;
            this.cveEmp_Lbl.Text = "Clave de empleado";
            // 
            // nomEmp_Lbl
            // 
            this.nomEmp_Lbl.AutoSize = true;
            this.nomEmp_Lbl.Location = new System.Drawing.Point(3, 45);
            this.nomEmp_Lbl.Name = "nomEmp_Lbl";
            this.nomEmp_Lbl.Size = new System.Drawing.Size(58, 17);
            this.nomEmp_Lbl.TabIndex = 6;
            this.nomEmp_Lbl.Text = "Nombre";
            // 
            // apeEmp_Lbl
            // 
            this.apeEmp_Lbl.AutoSize = true;
            this.apeEmp_Lbl.Location = new System.Drawing.Point(3, 90);
            this.apeEmp_Lbl.Name = "apeEmp_Lbl";
            this.apeEmp_Lbl.Size = new System.Drawing.Size(65, 17);
            this.apeEmp_Lbl.TabIndex = 7;
            this.apeEmp_Lbl.Text = "Apellidos";
            // 
            // teleEmp_Lbl
            // 
            this.teleEmp_Lbl.AutoSize = true;
            this.teleEmp_Lbl.Location = new System.Drawing.Point(3, 135);
            this.teleEmp_Lbl.Name = "teleEmp_Lbl";
            this.teleEmp_Lbl.Size = new System.Drawing.Size(64, 17);
            this.teleEmp_Lbl.TabIndex = 8;
            this.teleEmp_Lbl.Text = "Telefono";
            // 
            // correoEmp_Lbl
            // 
            this.correoEmp_Lbl.AutoSize = true;
            this.correoEmp_Lbl.Location = new System.Drawing.Point(3, 180);
            this.correoEmp_Lbl.Name = "correoEmp_Lbl";
            this.correoEmp_Lbl.Size = new System.Drawing.Size(125, 17);
            this.correoEmp_Lbl.TabIndex = 9;
            this.correoEmp_Lbl.Text = "Correo Electronico";
            // 
            // domiEmp_Lbl
            // 
            this.domiEmp_Lbl.AutoSize = true;
            this.domiEmp_Lbl.Location = new System.Drawing.Point(3, 225);
            this.domiEmp_Lbl.Name = "domiEmp_Lbl";
            this.domiEmp_Lbl.Size = new System.Drawing.Size(64, 17);
            this.domiEmp_Lbl.TabIndex = 10;
            this.domiEmp_Lbl.Text = "Domicilio";
            // 
            // salaEmp_Lbl
            // 
            this.salaEmp_Lbl.AutoSize = true;
            this.salaEmp_Lbl.Location = new System.Drawing.Point(3, 270);
            this.salaEmp_Lbl.Name = "salaEmp_Lbl";
            this.salaEmp_Lbl.Size = new System.Drawing.Size(52, 17);
            this.salaEmp_Lbl.TabIndex = 11;
            this.salaEmp_Lbl.Text = "Salario";
            // 
            // horEmp_Lb
            // 
            this.horEmp_Lb.AutoSize = true;
            this.horEmp_Lb.Location = new System.Drawing.Point(3, 315);
            this.horEmp_Lb.Name = "horEmp_Lb";
            this.horEmp_Lb.Size = new System.Drawing.Size(55, 17);
            this.horEmp_Lb.TabIndex = 12;
            this.horEmp_Lb.Text = "Horario";
            // 
            // cveBib_Lbl
            // 
            this.cveBib_Lbl.AutoSize = true;
            this.cveBib_Lbl.Location = new System.Drawing.Point(3, 360);
            this.cveBib_Lbl.Name = "cveBib_Lbl";
            this.cveBib_Lbl.Size = new System.Drawing.Size(128, 17);
            this.cveBib_Lbl.TabIndex = 13;
            this.cveBib_Lbl.Text = "Clave de Biblioteca";
            // 
            // cveEmp_Tbx
            // 
            this.cveEmp_Tbx.Location = new System.Drawing.Point(6, 20);
            this.cveEmp_Tbx.Name = "cveEmp_Tbx";
            this.cveEmp_Tbx.Size = new System.Drawing.Size(139, 22);
            this.cveEmp_Tbx.TabIndex = 14;
            // 
            // nomEmp_Tbx
            // 
            this.nomEmp_Tbx.Location = new System.Drawing.Point(6, 65);
            this.nomEmp_Tbx.Name = "nomEmp_Tbx";
            this.nomEmp_Tbx.Size = new System.Drawing.Size(139, 22);
            this.nomEmp_Tbx.TabIndex = 15;
            // 
            // apeEmp_Tbx
            // 
            this.apeEmp_Tbx.Location = new System.Drawing.Point(6, 110);
            this.apeEmp_Tbx.Name = "apeEmp_Tbx";
            this.apeEmp_Tbx.Size = new System.Drawing.Size(139, 22);
            this.apeEmp_Tbx.TabIndex = 16;
            // 
            // teleEmp_Tbx
            // 
            this.teleEmp_Tbx.Location = new System.Drawing.Point(6, 155);
            this.teleEmp_Tbx.Name = "teleEmp_Tbx";
            this.teleEmp_Tbx.Size = new System.Drawing.Size(139, 22);
            this.teleEmp_Tbx.TabIndex = 17;
            // 
            // correoEmp_Tbx
            // 
            this.correoEmp_Tbx.Location = new System.Drawing.Point(6, 200);
            this.correoEmp_Tbx.Name = "correoEmp_Tbx";
            this.correoEmp_Tbx.Size = new System.Drawing.Size(139, 22);
            this.correoEmp_Tbx.TabIndex = 18;
            // 
            // domiEmp_Tbx
            // 
            this.domiEmp_Tbx.Location = new System.Drawing.Point(6, 245);
            this.domiEmp_Tbx.Name = "domiEmp_Tbx";
            this.domiEmp_Tbx.Size = new System.Drawing.Size(139, 22);
            this.domiEmp_Tbx.TabIndex = 19;
            // 
            // empleado_Pnl
            // 
            this.empleado_Pnl.Controls.Add(this.cveBib_Tbx);
            this.empleado_Pnl.Controls.Add(this.cveEmp_Lbl);
            this.empleado_Pnl.Controls.Add(this.horEmp_Tbx);
            this.empleado_Pnl.Controls.Add(this.nomEmp_Lbl);
            this.empleado_Pnl.Controls.Add(this.salaEmp_Tbx);
            this.empleado_Pnl.Controls.Add(this.apeEmp_Lbl);
            this.empleado_Pnl.Controls.Add(this.teleEmp_Lbl);
            this.empleado_Pnl.Controls.Add(this.domiEmp_Tbx);
            this.empleado_Pnl.Controls.Add(this.correoEmp_Lbl);
            this.empleado_Pnl.Controls.Add(this.correoEmp_Tbx);
            this.empleado_Pnl.Controls.Add(this.domiEmp_Lbl);
            this.empleado_Pnl.Controls.Add(this.teleEmp_Tbx);
            this.empleado_Pnl.Controls.Add(this.salaEmp_Lbl);
            this.empleado_Pnl.Controls.Add(this.apeEmp_Tbx);
            this.empleado_Pnl.Controls.Add(this.horEmp_Lb);
            this.empleado_Pnl.Controls.Add(this.nomEmp_Tbx);
            this.empleado_Pnl.Controls.Add(this.cveBib_Lbl);
            this.empleado_Pnl.Controls.Add(this.cveEmp_Tbx);
            this.empleado_Pnl.Location = new System.Drawing.Point(268, 27);
            this.empleado_Pnl.Name = "empleado_Pnl";
            this.empleado_Pnl.Size = new System.Drawing.Size(165, 418);
            this.empleado_Pnl.TabIndex = 20;
            // 
            // cveBib_Tbx
            // 
            this.cveBib_Tbx.Enabled = false;
            this.cveBib_Tbx.Location = new System.Drawing.Point(6, 380);
            this.cveBib_Tbx.Name = "cveBib_Tbx";
            this.cveBib_Tbx.Size = new System.Drawing.Size(139, 22);
            this.cveBib_Tbx.TabIndex = 23;
            this.cveBib_Tbx.Text = "11";
            // 
            // horEmp_Tbx
            // 
            this.horEmp_Tbx.Location = new System.Drawing.Point(6, 335);
            this.horEmp_Tbx.Name = "horEmp_Tbx";
            this.horEmp_Tbx.Size = new System.Drawing.Size(139, 22);
            this.horEmp_Tbx.TabIndex = 22;
            // 
            // salaEmp_Tbx
            // 
            this.salaEmp_Tbx.Location = new System.Drawing.Point(6, 290);
            this.salaEmp_Tbx.Name = "salaEmp_Tbx";
            this.salaEmp_Tbx.Size = new System.Drawing.Size(139, 22);
            this.salaEmp_Tbx.TabIndex = 21;
            // 
            // cliente_Pnl
            // 
            this.cliente_Pnl.Controls.Add(this.cveCli_Lbl);
            this.cliente_Pnl.Controls.Add(this.libPerdidos_Tbx);
            this.cliente_Pnl.Controls.Add(this.nomCli_Lb);
            this.cliente_Pnl.Controls.Add(this.libPresCli_Tbx);
            this.cliente_Pnl.Controls.Add(this.apeCli_Lbl);
            this.cliente_Pnl.Controls.Add(this.teleCli_Lbl);
            this.cliente_Pnl.Controls.Add(this.domiCli_Tbx);
            this.cliente_Pnl.Controls.Add(this.correoCli_Lbl);
            this.cliente_Pnl.Controls.Add(this.correoCli_Tbx);
            this.cliente_Pnl.Controls.Add(this.domiCli_Lbl);
            this.cliente_Pnl.Controls.Add(this.teleCli_Tbx);
            this.cliente_Pnl.Controls.Add(this.libPreCli_Lbl);
            this.cliente_Pnl.Controls.Add(this.apeCli_Tbx);
            this.cliente_Pnl.Controls.Add(this.libPerdidos_Lbl);
            this.cliente_Pnl.Controls.Add(this.nomCli_Tbx);
            this.cliente_Pnl.Controls.Add(this.cveCli_Tbx);
            this.cliente_Pnl.Location = new System.Drawing.Point(439, 27);
            this.cliente_Pnl.Name = "cliente_Pnl";
            this.cliente_Pnl.Size = new System.Drawing.Size(165, 377);
            this.cliente_Pnl.TabIndex = 24;
            // 
            // cveCli_Lbl
            // 
            this.cveCli_Lbl.AutoSize = true;
            this.cveCli_Lbl.Location = new System.Drawing.Point(3, 0);
            this.cveCli_Lbl.Name = "cveCli_Lbl";
            this.cveCli_Lbl.Size = new System.Drawing.Size(108, 17);
            this.cveCli_Lbl.TabIndex = 5;
            this.cveCli_Lbl.Text = "Clave de cliente";
            // 
            // libPerdidos_Tbx
            // 
            this.libPerdidos_Tbx.Enabled = false;
            this.libPerdidos_Tbx.Location = new System.Drawing.Point(6, 335);
            this.libPerdidos_Tbx.Name = "libPerdidos_Tbx";
            this.libPerdidos_Tbx.Size = new System.Drawing.Size(139, 22);
            this.libPerdidos_Tbx.TabIndex = 22;
            this.libPerdidos_Tbx.Text = "0";
            // 
            // nomCli_Lb
            // 
            this.nomCli_Lb.AutoSize = true;
            this.nomCli_Lb.Location = new System.Drawing.Point(3, 45);
            this.nomCli_Lb.Name = "nomCli_Lb";
            this.nomCli_Lb.Size = new System.Drawing.Size(58, 17);
            this.nomCli_Lb.TabIndex = 6;
            this.nomCli_Lb.Text = "Nombre";
            // 
            // libPresCli_Tbx
            // 
            this.libPresCli_Tbx.Enabled = false;
            this.libPresCli_Tbx.Location = new System.Drawing.Point(6, 290);
            this.libPresCli_Tbx.Name = "libPresCli_Tbx";
            this.libPresCli_Tbx.Size = new System.Drawing.Size(139, 22);
            this.libPresCli_Tbx.TabIndex = 21;
            this.libPresCli_Tbx.Text = "0";
            // 
            // apeCli_Lbl
            // 
            this.apeCli_Lbl.AutoSize = true;
            this.apeCli_Lbl.Location = new System.Drawing.Point(3, 90);
            this.apeCli_Lbl.Name = "apeCli_Lbl";
            this.apeCli_Lbl.Size = new System.Drawing.Size(65, 17);
            this.apeCli_Lbl.TabIndex = 7;
            this.apeCli_Lbl.Text = "Apellidos";
            // 
            // teleCli_Lbl
            // 
            this.teleCli_Lbl.AutoSize = true;
            this.teleCli_Lbl.Location = new System.Drawing.Point(3, 135);
            this.teleCli_Lbl.Name = "teleCli_Lbl";
            this.teleCli_Lbl.Size = new System.Drawing.Size(64, 17);
            this.teleCli_Lbl.TabIndex = 8;
            this.teleCli_Lbl.Text = "Telefono";
            // 
            // domiCli_Tbx
            // 
            this.domiCli_Tbx.Location = new System.Drawing.Point(6, 245);
            this.domiCli_Tbx.Name = "domiCli_Tbx";
            this.domiCli_Tbx.Size = new System.Drawing.Size(139, 22);
            this.domiCli_Tbx.TabIndex = 19;
            // 
            // correoCli_Lbl
            // 
            this.correoCli_Lbl.AutoSize = true;
            this.correoCli_Lbl.Location = new System.Drawing.Point(3, 180);
            this.correoCli_Lbl.Name = "correoCli_Lbl";
            this.correoCli_Lbl.Size = new System.Drawing.Size(125, 17);
            this.correoCli_Lbl.TabIndex = 9;
            this.correoCli_Lbl.Text = "Correo Electronico";
            // 
            // correoCli_Tbx
            // 
            this.correoCli_Tbx.Location = new System.Drawing.Point(6, 200);
            this.correoCli_Tbx.Name = "correoCli_Tbx";
            this.correoCli_Tbx.Size = new System.Drawing.Size(139, 22);
            this.correoCli_Tbx.TabIndex = 18;
            // 
            // domiCli_Lbl
            // 
            this.domiCli_Lbl.AutoSize = true;
            this.domiCli_Lbl.Location = new System.Drawing.Point(3, 225);
            this.domiCli_Lbl.Name = "domiCli_Lbl";
            this.domiCli_Lbl.Size = new System.Drawing.Size(64, 17);
            this.domiCli_Lbl.TabIndex = 10;
            this.domiCli_Lbl.Text = "Domicilio";
            // 
            // teleCli_Tbx
            // 
            this.teleCli_Tbx.Location = new System.Drawing.Point(6, 155);
            this.teleCli_Tbx.Name = "teleCli_Tbx";
            this.teleCli_Tbx.Size = new System.Drawing.Size(139, 22);
            this.teleCli_Tbx.TabIndex = 17;
            // 
            // libPreCli_Lbl
            // 
            this.libPreCli_Lbl.AutoSize = true;
            this.libPreCli_Lbl.Location = new System.Drawing.Point(3, 270);
            this.libPreCli_Lbl.Name = "libPreCli_Lbl";
            this.libPreCli_Lbl.Size = new System.Drawing.Size(115, 17);
            this.libPreCli_Lbl.TabIndex = 11;
            this.libPreCli_Lbl.Text = "Libros Prestados";
            // 
            // apeCli_Tbx
            // 
            this.apeCli_Tbx.Location = new System.Drawing.Point(6, 110);
            this.apeCli_Tbx.Name = "apeCli_Tbx";
            this.apeCli_Tbx.Size = new System.Drawing.Size(139, 22);
            this.apeCli_Tbx.TabIndex = 16;
            // 
            // libPerdidos_Lbl
            // 
            this.libPerdidos_Lbl.AutoSize = true;
            this.libPerdidos_Lbl.Location = new System.Drawing.Point(3, 315);
            this.libPerdidos_Lbl.Name = "libPerdidos_Lbl";
            this.libPerdidos_Lbl.Size = new System.Drawing.Size(107, 17);
            this.libPerdidos_Lbl.TabIndex = 12;
            this.libPerdidos_Lbl.Text = "Libros Perdidos";
            // 
            // nomCli_Tbx
            // 
            this.nomCli_Tbx.Location = new System.Drawing.Point(6, 65);
            this.nomCli_Tbx.Name = "nomCli_Tbx";
            this.nomCli_Tbx.Size = new System.Drawing.Size(139, 22);
            this.nomCli_Tbx.TabIndex = 15;
            // 
            // cveCli_Tbx
            // 
            this.cveCli_Tbx.Location = new System.Drawing.Point(6, 20);
            this.cveCli_Tbx.Name = "cveCli_Tbx";
            this.cveCli_Tbx.Size = new System.Drawing.Size(139, 22);
            this.cveCli_Tbx.TabIndex = 14;
            // 
            // libro_Pnl
            // 
            this.libro_Pnl.Controls.Add(this.cveLib_Lbl);
            this.libro_Pnl.Controls.Add(this.titLib_Lbl);
            this.libro_Pnl.Controls.Add(this.genLib_Lbl);
            this.libro_Pnl.Controls.Add(this.secLib_Lbl);
            this.libro_Pnl.Controls.Add(this.uniLib_Tbx);
            this.libro_Pnl.Controls.Add(this.autLib_Lbl);
            this.libro_Pnl.Controls.Add(this.autLib_Tbx);
            this.libro_Pnl.Controls.Add(this.uniLib_Lbl);
            this.libro_Pnl.Controls.Add(this.secLib_Tbx);
            this.libro_Pnl.Controls.Add(this.genLib_Tbx);
            this.libro_Pnl.Controls.Add(this.titLib_Tbx);
            this.libro_Pnl.Controls.Add(this.cveLib_Tbx);
            this.libro_Pnl.Location = new System.Drawing.Point(610, 27);
            this.libro_Pnl.Name = "libro_Pnl";
            this.libro_Pnl.Size = new System.Drawing.Size(165, 276);
            this.libro_Pnl.TabIndex = 25;
            // 
            // cveLib_Lbl
            // 
            this.cveLib_Lbl.AutoSize = true;
            this.cveLib_Lbl.Location = new System.Drawing.Point(3, 0);
            this.cveLib_Lbl.Name = "cveLib_Lbl";
            this.cveLib_Lbl.Size = new System.Drawing.Size(94, 17);
            this.cveLib_Lbl.TabIndex = 5;
            this.cveLib_Lbl.Text = "Clave de libro";
            // 
            // titLib_Lbl
            // 
            this.titLib_Lbl.AutoSize = true;
            this.titLib_Lbl.Location = new System.Drawing.Point(3, 45);
            this.titLib_Lbl.Name = "titLib_Lbl";
            this.titLib_Lbl.Size = new System.Drawing.Size(43, 17);
            this.titLib_Lbl.TabIndex = 6;
            this.titLib_Lbl.Text = "Titulo";
            // 
            // genLib_Lbl
            // 
            this.genLib_Lbl.AutoSize = true;
            this.genLib_Lbl.Location = new System.Drawing.Point(3, 90);
            this.genLib_Lbl.Name = "genLib_Lbl";
            this.genLib_Lbl.Size = new System.Drawing.Size(56, 17);
            this.genLib_Lbl.TabIndex = 7;
            this.genLib_Lbl.Text = "Genero";
            // 
            // secLib_Lbl
            // 
            this.secLib_Lbl.AutoSize = true;
            this.secLib_Lbl.Location = new System.Drawing.Point(3, 135);
            this.secLib_Lbl.Name = "secLib_Lbl";
            this.secLib_Lbl.Size = new System.Drawing.Size(58, 17);
            this.secLib_Lbl.TabIndex = 8;
            this.secLib_Lbl.Text = "Seccion";
            // 
            // uniLib_Tbx
            // 
            this.uniLib_Tbx.Location = new System.Drawing.Point(6, 245);
            this.uniLib_Tbx.Name = "uniLib_Tbx";
            this.uniLib_Tbx.Size = new System.Drawing.Size(139, 22);
            this.uniLib_Tbx.TabIndex = 19;
            // 
            // autLib_Lbl
            // 
            this.autLib_Lbl.AutoSize = true;
            this.autLib_Lbl.Location = new System.Drawing.Point(3, 180);
            this.autLib_Lbl.Name = "autLib_Lbl";
            this.autLib_Lbl.Size = new System.Drawing.Size(42, 17);
            this.autLib_Lbl.TabIndex = 9;
            this.autLib_Lbl.Text = "Autor";
            // 
            // autLib_Tbx
            // 
            this.autLib_Tbx.Location = new System.Drawing.Point(6, 200);
            this.autLib_Tbx.Name = "autLib_Tbx";
            this.autLib_Tbx.Size = new System.Drawing.Size(139, 22);
            this.autLib_Tbx.TabIndex = 18;
            // 
            // uniLib_Lbl
            // 
            this.uniLib_Lbl.AutoSize = true;
            this.uniLib_Lbl.Location = new System.Drawing.Point(3, 225);
            this.uniLib_Lbl.Name = "uniLib_Lbl";
            this.uniLib_Lbl.Size = new System.Drawing.Size(68, 17);
            this.uniLib_Lbl.TabIndex = 10;
            this.uniLib_Lbl.Text = "Unidades";
            // 
            // secLib_Tbx
            // 
            this.secLib_Tbx.Location = new System.Drawing.Point(6, 155);
            this.secLib_Tbx.Name = "secLib_Tbx";
            this.secLib_Tbx.Size = new System.Drawing.Size(139, 22);
            this.secLib_Tbx.TabIndex = 17;
            // 
            // genLib_Tbx
            // 
            this.genLib_Tbx.Location = new System.Drawing.Point(6, 110);
            this.genLib_Tbx.Name = "genLib_Tbx";
            this.genLib_Tbx.Size = new System.Drawing.Size(139, 22);
            this.genLib_Tbx.TabIndex = 16;
            // 
            // titLib_Tbx
            // 
            this.titLib_Tbx.Location = new System.Drawing.Point(6, 65);
            this.titLib_Tbx.Name = "titLib_Tbx";
            this.titLib_Tbx.Size = new System.Drawing.Size(139, 22);
            this.titLib_Tbx.TabIndex = 15;
            // 
            // cveLib_Tbx
            // 
            this.cveLib_Tbx.Location = new System.Drawing.Point(6, 20);
            this.cveLib_Tbx.Name = "cveLib_Tbx";
            this.cveLib_Tbx.Size = new System.Drawing.Size(139, 22);
            this.cveLib_Tbx.TabIndex = 14;
            // 
            // aplicar_Btn
            // 
            this.aplicar_Btn.Location = new System.Drawing.Point(252, 462);
            this.aplicar_Btn.Name = "aplicar_Btn";
            this.aplicar_Btn.Size = new System.Drawing.Size(83, 38);
            this.aplicar_Btn.TabIndex = 26;
            this.aplicar_Btn.Text = "Aplicar";
            this.aplicar_Btn.UseVisualStyleBackColor = true;
            this.aplicar_Btn.Click += new System.EventHandler(this.aplicar_Btn_Click);
            // 
            // limpiar_Btn
            // 
            this.limpiar_Btn.Location = new System.Drawing.Point(370, 462);
            this.limpiar_Btn.Name = "limpiar_Btn";
            this.limpiar_Btn.Size = new System.Drawing.Size(83, 38);
            this.limpiar_Btn.TabIndex = 27;
            this.limpiar_Btn.Text = "Limpiar";
            this.limpiar_Btn.UseVisualStyleBackColor = true;
            this.limpiar_Btn.Click += new System.EventHandler(this.limpiar_Btn_Click);
            // 
            // regresar_Btn
            // 
            this.regresar_Btn.Location = new System.Drawing.Point(517, 485);
            this.regresar_Btn.Name = "regresar_Btn";
            this.regresar_Btn.Size = new System.Drawing.Size(83, 38);
            this.regresar_Btn.TabIndex = 28;
            this.regresar_Btn.Text = "Regresar";
            this.regresar_Btn.UseVisualStyleBackColor = true;
            this.regresar_Btn.Click += new System.EventHandler(this.regresar_Btn_Click);
            // 
            // AltaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 535);
            this.Controls.Add(this.regresar_Btn);
            this.Controls.Add(this.limpiar_Btn);
            this.Controls.Add(this.aplicar_Btn);
            this.Controls.Add(this.libro_Pnl);
            this.Controls.Add(this.cliente_Pnl);
            this.Controls.Add(this.empleado_Pnl);
            this.Controls.Add(this.libro_RBtn);
            this.Controls.Add(this.cliente_RBTn);
            this.Controls.Add(this.inicio_Lbl);
            this.Controls.Add(this.empleado_RBtn);
            this.Name = "AltaForm";
            this.Text = "Alta";
            this.empleado_Pnl.ResumeLayout(false);
            this.empleado_Pnl.PerformLayout();
            this.cliente_Pnl.ResumeLayout(false);
            this.cliente_Pnl.PerformLayout();
            this.libro_Pnl.ResumeLayout(false);
            this.libro_Pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton empleado_RBtn;
        private System.Windows.Forms.Label inicio_Lbl;
        private System.Windows.Forms.RadioButton cliente_RBTn;
        private System.Windows.Forms.RadioButton libro_RBtn;
        private System.Windows.Forms.Label cveEmp_Lbl;
        private System.Windows.Forms.Label nomEmp_Lbl;
        private System.Windows.Forms.Label apeEmp_Lbl;
        private System.Windows.Forms.Label teleEmp_Lbl;
        private System.Windows.Forms.Label correoEmp_Lbl;
        private System.Windows.Forms.Label domiEmp_Lbl;
        private System.Windows.Forms.Label salaEmp_Lbl;
        private System.Windows.Forms.Label horEmp_Lb;
        private System.Windows.Forms.Label cveBib_Lbl;
        private System.Windows.Forms.TextBox cveEmp_Tbx;
        private System.Windows.Forms.TextBox nomEmp_Tbx;
        private System.Windows.Forms.TextBox apeEmp_Tbx;
        private System.Windows.Forms.TextBox teleEmp_Tbx;
        private System.Windows.Forms.TextBox correoEmp_Tbx;
        private System.Windows.Forms.TextBox domiEmp_Tbx;
        private System.Windows.Forms.Panel empleado_Pnl;
        private System.Windows.Forms.TextBox cveBib_Tbx;
        private System.Windows.Forms.TextBox horEmp_Tbx;
        private System.Windows.Forms.TextBox salaEmp_Tbx;
        private System.Windows.Forms.Panel cliente_Pnl;
        private System.Windows.Forms.Label cveCli_Lbl;
        private System.Windows.Forms.TextBox libPerdidos_Tbx;
        private System.Windows.Forms.Label nomCli_Lb;
        private System.Windows.Forms.TextBox libPresCli_Tbx;
        private System.Windows.Forms.Label apeCli_Lbl;
        private System.Windows.Forms.Label teleCli_Lbl;
        private System.Windows.Forms.TextBox domiCli_Tbx;
        private System.Windows.Forms.Label correoCli_Lbl;
        private System.Windows.Forms.TextBox correoCli_Tbx;
        private System.Windows.Forms.Label domiCli_Lbl;
        private System.Windows.Forms.TextBox teleCli_Tbx;
        private System.Windows.Forms.Label libPreCli_Lbl;
        private System.Windows.Forms.TextBox apeCli_Tbx;
        private System.Windows.Forms.Label libPerdidos_Lbl;
        private System.Windows.Forms.TextBox nomCli_Tbx;
        private System.Windows.Forms.TextBox cveCli_Tbx;
        private System.Windows.Forms.Panel libro_Pnl;
        private System.Windows.Forms.Label cveLib_Lbl;
        private System.Windows.Forms.Label titLib_Lbl;
        private System.Windows.Forms.Label genLib_Lbl;
        private System.Windows.Forms.Label secLib_Lbl;
        private System.Windows.Forms.TextBox uniLib_Tbx;
        private System.Windows.Forms.Label autLib_Lbl;
        private System.Windows.Forms.TextBox autLib_Tbx;
        private System.Windows.Forms.Label uniLib_Lbl;
        private System.Windows.Forms.TextBox secLib_Tbx;
        private System.Windows.Forms.TextBox genLib_Tbx;
        private System.Windows.Forms.TextBox titLib_Tbx;
        private System.Windows.Forms.TextBox cveLib_Tbx;
        private System.Windows.Forms.Button aplicar_Btn;
        private System.Windows.Forms.Button limpiar_Btn;
        private System.Windows.Forms.Button regresar_Btn;
    }
}