
namespace Biblioteca
{
    partial class BibliotecaForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bvnd_Lbl = new System.Windows.Forms.Label();
            this.nombre_Tbx = new System.Windows.Forms.TextBox();
            this.contra_Lbl = new System.Windows.Forms.Label();
            this.contra_Tbx = new System.Windows.Forms.TextBox();
            this.login_Btn = new System.Windows.Forms.Button();
            this.nota_Lbl = new System.Windows.Forms.Label();
            this.invitado_Btn = new System.Windows.Forms.Button();
            this.invitado_Lbl = new System.Windows.Forms.Label();
            this.cerrar_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bvnd_Lbl
            // 
            this.bvnd_Lbl.AutoSize = true;
            this.bvnd_Lbl.BackColor = System.Drawing.SystemColors.Control;
            this.bvnd_Lbl.Location = new System.Drawing.Point(40, 23);
            this.bvnd_Lbl.Name = "bvnd_Lbl";
            this.bvnd_Lbl.Size = new System.Drawing.Size(220, 85);
            this.bvnd_Lbl.TabIndex = 0;
            this.bvnd_Lbl.Text = "Bienvenido a la Biblioteca Palacio\r\n\r\nLoguearse como administrador\r\n\r\nNombre:";
            // 
            // nombre_Tbx
            // 
            this.nombre_Tbx.Location = new System.Drawing.Point(43, 112);
            this.nombre_Tbx.Name = "nombre_Tbx";
            this.nombre_Tbx.Size = new System.Drawing.Size(217, 22);
            this.nombre_Tbx.TabIndex = 1;
            // 
            // contra_Lbl
            // 
            this.contra_Lbl.AutoSize = true;
            this.contra_Lbl.Location = new System.Drawing.Point(40, 154);
            this.contra_Lbl.Name = "contra_Lbl";
            this.contra_Lbl.Size = new System.Drawing.Size(81, 17);
            this.contra_Lbl.TabIndex = 2;
            this.contra_Lbl.Text = "Contraseña";
            // 
            // contra_Tbx
            // 
            this.contra_Tbx.Location = new System.Drawing.Point(43, 175);
            this.contra_Tbx.Name = "contra_Tbx";
            this.contra_Tbx.Size = new System.Drawing.Size(217, 22);
            this.contra_Tbx.TabIndex = 3;
            // 
            // login_Btn
            // 
            this.login_Btn.Location = new System.Drawing.Point(78, 212);
            this.login_Btn.Name = "login_Btn";
            this.login_Btn.Size = new System.Drawing.Size(151, 38);
            this.login_Btn.TabIndex = 4;
            this.login_Btn.Text = "Iniciar sesion";
            this.login_Btn.UseVisualStyleBackColor = true;
            this.login_Btn.Click += new System.EventHandler(this.login_Btn_Click);
            // 
            // nota_Lbl
            // 
            this.nota_Lbl.AutoSize = true;
            this.nota_Lbl.Location = new System.Drawing.Point(12, 294);
            this.nota_Lbl.Name = "nota_Lbl";
            this.nota_Lbl.Size = new System.Drawing.Size(308, 34);
            this.nota_Lbl.TabIndex = 5;
            this.nota_Lbl.Text = "Nota: no es necesario iniciar sesion para rentar\r\nun libro, pero si se te pediran" +
    " datos personales";
            // 
            // invitado_Btn
            // 
            this.invitado_Btn.Location = new System.Drawing.Point(368, 148);
            this.invitado_Btn.Name = "invitado_Btn";
            this.invitado_Btn.Size = new System.Drawing.Size(110, 48);
            this.invitado_Btn.TabIndex = 6;
            this.invitado_Btn.Text = "Entrar";
            this.invitado_Btn.UseVisualStyleBackColor = true;
            this.invitado_Btn.Click += new System.EventHandler(this.invitado_Btn_Click);
            // 
            // invitado_Lbl
            // 
            this.invitado_Lbl.AutoSize = true;
            this.invitado_Lbl.Location = new System.Drawing.Point(302, 100);
            this.invitado_Lbl.Name = "invitado_Lbl";
            this.invitado_Lbl.Size = new System.Drawing.Size(240, 34);
            this.invitado_Lbl.TabIndex = 7;
            this.invitado_Lbl.Text = "Puedes rentar un libro como invitado\r\nentra en el siguiente boton";
            // 
            // cerrar_Btn
            // 
            this.cerrar_Btn.Location = new System.Drawing.Point(475, 308);
            this.cerrar_Btn.Name = "cerrar_Btn";
            this.cerrar_Btn.Size = new System.Drawing.Size(83, 35);
            this.cerrar_Btn.TabIndex = 8;
            this.cerrar_Btn.Text = "Cerrar";
            this.cerrar_Btn.UseVisualStyleBackColor = true;
            this.cerrar_Btn.Click += new System.EventHandler(this.cerrar_Btn_Click);
            // 
            // BibliotecaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 355);
            this.Controls.Add(this.cerrar_Btn);
            this.Controls.Add(this.invitado_Lbl);
            this.Controls.Add(this.invitado_Btn);
            this.Controls.Add(this.nota_Lbl);
            this.Controls.Add(this.login_Btn);
            this.Controls.Add(this.contra_Tbx);
            this.Controls.Add(this.contra_Lbl);
            this.Controls.Add(this.nombre_Tbx);
            this.Controls.Add(this.bvnd_Lbl);
            this.Name = "BibliotecaForm";
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.BibliotecaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bvnd_Lbl;
        private System.Windows.Forms.TextBox nombre_Tbx;
        private System.Windows.Forms.Label contra_Lbl;
        private System.Windows.Forms.TextBox contra_Tbx;
        private System.Windows.Forms.Button login_Btn;
        private System.Windows.Forms.Label nota_Lbl;
        private System.Windows.Forms.Button invitado_Btn;
        private System.Windows.Forms.Label invitado_Lbl;
        private System.Windows.Forms.Button cerrar_Btn;
    }
}

