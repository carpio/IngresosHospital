namespace IngresosHospital
{
    partial class BuscarMedico
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
            this.cajaTextoBusqueda = new System.Windows.Forms.TextBox();
            this.botonBuscarMedico = new System.Windows.Forms.Button();
            this.datagridConcordanciasMedico = new System.Windows.Forms.DataGridView();
            this.botonEditarMedico = new System.Windows.Forms.Button();
            this.botonEliminarMedico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridConcordanciasMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por Nombre, Apellidos o ID";
            // 
            // cajaTextoBusqueda
            // 
            this.cajaTextoBusqueda.Location = new System.Drawing.Point(264, 43);
            this.cajaTextoBusqueda.Name = "cajaTextoBusqueda";
            this.cajaTextoBusqueda.Size = new System.Drawing.Size(291, 20);
            this.cajaTextoBusqueda.TabIndex = 1;
            // 
            // botonBuscarMedico
            // 
            this.botonBuscarMedico.Location = new System.Drawing.Point(571, 43);
            this.botonBuscarMedico.Name = "botonBuscarMedico";
            this.botonBuscarMedico.Size = new System.Drawing.Size(75, 23);
            this.botonBuscarMedico.TabIndex = 2;
            this.botonBuscarMedico.Text = "Buscar";
            this.botonBuscarMedico.UseVisualStyleBackColor = true;
            this.botonBuscarMedico.Click += new System.EventHandler(this.botonBuscarMedico_Click);
            // 
            // datagridConcordanciasMedico
            // 
            this.datagridConcordanciasMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridConcordanciasMedico.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.datagridConcordanciasMedico.Location = new System.Drawing.Point(51, 107);
            this.datagridConcordanciasMedico.Name = "datagridConcordanciasMedico";
            this.datagridConcordanciasMedico.Size = new System.Drawing.Size(694, 310);
            this.datagridConcordanciasMedico.TabIndex = 3;
            // 
            // botonEditarMedico
            // 
            this.botonEditarMedico.Location = new System.Drawing.Point(489, 449);
            this.botonEditarMedico.Name = "botonEditarMedico";
            this.botonEditarMedico.Size = new System.Drawing.Size(118, 23);
            this.botonEditarMedico.TabIndex = 4;
            this.botonEditarMedico.Text = "Editar Médico";
            this.botonEditarMedico.UseVisualStyleBackColor = true;
            this.botonEditarMedico.Click += new System.EventHandler(this.botonEditarMedico_Click);
            // 
            // botonEliminarMedico
            // 
            this.botonEliminarMedico.Location = new System.Drawing.Point(627, 449);
            this.botonEliminarMedico.Name = "botonEliminarMedico";
            this.botonEliminarMedico.Size = new System.Drawing.Size(118, 23);
            this.botonEliminarMedico.TabIndex = 5;
            this.botonEliminarMedico.Text = "Eliminar Médico";
            this.botonEliminarMedico.UseVisualStyleBackColor = true;
            this.botonEliminarMedico.Click += new System.EventHandler(this.botonEliminarMedico_Click);
            // 
            // BuscarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.botonEliminarMedico);
            this.Controls.Add(this.botonEditarMedico);
            this.Controls.Add(this.datagridConcordanciasMedico);
            this.Controls.Add(this.botonBuscarMedico);
            this.Controls.Add(this.cajaTextoBusqueda);
            this.Controls.Add(this.label1);
            this.Name = "BuscarMedico";
            this.Text = "Buscar Médico";
            ((System.ComponentModel.ISupportInitialize)(this.datagridConcordanciasMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cajaTextoBusqueda;
        private System.Windows.Forms.Button botonBuscarMedico;
        private System.Windows.Forms.DataGridView datagridConcordanciasMedico;
        private System.Windows.Forms.Button botonEditarMedico;
        private System.Windows.Forms.Button botonEliminarMedico;
    }
}