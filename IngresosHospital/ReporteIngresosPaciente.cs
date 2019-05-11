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
    public partial class ReporteIngresosPaciente : Form
    {
        Ingresos_HospitalEntities dbContext = new Ingresos_HospitalEntities();

        public ReporteIngresosPaciente()
        {
            InitializeComponent();
        }

        private void ReporteIngresosPaciente_Load(object sender, EventArgs e)
        {
            var ingresosPacientes = (from i in dbContext.T_Ingresos
                                     join p in dbContext.T_Paciente
                                     on i.ID_Paciente equals p.ID
                                     select new IngresosPacientes
                                     {
                                         ID_Ingreso = i.ID,
                                         FechaDeIngreso = i.Fecha,
                                         NombrePaciente = p.Nombre,
                                         ApellidoPaciente = p.Apellidos,
                                         Habitacion = i.Habitacion
                                     }).ToList();

            dgvIngresosPacientes.DataSource = ingresosPacientes;
            dgvIngresosPacientes.Refresh();
        }
    }
}
