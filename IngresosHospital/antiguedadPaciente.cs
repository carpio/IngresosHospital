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
    public partial class antiguedadPaciente : Form
    {
        Ingresos_HospitalEntities dbContext = new Ingresos_HospitalEntities();

        public antiguedadPaciente()
        {
            InitializeComponent();
        }

        private void antiguedadPaciente_Load(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var fechaInicio = Convert.ToDateTime(textBoxFechaInicial.Text + " 00:00:00.000");
                var fechaFin = Convert.ToDateTime(textBoxFechaFinal.Text + " 23:59:00.000");

                var antiguedadPaciente = (from p in dbContext.T_Paciente
                                          where p.Fecha > fechaInicio
                                          && p.Fecha < fechaFin
                                          select new rangoPacientes
                                          {
                                              fechaPaciente = p.Fecha.Value,
                                              nombrePaciente = p.Nombre,
                                              apellidoPaciente = p.Apellidos
                                          }).ToList();

                dgvAntiguedadPaciente.DataSource = antiguedadPaciente;
                dgvAntiguedadPaciente.Refresh();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
