namespace IngresosHospital
{
    partial class ReporteIngresosMedicos
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
            this.dgvIngresosMedicos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresosMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Histórico de ingresos por médico";
            // 
            // dgvIngresosMedicos
            // 
            this.dgvIngresosMedicos.AllowUserToAddRows = false;
            this.dgvIngresosMedicos.AllowUserToDeleteRows = false;
            this.dgvIngresosMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresosMedicos.Location = new System.Drawing.Point(33, 51);
            this.dgvIngresosMedicos.Name = "dgvIngresosMedicos";
            this.dgvIngresosMedicos.ReadOnly = true;
            this.dgvIngresosMedicos.Size = new System.Drawing.Size(734, 384);
            this.dgvIngresosMedicos.TabIndex = 2;
            // 
            // ReporteIngresosMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIngresosMedicos);
            this.Name = "ReporteIngresosMedicos";
            this.Text = "ReporteIngresosMedicos";
            this.Load += new System.EventHandler(this.ReporteIngresosMedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresosMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvIngresosMedicos;
    }
}