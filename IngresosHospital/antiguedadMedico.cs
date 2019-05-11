using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngresosHospital
{
    public partial class antiguedadMedico : Form
    {
        Ingresos_HospitalEntities dbContext = new Ingresos_HospitalEntities();

        public antiguedadMedico()
        {
            InitializeComponent();
        }

        private void antiguedadMedico_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var fechaInicio = Convert.ToDateTime(textBoxFechaInicial.Text + " 00:00:00.000");
                var fechaFin = Convert.ToDateTime(textBoxFechaFinal.Text + " 23:59:00.000");
                var antiguedadMedico = (from m in dbContext.T_Medico
                                        where m.Fecha > fechaInicio
                                        && m.Fecha < fechaFin
                                        select new rangoMedicos
                                        {
                                            fechaMedico = m.Fecha.Value,
                                            nombreMedico = m.Nombre,
                                            apellidoMedico = m.Apellidos
                                        }).ToList();

                dgvAntiguedadMedico.DataSource = antiguedadMedico;
                dgvAntiguedadMedico.Refresh();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
