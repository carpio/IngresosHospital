namespace IngresosHospital
{
    partial class antiguedadPaciente
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
            this.labelFechaInicial = new System.Windows.Forms.Label();
            this.labelFechaFinal = new System.Windows.Forms.Label();
            this.textBoxFechaInicial = new System.Windows.Forms.TextBox();
            this.textBoxFechaFinal = new System.Windows.Forms.TextBox();
            this.dgvAntiguedadPaciente = new System.Windows.Forms.DataGridView();
            this.buttonAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAntiguedadPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFechaInicial
            // 
            this.labelFechaInicial.AutoSize = true;
            this.labelFechaInicial.Location = new System.Drawing.Point(76, 56);
            this.labelFechaInicial.Name = "labelFechaInicial";
            this.labelFechaInicial.Size = new System.Drawing.Size(97, 13);
            this.labelFechaInicial.TabIndex = 0;
            this.labelFechaInicial.Text = "Añade fecha inicial";
            // 
            // labelFechaFinal
            // 
            this.labelFechaFinal.AutoSize = true;
            this.labelFechaFinal.Location = new System.Drawing.Point(76, 111);
            this.labelFechaFinal.Name = "labelFechaFinal";
            this.labelFechaFinal.Size = new System.Drawing.Size(90, 13);
            this.labelFechaFinal.TabIndex = 1;
            this.labelFechaFinal.Text = "Añade fecha final";
            // 
            // textBoxFechaInicial
            // 
            this.textBoxFechaInicial.Location = new System.Drawing.Point(205, 53);
            this.textBoxFechaInicial.Name = "textBoxFechaInicial";
            this.textBoxFechaInicial.Size = new System.Drawing.Size(192, 20);
            this.textBoxFechaInicial.TabIndex = 2;
            // 
            // textBoxFechaFinal
            // 
            this.textBoxFechaFinal.Location = new System.Drawing.Point(205, 108);
            this.textBoxFechaFinal.Name = "textBoxFechaFinal";
            this.textBoxFechaFinal.Size = new System.Drawing.Size(192, 20);
            this.textBoxFechaFinal.TabIndex = 3;
            // 
            // dgvAntiguedadPaciente
            // 
            this.dgvAntiguedadPaciente.AllowUserToAddRows = false;
            this.dgvAntiguedadPaciente.AllowUserToDeleteRows = false;
            this.dgvAntiguedadPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAntiguedadPaciente.Location = new System.Drawing.Point(79, 163);
            this.dgvAntiguedadPaciente.Name = "dgvAntiguedadPaciente";
            this.dgvAntiguedadPaciente.ReadOnly = true;
            this.dgvAntiguedadPaciente.Size = new System.Drawing.Size(504, 241);
            this.dgvAntiguedadPaciente.TabIndex = 4;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(508, 106);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 11;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // antiguedadPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.dgvAntiguedadPaciente);
            this.Controls.Add(this.textBoxFechaFinal);
            this.Controls.Add(this.textBoxFechaInicial);
            this.Controls.Add(this.labelFechaFinal);
            this.Controls.Add(this.labelFechaInicial);
            this.Name = "antiguedadPaciente";
            this.Text = "antiguedadPaciente";
            this.Load += new System.EventHandler(this.antiguedadPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAntiguedadPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFechaInicial;
        private System.Windows.Forms.Label labelFechaFinal;
        private System.Windows.Forms.TextBox textBoxFechaInicial;
        private System.Windows.Forms.TextBox textBoxFechaFinal;
        private System.Windows.Forms.DataGridView dgvAntiguedadPaciente;
        private System.Windows.Forms.Button buttonAceptar;
    }
}