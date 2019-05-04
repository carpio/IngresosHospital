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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void botonAgregarMedico_Click(object sender, EventArgs e)
        {
            this.Hide();
            var agregarMedico = new AgregarMedico();
            agregarMedico.Show();
        }

        private void botonAgregarPaciente_Click(object sender, EventArgs e)
        {
            this.Hide();
            var agregarPaciente = new AgregarPaciente();
            agregarPaciente.Show();
        }
    }
}
