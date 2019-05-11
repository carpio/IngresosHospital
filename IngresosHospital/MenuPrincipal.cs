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

        private void botonIngresosPaciente_Click(object sender, EventArgs e)
        {
            this.Hide();
            var reporteIngresosPacientes = new ReporteIngresosPaciente();
            reporteIngresosPacientes.Show();
        }

        private void botonIngresosMedicos_Click(object sender, EventArgs e)
        {
            this.Hide();
            var reporteIngresosMedicos = new ReporteIngresosMedicos();
            reporteIngresosMedicos.Show();
        }

        private void buttonAntiguedadPaciente_Click(object sender, EventArgs e)
        {
            this.Hide();
            var antiguedadPaciente = new antiguedadPaciente();
            antiguedadPaciente.Show();
        }

        private void buttonAntiguedadMedico_Click(object sender, EventArgs e)
        {
            this.Hide();
            var antiguedadMedico = new antiguedadMedico();
            antiguedadMedico.Show();
        }
    }
}
