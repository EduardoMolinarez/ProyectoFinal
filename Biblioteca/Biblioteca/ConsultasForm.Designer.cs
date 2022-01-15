
namespace Biblioteca
{
    partial class ConsultasForm
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
            this.txtMostrar_Lbl = new System.Windows.Forms.Label();
            this.empleado_Btn = new System.Windows.Forms.Button();
            this.clientes_Btn = new System.Windows.Forms.Button();
            this.libros_Btn = new System.Windows.Forms.Button();
            this.prestamos_Btn = new System.Windows.Forms.Button();
            this.regresar_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMostrar_Lbl
            // 
            this.txtMostrar_Lbl.AutoSize = true;
            this.txtMostrar_Lbl.Location = new System.Drawing.Point(155, 40);
            this.txtMostrar_Lbl.Name = "txtMostrar_Lbl";
            this.txtMostrar_Lbl.Size = new System.Drawing.Size(183, 17);
            this.txtMostrar_Lbl.TabIndex = 0;
            this.txtMostrar_Lbl.Text = "Que tabla desea consultar?";
            // 
            // empleado_Btn
            // 
            this.empleado_Btn.Location = new System.Drawing.Point(98, 103);
            this.empleado_Btn.Name = "empleado_Btn";
            this.empleado_Btn.Size = new System.Drawing.Size(92, 43);
            this.empleado_Btn.TabIndex = 1;
            this.empleado_Btn.Text = "Empleados";
            this.empleado_Btn.UseVisualStyleBackColor = true;
            this.empleado_Btn.Click += new System.EventHandler(this.empleado_Btn_Click);
            // 
            // clientes_Btn
            // 
            this.clientes_Btn.Location = new System.Drawing.Point(295, 103);
            this.clientes_Btn.Name = "clientes_Btn";
            this.clientes_Btn.Size = new System.Drawing.Size(93, 43);
            this.clientes_Btn.TabIndex = 2;
            this.clientes_Btn.Text = "Clientes";
            this.clientes_Btn.UseVisualStyleBackColor = true;
            this.clientes_Btn.Click += new System.EventHandler(this.clientes_Btn_Click);
            // 
            // libros_Btn
            // 
            this.libros_Btn.Location = new System.Drawing.Point(96, 208);
            this.libros_Btn.Name = "libros_Btn";
            this.libros_Btn.Size = new System.Drawing.Size(94, 43);
            this.libros_Btn.TabIndex = 3;
            this.libros_Btn.Text = "Libros";
            this.libros_Btn.UseVisualStyleBackColor = true;
            this.libros_Btn.Click += new System.EventHandler(this.libros_Btn_Click);
            // 
            // prestamos_Btn
            // 
            this.prestamos_Btn.Location = new System.Drawing.Point(295, 208);
            this.prestamos_Btn.Name = "prestamos_Btn";
            this.prestamos_Btn.Size = new System.Drawing.Size(94, 43);
            this.prestamos_Btn.TabIndex = 4;
            this.prestamos_Btn.Text = "Prestamos";
            this.prestamos_Btn.UseVisualStyleBackColor = true;
            this.prestamos_Btn.Click += new System.EventHandler(this.prestamos_Btn_Click);
            // 
            // regresar_Btn
            // 
            this.regresar_Btn.Location = new System.Drawing.Point(207, 301);
            this.regresar_Btn.Name = "regresar_Btn";
            this.regresar_Btn.Size = new System.Drawing.Size(97, 32);
            this.regresar_Btn.TabIndex = 5;
            this.regresar_Btn.Text = "Regresar";
            this.regresar_Btn.UseVisualStyleBackColor = true;
            this.regresar_Btn.Click += new System.EventHandler(this.regresar_Btn_Click);
            // 
            // ConsultasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 345);
            this.Controls.Add(this.regresar_Btn);
            this.Controls.Add(this.prestamos_Btn);
            this.Controls.Add(this.libros_Btn);
            this.Controls.Add(this.clientes_Btn);
            this.Controls.Add(this.empleado_Btn);
            this.Controls.Add(this.txtMostrar_Lbl);
            this.Name = "ConsultasForm";
            this.Text = "Consultas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtMostrar_Lbl;
        private System.Windows.Forms.Button empleado_Btn;
        private System.Windows.Forms.Button clientes_Btn;
        private System.Windows.Forms.Button libros_Btn;
        private System.Windows.Forms.Button prestamos_Btn;
        private System.Windows.Forms.Button regresar_Btn;
    }
}