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
    public partial class ReporteIngresosMedicos : Form
    {
        Ingresos_HospitalEntities dbContext = new Ingresos_HospitalEntities();

        public ReporteIngresosMedicos()
        {
            InitializeComponent();
        }

        private void ReporteIngresosMedicos_Load(object sender, EventArgs e)
        {
            var ingresosPorMedico = (from i in dbContext.T_Ingresos
                                     join m in dbContext.T_Medico
                                     on i.ID_Medico equals m.ID
                                     select new IngresosMedicos
                                     {
                                         ID_Ingreso = i.ID,
                                         FechaIngreso = i.Fecha,
                                         Habitacion = i.Habitacion,
                                         NombreMedico = m.Nombre,
                                         ApellidoMedico = m.Apellidos
                                     }).ToList();

            dgvIngresosMedicos.DataSource = ingresosPorMedico;
            dgvIngresosMedicos.Refresh();
        }
    }
}
