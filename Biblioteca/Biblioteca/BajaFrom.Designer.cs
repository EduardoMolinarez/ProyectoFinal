
namespace Biblioteca
{
    partial class BajaFrom
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
            this.iniBaja_Lbl = new System.Windows.Forms.Label();
            this.empleado_RBtn = new System.Windows.Forms.RadioButton();
            this.cliente_RBtn = new System.Windows.Forms.RadioButton();
            this.libro_RBtn = new System.Windows.Forms.RadioButton();
            this.clave_Lbl = new System.Windows.Forms.Label();
            this.clave_Tbx = new System.Windows.Forms.TextBox();
            this.aplicar_Btn = new System.Windows.Forms.Button();
            this.regresar_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // iniBaja_Lbl
            // 
            this.iniBaja_Lbl.AutoSize = true;
            this.iniBaja_Lbl.Location = new System.Drawing.Point(50, 42);
            this.iniBaja_Lbl.Name = "iniBaja_Lbl";
            this.iniBaja_Lbl.Size = new System.Drawing.Size(244, 17);
            this.iniBaja_Lbl.TabIndex = 0;
            this.iniBaja_Lbl.Text = "Selecciona una tabla para da de baja";
            // 
            // empleado_RBtn
            // 
            this.empleado_RBtn.AutoSize = true;
            this.empleado_RBtn.Location = new System.Drawing.Point(53, 92);
            this.empleado_RBtn.Name = "empleado_RBtn";
            this.empleado_RBtn.Size = new System.Drawing.Size(92, 21);
            this.empleado_RBtn.TabIndex = 1;
            this.empleado_RBtn.TabStop = true;
            this.empleado_RBtn.Text = "Empleado";
            this.empleado_RBtn.UseVisualStyleBackColor = true;
            // 
            // cliente_RBtn
            // 
            this.cliente_RBtn.AutoSize = true;
            this.cliente_RBtn.Location = new System.Drawing.Point(53, 140);
            this.cliente_RBtn.Name = "cliente_RBtn";
            this.cliente_RBtn.Size = new System.Drawing.Size(72, 21);
            this.cliente_RBtn.TabIndex = 2;
            this.cliente_RBtn.TabStop = true;
            this.cliente_RBtn.Text = "Cliente";
            this.cliente_RBtn.UseVisualStyleBackColor = true;
            // 
            // libro_RBtn
            // 
            this.libro_RBtn.AutoSize = true;
            this.libro_RBtn.Location = new System.Drawing.Point(53, 189);
            this.libro_RBtn.Name = "libro_RBtn";
            this.libro_RBtn.Size = new System.Drawing.Size(61, 21);
            this.libro_RBtn.TabIndex = 3;
            this.libro_RBtn.TabStop = true;
            this.libro_RBtn.Text = "Libro";
            this.libro_RBtn.UseVisualStyleBackColor = true;
            // 
            // clave_Lbl
            // 
            this.clave_Lbl.AutoSize = true;
            this.clave_Lbl.Location = new System.Drawing.Point(193, 94);
            this.clave_Lbl.Name = "clave_Lbl";
            this.clave_Lbl.Size = new System.Drawing.Size(81, 17);
            this.clave_Lbl.TabIndex = 4;
            this.clave_Lbl.Text = "Clave unica";
            // 
            // clave_Tbx
            // 
            this.clave_Tbx.Location = new System.Drawing.Point(196, 114);
            this.clave_Tbx.Name = "clave_Tbx";
            this.clave_Tbx.Size = new System.Drawing.Size(148, 22);
            this.clave_Tbx.TabIndex = 5;
            // 
            // aplicar_Btn
            // 
            this.aplicar_Btn.Location = new System.Drawing.Point(219, 142);
            this.aplicar_Btn.Name = "aplicar_Btn";
            this.aplicar_Btn.Size = new System.Drawing.Size(98, 37);
            this.aplicar_Btn.TabIndex = 6;
            this.aplicar_Btn.Text = "Aplicar";
            this.aplicar_Btn.UseVisualStyleBackColor = true;
            // 
            // regresar_Btn
            // 
            this.regresar_Btn.Location = new System.Drawing.Point(310, 242);
            this.regresar_Btn.Name = "regresar_Btn";
            this.regresar_Btn.Size = new System.Drawing.Size(88, 31);
            this.regresar_Btn.TabIndex = 7;
            this.regresar_Btn.Text = "Regreso";
            this.regresar_Btn.UseVisualStyleBackColor = true;
            this.regresar_Btn.Click += new System.EventHandler(this.regresar_Btn_Click);
            // 
            // BajaFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 285);
            this.Controls.Add(this.regresar_Btn);
            this.Controls.Add(this.aplicar_Btn);
            this.Controls.Add(this.clave_Tbx);
            this.Controls.Add(this.clave_Lbl);
            this.Controls.Add(this.libro_RBtn);
            this.Controls.Add(this.cliente_RBtn);
            this.Controls.Add(this.empleado_RBtn);
            this.Controls.Add(this.iniBaja_Lbl);
            this.Name = "BajaFrom";
            this.Text = "Baja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label iniBaja_Lbl;
        private System.Windows.Forms.RadioButton empleado_RBtn;
        private System.Windows.Forms.RadioButton cliente_RBtn;
        private System.Windows.Forms.RadioButton libro_RBtn;
        private System.Windows.Forms.Label clave_Lbl;
        private System.Windows.Forms.TextBox clave_Tbx;
        private System.Windows.Forms.Button aplicar_Btn;
        private System.Windows.Forms.Button regresar_Btn;
    }
}