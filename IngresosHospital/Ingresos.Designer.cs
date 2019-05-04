namespace IngresosHospital
{
    partial class Ingresos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPaciente = new System.Windows.Forms.ComboBox();
            this.cbMedico = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cajaTextoHabitacion = new System.Windows.Forms.TextBox();
            this.botonRegistrarIngreso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paciente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Médico";
            // 
            // cbPaciente
            // 
            this.cbPaciente.FormattingEnabled = true;
            this.cbPaciente.Location = new System.Drawing.Point(234, 55);
            this.cbPaciente.Name = "cbPaciente";
            this.cbPaciente.Size = new System.Drawing.Size(256, 21);
            this.cbPaciente.TabIndex = 2;
            // 
            // cbMedico
            // 
            this.cbMedico.FormattingEnabled = true;
            this.cbMedico.Location = new System.Drawing.Point(234, 106);
            this.cbMedico.Name = "cbMedico";
            this.cbMedico.Size = new System.Drawing.Size(256, 21);
            this.cbMedico.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Habitación";
            // 
            // cajaTextoHabitacion
            // 
            this.cajaTextoHabitacion.Location = new System.Drawing.Point(234, 159);
            this.cajaTextoHabitacion.Name = "cajaTextoHabitacion";
            this.cajaTextoHabitacion.Size = new System.Drawing.Size(100, 20);
            this.cajaTextoHabitacion.TabIndex = 5;
            // 
            // botonRegistrarIngreso
            // 
            this.botonRegistrarIngreso.Location = new System.Drawing.Point(380, 220);
            this.botonRegistrarIngreso.Name = "botonRegistrarIngreso";
            this.botonRegistrarIngreso.Size = new System.Drawing.Size(173, 23);
            this.botonRegistrarIngreso.TabIndex = 6;
            this.botonRegistrarIngreso.Text = "Registrar ingreso";
            this.botonRegistrarIngreso.UseVisualStyleBackColor = true;
            this.botonRegistrarIngreso.Click += new System.EventHandler(this.botonRegistrarIngreso_Click);
            // 
            // Ingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonRegistrarIngreso);
            this.Controls.Add(this.cajaTextoHabitacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMedico);
            this.Controls.Add(this.cbPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ingresos";
            this.Text = "Ingresos";
            this.Load += new System.EventHandler(this.Ingresos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPaciente;
        private System.Windows.Forms.ComboBox cbMedico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cajaTextoHabitacion;
        private System.Windows.Forms.Button botonRegistrarIngreso;
    }
}