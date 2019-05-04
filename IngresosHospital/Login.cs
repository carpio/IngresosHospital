using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngresosHospital
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void botonLogin_Click(object sender, EventArgs e)
        {
            var usuarioPrincipal = "admin";
            var contrasenaPrincipal = "admin";

            var usuario = cajaTextoNombreUsuario.Text;
            var contrasena = cajaTextoContrasena.Text;

            if (usuarioPrincipal == usuario)
            {
                if (contrasenaPrincipal == contrasena)
                {
                    MessageBox.Show("Login exitoso");
                    this.Hide();
                    var menuPrincipal = new MenuPrincipal();
                    menuPrincipal.Show();
                }
                else
                    MessageBox.Show("Contraseña incorrecta");
            }
            else
                MessageBox.Show("Usuario incorrecto");
        }
    }
}
