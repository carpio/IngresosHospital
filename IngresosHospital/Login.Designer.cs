namespace IngresosHospital
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.ingresos_HospitalDataSet1 = new IngresosHospital.Ingresos_HospitalDataSet();
            this.etiquetaNombreUsuario = new System.Windows.Forms.Label();
            this.cajaTextoNombreUsuario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.etiquetaContrasena = new System.Windows.Forms.Label();
            this.cajaTextoContrasena = new System.Windows.Forms.TextBox();
            this.botonLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ingresos_HospitalDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // ingresos_HospitalDataSet1
            // 
            this.ingresos_HospitalDataSet1.DataSetName = "Ingresos_HospitalDataSet";
            this.ingresos_HospitalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etiquetaNombreUsuario
            // 
            this.etiquetaNombreUsuario.AutoSize = true;
            this.etiquetaNombreUsuario.Location = new System.Drawing.Point(168, 140);
            this.etiquetaNombreUsuario.Name = "etiquetaNombreUsuario";
            this.etiquetaNombreUsuario.Size = new System.Drawing.Size(96, 13);
            this.etiquetaNombreUsuario.TabIndex = 0;
            this.etiquetaNombreUsuario.Text = "Nombre de usuario";
            // 
            // cajaTextoNombreUsuario
            // 
            this.cajaTextoNombreUsuario.Location = new System.Drawing.Point(288, 140);
            this.cajaTextoNombreUsuario.Name = "cajaTextoNombreUsuario";
            this.cajaTextoNombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.cajaTextoNombreUsuario.TabIndex = 1;
            this.cajaTextoNombreUsuario.Tag = "Nombre de usuario";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(394, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 17);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // etiquetaContrasena
            // 
            this.etiquetaContrasena.AutoSize = true;
            this.etiquetaContrasena.Location = new System.Drawing.Point(171, 171);
            this.etiquetaContrasena.Name = "etiquetaContrasena";
            this.etiquetaContrasena.Size = new System.Drawing.Size(61, 13);
            this.etiquetaContrasena.TabIndex = 3;
            this.etiquetaContrasena.Text = "Contraseña";
            // 
            // cajaTextoContrasena
            // 
            this.cajaTextoContrasena.Location = new System.Drawing.Point(288, 171);
            this.cajaTextoContrasena.Name = "cajaTextoContrasena";
            this.cajaTextoContrasena.PasswordChar = '+';
            this.cajaTextoContrasena.Size = new System.Drawing.Size(100, 20);
            this.cajaTextoContrasena.TabIndex = 4;
            // 
            // botonLogin
            // 
            this.botonLogin.Location = new System.Drawing.Point(288, 207);
            this.botonLogin.Name = "botonLogin";
            this.botonLogin.Size = new System.Drawing.Size(75, 23);
            this.botonLogin.TabIndex = 5;
            this.botonLogin.Text = "Login";
            this.botonLogin.UseVisualStyleBackColor = true;
            this.botonLogin.Click += new System.EventHandler(this.botonLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonLogin);
            this.Controls.Add(this.cajaTextoContrasena);
            this.Controls.Add(this.etiquetaContrasena);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cajaTextoNombreUsuario);
            this.Controls.Add(this.etiquetaNombreUsuario);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.ingresos_HospitalDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ingresos_HospitalDataSet ingresos_HospitalDataSet1;
        private System.Windows.Forms.Label etiquetaNombreUsuario;
        private System.Windows.Forms.TextBox cajaTextoNombreUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label etiquetaContrasena;
        private System.Windows.Forms.TextBox cajaTextoContrasena;
        private System.Windows.Forms.Button botonLogin;
    }
}