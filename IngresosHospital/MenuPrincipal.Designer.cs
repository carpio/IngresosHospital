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
            this.buttonAntiguedadPaciente = new System.Windows.Forms.Button();
            this.buttonAntiguedadMedico = new System.Windows.Forms.Button();
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
            this.botonIngresosPaciente.Click += new System.EventHandler(this.botonIngresosPaciente_Click);
            // 
            // botonIngresosMedicos
            // 
            this.botonIngresosMedicos.Location = new System.Drawing.Point(375, 238);
            this.botonIngresosMedicos.Name = "botonIngresosMedicos";
            this.botonIngresosMedicos.Size = new System.Drawing.Size(207, 139);
            this.botonIngresosMedicos.TabIndex = 3;
            this.botonIngresosMedicos.Text = "Reporte Ingresos Médicos";
            this.botonIngresosMedicos.UseVisualStyleBackColor = true;
            this.botonIngresosMedicos.Click += new System.EventHandler(this.botonIngresosMedicos_Click);
            // 
            // buttonAntiguedadPaciente
            // 
            this.buttonAntiguedadPaciente.Location = new System.Drawing.Point(67, 420);
            this.buttonAntiguedadPaciente.Name = "buttonAntiguedadPaciente";
            this.buttonAntiguedadPaciente.Size = new System.Drawing.Size(207, 139);
            this.buttonAntiguedadPaciente.TabIndex = 4;
            this.buttonAntiguedadPaciente.Text = "Antiguedad del paciente";
            this.buttonAntiguedadPaciente.UseVisualStyleBackColor = true;
            this.buttonAntiguedadPaciente.Click += new System.EventHandler(this.buttonAntiguedadPaciente_Click);
            // 
            // buttonAntiguedadMedico
            // 
            this.buttonAntiguedadMedico.Location = new System.Drawing.Point(375, 420);
            this.buttonAntiguedadMedico.Name = "buttonAntiguedadMedico";
            this.buttonAntiguedadMedico.Size = new System.Drawing.Size(207, 139);
            this.buttonAntiguedadMedico.TabIndex = 5;
            this.buttonAntiguedadMedico.Text = "Antiguedad del medico";
            this.buttonAntiguedadMedico.UseVisualStyleBackColor = true;
            this.buttonAntiguedadMedico.Click += new System.EventHandler(this.buttonAntiguedadMedico_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 571);
            this.Controls.Add(this.buttonAntiguedadMedico);
            this.Controls.Add(this.buttonAntiguedadPaciente);
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
        private System.Windows.Forms.Button buttonAntiguedadPaciente;
        private System.Windows.Forms.Button buttonAntiguedadMedico;
    }
}