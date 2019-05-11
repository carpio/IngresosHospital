namespace IngresosHospital
{
    partial class antiguedadMedico
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
            this.dgvAntiguedadMedico = new System.Windows.Forms.DataGridView();
            this.textBoxFechaFinal = new System.Windows.Forms.TextBox();
            this.textBoxFechaInicial = new System.Windows.Forms.TextBox();
            this.labelFechaFinal = new System.Windows.Forms.Label();
            this.labelFechaInicial = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAntiguedadMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAntiguedadMedico
            // 
            this.dgvAntiguedadMedico.AllowUserToAddRows = false;
            this.dgvAntiguedadMedico.AllowUserToDeleteRows = false;
            this.dgvAntiguedadMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAntiguedadMedico.Location = new System.Drawing.Point(150, 160);
            this.dgvAntiguedadMedico.Name = "dgvAntiguedadMedico";
            this.dgvAntiguedadMedico.ReadOnly = true;
            this.dgvAntiguedadMedico.Size = new System.Drawing.Size(504, 241);
            this.dgvAntiguedadMedico.TabIndex = 9;
            // 
            // textBoxFechaFinal
            // 
            this.textBoxFechaFinal.Location = new System.Drawing.Point(276, 105);
            this.textBoxFechaFinal.Name = "textBoxFechaFinal";
            this.textBoxFechaFinal.Size = new System.Drawing.Size(192, 20);
            this.textBoxFechaFinal.TabIndex = 8;
            // 
            // textBoxFechaInicial
            // 
            this.textBoxFechaInicial.Location = new System.Drawing.Point(276, 50);
            this.textBoxFechaInicial.Name = "textBoxFechaInicial";
            this.textBoxFechaInicial.Size = new System.Drawing.Size(192, 20);
            this.textBoxFechaInicial.TabIndex = 7;
            // 
            // labelFechaFinal
            // 
            this.labelFechaFinal.AutoSize = true;
            this.labelFechaFinal.Location = new System.Drawing.Point(147, 108);
            this.labelFechaFinal.Name = "labelFechaFinal";
            this.labelFechaFinal.Size = new System.Drawing.Size(90, 13);
            this.labelFechaFinal.TabIndex = 6;
            this.labelFechaFinal.Text = "Añade fecha final";
            // 
            // labelFechaInicial
            // 
            this.labelFechaInicial.AutoSize = true;
            this.labelFechaInicial.Location = new System.Drawing.Point(147, 53);
            this.labelFechaInicial.Name = "labelFechaInicial";
            this.labelFechaInicial.Size = new System.Drawing.Size(97, 13);
            this.labelFechaInicial.TabIndex = 5;
            this.labelFechaInicial.Text = "Añade fecha inicial";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(579, 108);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 10;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // antiguedadMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.dgvAntiguedadMedico);
            this.Controls.Add(this.textBoxFechaFinal);
            this.Controls.Add(this.textBoxFechaInicial);
            this.Controls.Add(this.labelFechaFinal);
            this.Controls.Add(this.labelFechaInicial);
            this.Name = "antiguedadMedico";
            this.Text = "antiguedadMedico";
            this.Load += new System.EventHandler(this.antiguedadMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAntiguedadMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAntiguedadMedico;
        private System.Windows.Forms.TextBox textBoxFechaFinal;
        private System.Windows.Forms.TextBox textBoxFechaInicial;
        private System.Windows.Forms.Label labelFechaFinal;
        private System.Windows.Forms.Label labelFechaInicial;
        private System.Windows.Forms.Button buttonAceptar;
    }
}