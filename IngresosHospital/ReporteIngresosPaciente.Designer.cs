﻿namespace IngresosHospital
{
    partial class ReporteIngresosPaciente
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
            this.dgvIngresosPacientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresosPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIngresosPacientes
            // 
            this.dgvIngresosPacientes.AllowUserToAddRows = false;
            this.dgvIngresosPacientes.AllowUserToDeleteRows = false;
            this.dgvIngresosPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresosPacientes.Location = new System.Drawing.Point(33, 54);
            this.dgvIngresosPacientes.Name = "dgvIngresosPacientes";
            this.dgvIngresosPacientes.ReadOnly = true;
            this.dgvIngresosPacientes.Size = new System.Drawing.Size(734, 384);
            this.dgvIngresosPacientes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Histórico de ingresos de pacientes";
            // 
            // ReporteIngresosPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIngresosPacientes);
            this.Name = "ReporteIngresosPaciente";
            this.Text = "Histórico Ingresos de Pacientes";
            this.Load += new System.EventHandler(this.ReporteIngresosPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresosPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIngresosPacientes;
        private System.Windows.Forms.Label label1;
    }
}