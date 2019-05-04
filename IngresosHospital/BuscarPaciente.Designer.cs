namespace IngresosHospital
{
    partial class BuscarPaciente
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
            this.botonBuscar = new System.Windows.Forms.Button();
            this.dataGridViewPacientes = new System.Windows.Forms.DataGridView();
            this.botonEditarPaciente = new System.Windows.Forms.Button();
            this.botonEliminarPaciente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por Nombre, Apellido o ID:";
            // 
            // cajaTextoBusqueda
            // 
            this.cajaTextoBusqueda.Location = new System.Drawing.Point(222, 43);
            this.cajaTextoBusqueda.Name = "cajaTextoBusqueda";
            this.cajaTextoBusqueda.Size = new System.Drawing.Size(421, 20);
            this.cajaTextoBusqueda.TabIndex = 1;
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(659, 43);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 2;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // dataGridViewPacientes
            // 
            this.dataGridViewPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacientes.Location = new System.Drawing.Point(51, 99);
            this.dataGridViewPacientes.Name = "dataGridViewPacientes";
            this.dataGridViewPacientes.Size = new System.Drawing.Size(683, 288);
            this.dataGridViewPacientes.TabIndex = 3;
            // 
            // botonEditarPaciente
            // 
            this.botonEditarPaciente.Location = new System.Drawing.Point(406, 408);
            this.botonEditarPaciente.Name = "botonEditarPaciente";
            this.botonEditarPaciente.Size = new System.Drawing.Size(145, 23);
            this.botonEditarPaciente.TabIndex = 4;
            this.botonEditarPaciente.Text = "Editar paciente";
            this.botonEditarPaciente.UseVisualStyleBackColor = true;
            this.botonEditarPaciente.Click += new System.EventHandler(this.botonEditarPaciente_Click);
            // 
            // botonEliminarPaciente
            // 
            this.botonEliminarPaciente.Location = new System.Drawing.Point(572, 408);
            this.botonEliminarPaciente.Name = "botonEliminarPaciente";
            this.botonEliminarPaciente.Size = new System.Drawing.Size(145, 23);
            this.botonEliminarPaciente.TabIndex = 5;
            this.botonEliminarPaciente.Text = "Eliminar paciente";
            this.botonEliminarPaciente.UseVisualStyleBackColor = true;
            this.botonEliminarPaciente.Click += new System.EventHandler(this.botonEliminarPaciente_Click);
            // 
            // BuscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonEliminarPaciente);
            this.Controls.Add(this.botonEditarPaciente);
            this.Controls.Add(this.dataGridViewPacientes);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.cajaTextoBusqueda);
            this.Controls.Add(this.label1);
            this.Name = "BuscarPaciente";
            this.Text = "Búsqueda de paciente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cajaTextoBusqueda;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.DataGridView dataGridViewPacientes;
        private System.Windows.Forms.Button botonEditarPaciente;
        private System.Windows.Forms.Button botonEliminarPaciente;
    }
}