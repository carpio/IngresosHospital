namespace IngresosHospital
{
    partial class AgregarPaciente
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cajaTextoNombrePaciente = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cajaTextoApellidoPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botonGuardarMedico = new System.Windows.Forms.Button();
            this.botonNuevoIngreso = new System.Windows.Forms.Button();
            this.botonMenuPrincipal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // cajaTextoNombrePaciente
            // 
            this.cajaTextoNombrePaciente.Location = new System.Drawing.Point(356, 81);
            this.cajaTextoNombrePaciente.Name = "cajaTextoNombrePaciente";
            this.cajaTextoNombrePaciente.Size = new System.Drawing.Size(100, 20);
            this.cajaTextoNombrePaciente.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cajaTextoApellidoPaciente
            // 
            this.cajaTextoApellidoPaciente.Location = new System.Drawing.Point(356, 143);
            this.cajaTextoApellidoPaciente.Name = "cajaTextoApellidoPaciente";
            this.cajaTextoApellidoPaciente.Size = new System.Drawing.Size(100, 20);
            this.cajaTextoApellidoPaciente.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellidos";
            // 
            // botonGuardarMedico
            // 
            this.botonGuardarMedico.Location = new System.Drawing.Point(356, 217);
            this.botonGuardarMedico.Name = "botonGuardarMedico";
            this.botonGuardarMedico.Size = new System.Drawing.Size(75, 23);
            this.botonGuardarMedico.TabIndex = 5;
            this.botonGuardarMedico.Text = "Guardar";
            this.botonGuardarMedico.UseVisualStyleBackColor = true;
            this.botonGuardarMedico.Click += new System.EventHandler(this.botonGuardarMedico_Click);
            // 
            // botonNuevoIngreso
            // 
            this.botonNuevoIngreso.Location = new System.Drawing.Point(356, 291);
            this.botonNuevoIngreso.Name = "botonNuevoIngreso";
            this.botonNuevoIngreso.Size = new System.Drawing.Size(164, 23);
            this.botonNuevoIngreso.TabIndex = 6;
            this.botonNuevoIngreso.Text = "Nuevo Ingreso";
            this.botonNuevoIngreso.UseVisualStyleBackColor = true;
            this.botonNuevoIngreso.Click += new System.EventHandler(this.botonNuevoIngreso_Click);
            // 
            // botonMenuPrincipal
            // 
            this.botonMenuPrincipal.Location = new System.Drawing.Point(12, 415);
            this.botonMenuPrincipal.Name = "botonMenuPrincipal";
            this.botonMenuPrincipal.Size = new System.Drawing.Size(164, 23);
            this.botonMenuPrincipal.TabIndex = 7;
            this.botonMenuPrincipal.Text = "Menú Principal";
            this.botonMenuPrincipal.UseVisualStyleBackColor = true;
            this.botonMenuPrincipal.Click += new System.EventHandler(this.botonMenuPrincipal_Click);
            // 
            // AgregarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonMenuPrincipal);
            this.Controls.Add(this.botonNuevoIngreso);
            this.Controls.Add(this.botonGuardarMedico);
            this.Controls.Add(this.cajaTextoApellidoPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cajaTextoNombrePaciente);
            this.Controls.Add(this.label1);
            this.Name = "AgregarPaciente";
            this.Text = "Agregar Paciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cajaTextoNombrePaciente;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox cajaTextoApellidoPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonGuardarMedico;
        private System.Windows.Forms.Button botonNuevoIngreso;
        private System.Windows.Forms.Button botonMenuPrincipal;
    }
}