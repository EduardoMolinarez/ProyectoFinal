
namespace Biblioteca
{
    partial class AdministradorForm
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
            this.binenvenido_Lbl = new System.Windows.Forms.Label();
            this.consulta_Btn = new System.Windows.Forms.Button();
            this.alta_Btn = new System.Windows.Forms.Button();
            this.baja_Btn = new System.Windows.Forms.Button();
            this.cambios_Btn = new System.Windows.Forms.Button();
            this.regresar_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // binenvenido_Lbl
            // 
            this.binenvenido_Lbl.AutoSize = true;
            this.binenvenido_Lbl.Location = new System.Drawing.Point(98, 39);
            this.binenvenido_Lbl.Name = "binenvenido_Lbl";
            this.binenvenido_Lbl.Size = new System.Drawing.Size(204, 17);
            this.binenvenido_Lbl.TabIndex = 0;
            this.binenvenido_Lbl.Text = "Bienvenido, que desa realizar?";
            // 
            // consulta_Btn
            // 
            this.consulta_Btn.Location = new System.Drawing.Point(51, 95);
            this.consulta_Btn.Name = "consulta_Btn";
            this.consulta_Btn.Size = new System.Drawing.Size(107, 53);
            this.consulta_Btn.TabIndex = 1;
            this.consulta_Btn.Text = "Consultar";
            this.consulta_Btn.UseVisualStyleBackColor = true;
            this.consulta_Btn.Click += new System.EventHandler(this.consulta_Btn_Click);
            // 
            // alta_Btn
            // 
            this.alta_Btn.Location = new System.Drawing.Point(51, 190);
            this.alta_Btn.Name = "alta_Btn";
            this.alta_Btn.Size = new System.Drawing.Size(107, 53);
            this.alta_Btn.TabIndex = 2;
            this.alta_Btn.Text = "Dar de alta";
            this.alta_Btn.UseVisualStyleBackColor = true;
            this.alta_Btn.Click += new System.EventHandler(this.alta_Btn_Click);
            // 
            // baja_Btn
            // 
            this.baja_Btn.Location = new System.Drawing.Point(226, 190);
            this.baja_Btn.Name = "baja_Btn";
            this.baja_Btn.Size = new System.Drawing.Size(107, 53);
            this.baja_Btn.TabIndex = 3;
            this.baja_Btn.Text = "Dar de baja";
            this.baja_Btn.UseVisualStyleBackColor = true;
            this.baja_Btn.Click += new System.EventHandler(this.baja_Btn_Click);
            // 
            // cambios_Btn
            // 
            this.cambios_Btn.Location = new System.Drawing.Point(226, 95);
            this.cambios_Btn.Name = "cambios_Btn";
            this.cambios_Btn.Size = new System.Drawing.Size(107, 53);
            this.cambios_Btn.TabIndex = 4;
            this.cambios_Btn.Text = "Cambios";
            this.cambios_Btn.UseVisualStyleBackColor = true;
            this.cambios_Btn.Click += new System.EventHandler(this.cambios_Btn_Click);
            // 
            // regresar_Btn
            // 
            this.regresar_Btn.Location = new System.Drawing.Point(162, 287);
            this.regresar_Btn.Name = "regresar_Btn";
            this.regresar_Btn.Size = new System.Drawing.Size(82, 37);
            this.regresar_Btn.TabIndex = 5;
            this.regresar_Btn.Text = "Regresar";
            this.regresar_Btn.UseVisualStyleBackColor = true;
            this.regresar_Btn.Click += new System.EventHandler(this.regresar_Btn_Click);
            // 
            // AdministradorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 336);
            this.Controls.Add(this.regresar_Btn);
            this.Controls.Add(this.cambios_Btn);
            this.Controls.Add(this.baja_Btn);
            this.Controls.Add(this.alta_Btn);
            this.Controls.Add(this.consulta_Btn);
            this.Controls.Add(this.binenvenido_Lbl);
            this.Name = "AdministradorForm";
            this.Text = "AdministradorForm";
            this.Load += new System.EventHandler(this.AdministradorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label binenvenido_Lbl;
        private System.Windows.Forms.Button consulta_Btn;
        private System.Windows.Forms.Button alta_Btn;
        private System.Windows.Forms.Button baja_Btn;
        private System.Windows.Forms.Button cambios_Btn;
        private System.Windows.Forms.Button regresar_Btn;
    }
}