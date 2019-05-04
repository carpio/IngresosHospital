namespace IngresosHospital
{
    partial class AgregarMedico
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
            this.botonGuardarMedico = new System.Windows.Forms.Button();
            this.cajaTextoApellidoMedico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cajaTextoNombreMedico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonMenuPrincipal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonGuardarMedico
            // 
            this.botonGuardarMedico.Location = new System.Drawing.Point(383, 282);
            this.botonGuardarMedico.Name = "botonGuardarMedico";
            this.botonGuardarMedico.Size = new System.Drawing.Size(75, 23);
            this.botonGuardarMedico.TabIndex = 10;
            this.botonGuardarMedico.Text = "Guardar";
            this.botonGuardarMedico.UseVisualStyleBackColor = true;
            this.botonGuardarMedico.Click += new System.EventHandler(this.botonGuardarMedico_Click);
            // 
            // cajaTextoApellidoMedico
            // 
            this.cajaTextoApellidoMedico.Location = new System.Drawing.Point(383, 208);
            this.cajaTextoApellidoMedico.Name = "cajaTextoApellidoMedico";
            this.cajaTextoApellidoMedico.Size = new System.Drawing.Size(100, 20);
            this.cajaTextoApellidoMedico.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellidos";
            // 
            // cajaTextoNombreMedico
            // 
            this.cajaTextoNombreMedico.Location = new System.Drawing.Point(383, 146);
            this.cajaTextoNombreMedico.Name = "cajaTextoNombreMedico";
            this.cajaTextoNombreMedico.Size = new System.Drawing.Size(100, 20);
            this.cajaTextoNombreMedico.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // botonMenuPrincipal
            // 
            this.botonMenuPrincipal.Location = new System.Drawing.Point(12, 415);
            this.botonMenuPrincipal.Name = "botonMenuPrincipal";
            this.botonMenuPrincipal.Size = new System.Drawing.Size(164, 23);
            this.botonMenuPrincipal.TabIndex = 11;
            this.botonMenuPrincipal.Text = "Menú Principal";
            this.botonMenuPrincipal.UseVisualStyleBackColor = true;
            this.botonMenuPrincipal.Click += new System.EventHandler(this.botonMenuPrincipal_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Actualizar Médico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgregarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botonMenuPrincipal);
            this.Controls.Add(this.botonGuardarMedico);
            this.Controls.Add(this.cajaTextoApellidoMedico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cajaTextoNombreMedico);
            this.Controls.Add(this.label1);
            this.Name = "AgregarMedico";
            this.Text = "AgregarMedico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonGuardarMedico;
        private System.Windows.Forms.TextBox cajaTextoApellidoMedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cajaTextoNombreMedico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonMenuPrincipal;
        private System.Windows.Forms.Button button1;
    }
}