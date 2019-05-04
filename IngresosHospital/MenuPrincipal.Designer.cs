namespace IngresosHospital
{
    partial class MenuPrincipal
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
            this.botonAgregarMedico = new System.Windows.Forms.Button();
            this.botonAgregarPaciente = new System.Windows.Forms.Button();
            this.botonIngresosPaciente = new System.Windows.Forms.Button();
            this.botonIngresosMedicos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonAgregarMedico
            // 
            this.botonAgregarMedico.Location = new System.Drawing.Point(67, 48);
            this.botonAgregarMedico.Name = "botonAgregarMedico";
            this.botonAgregarMedico.Size = new System.Drawing.Size(207, 139);
            this.botonAgregarMedico.TabIndex = 0;
            this.botonAgregarMedico.Text = "Agregar Médico";
            this.botonAgregarMedico.UseVisualStyleBackColor = true;
            this.botonAgregarMedico.Click += new System.EventHandler(this.botonAgregarMedico_Click);
            // 
            // botonAgregarPaciente
            // 
            this.botonAgregarPaciente.Location = new System.Drawing.Point(375, 48);
            this.botonAgregarPaciente.Name = "botonAgregarPaciente";
            this.botonAgregarPaciente.Size = new System.Drawing.Size(207, 139);
            this.botonAgregarPaciente.TabIndex = 1;
            this.botonAgregarPaciente.Text = "Agregar Paciente";
            this.botonAgregarPaciente.UseVisualStyleBackColor = true;
            this.botonAgregarPaciente.Click += new System.EventHandler(this.botonAgregarPaciente_Click);
            // 
            // botonIngresosPaciente
            // 
            this.botonIngresosPaciente.Location = new System.Drawing.Point(67, 238);
            this.botonIngresosPaciente.Name = "botonIngresosPaciente";
            this.botonIngresosPaciente.Size = new System.Drawing.Size(207, 139);
            this.botonIngresosPaciente.TabIndex = 2;
            this.botonIngresosPaciente.Text = "Reporte Ingresos Paciente";
            this.botonIngresosPaciente.UseVisualStyleBackColor = true;
            // 
            // botonIngresosMedicos
            // 
            this.botonIngresosMedicos.Location = new System.Drawing.Point(375, 238);
            this.botonIngresosMedicos.Name = "botonIngresosMedicos";
            this.botonIngresosMedicos.Size = new System.Drawing.Size(207, 139);
            this.botonIngresosMedicos.TabIndex = 3;
            this.botonIngresosMedicos.Text = "Reporte Ingresos Médicos";
            this.botonIngresosMedicos.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.botonIngresosMedicos);
            this.Controls.Add(this.botonIngresosPaciente);
            this.Controls.Add(this.botonAgregarPaciente);
            this.Controls.Add(this.botonAgregarMedico);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonAgregarMedico;
        private System.Windows.Forms.Button botonAgregarPaciente;
        private System.Windows.Forms.Button botonIngresosPaciente;
        private System.Windows.Forms.Button botonIngresosMedicos;
    }
}