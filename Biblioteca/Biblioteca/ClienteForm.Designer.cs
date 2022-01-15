
namespace Biblioteca
{
    partial class ClienteForm
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
            this.iniCli_Lbl = new System.Windows.Forms.Label();
            this.libDis_Btn = new System.Windows.Forms.Button();
            this.libReg_Btn = new System.Windows.Forms.Button();
            this.registrar_Btn = new System.Windows.Forms.Button();
            this.prestamo_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iniCli_Lbl
            // 
            this.iniCli_Lbl.AutoSize = true;
            this.iniCli_Lbl.Location = new System.Drawing.Point(47, 41);
            this.iniCli_Lbl.Name = "iniCli_Lbl";
            this.iniCli_Lbl.Size = new System.Drawing.Size(388, 17);
            this.iniCli_Lbl.TabIndex = 0;
            this.iniCli_Lbl.Text = "Bienvenido, estas son las opciones que tenemos para usted";
            // 
            // libDis_Btn
            // 
            this.libDis_Btn.Location = new System.Drawing.Point(100, 85);
            this.libDis_Btn.Name = "libDis_Btn";
            this.libDis_Btn.Size = new System.Drawing.Size(99, 49);
            this.libDis_Btn.TabIndex = 1;
            this.libDis_Btn.Text = "Libros \r\nDisponibles";
            this.libDis_Btn.UseVisualStyleBackColor = true;
            // 
            // libReg_Btn
            // 
            this.libReg_Btn.Location = new System.Drawing.Point(261, 85);
            this.libReg_Btn.Name = "libReg_Btn";
            this.libReg_Btn.Size = new System.Drawing.Size(99, 49);
            this.libReg_Btn.TabIndex = 2;
            this.libReg_Btn.Text = "Libros\r\nPrestados";
            this.libReg_Btn.UseVisualStyleBackColor = true;
            // 
            // registrar_Btn
            // 
            this.registrar_Btn.Location = new System.Drawing.Point(185, 219);
            this.registrar_Btn.Name = "registrar_Btn";
            this.registrar_Btn.Size = new System.Drawing.Size(109, 40);
            this.registrar_Btn.TabIndex = 3;
            this.registrar_Btn.Text = "Registrar uno";
            this.registrar_Btn.UseVisualStyleBackColor = true;
            this.registrar_Btn.Click += new System.EventHandler(this.registrar_Btn_Click);
            // 
            // prestamo_Lbl
            // 
            this.prestamo_Lbl.AutoSize = true;
            this.prestamo_Lbl.Location = new System.Drawing.Point(139, 176);
            this.prestamo_Lbl.Name = "prestamo_Lbl";
            this.prestamo_Lbl.Size = new System.Drawing.Size(210, 17);
            this.prestamo_Lbl.TabIndex = 4;
            this.prestamo_Lbl.Text = "Aqui podemos prestarte un libro";
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 319);
            this.Controls.Add(this.prestamo_Lbl);
            this.Controls.Add(this.registrar_Btn);
            this.Controls.Add(this.libReg_Btn);
            this.Controls.Add(this.libDis_Btn);
            this.Controls.Add(this.iniCli_Lbl);
            this.Name = "ClienteForm";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label iniCli_Lbl;
        private System.Windows.Forms.Button libDis_Btn;
        private System.Windows.Forms.Button libReg_Btn;
        private System.Windows.Forms.Button registrar_Btn;
        private System.Windows.Forms.Label prestamo_Lbl;
    }
}