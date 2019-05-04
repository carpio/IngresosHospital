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
    public partial class BuscarMedico : Form
    {
        Ingresos_HospitalEntities dbContext = new Ingresos_HospitalEntities();
        public BuscarMedico()
        {
            InitializeComponent();
        }

        private void botonBuscarMedico_Click(object sender, EventArgs e)
        {
            var criterioDeBusqueda = cajaTextoBusqueda.Text;

            //Query LINQ para seleccionar los campos de T_Medico
            //que coinciden con mi criterio de búsqueda
            var coincidencias =
                (from m in dbContext.T_Medico
                where
                m.Nombre.Contains(criterioDeBusqueda)
                || m.Apellidos.Contains(criterioDeBusqueda)
                || m.ID.ToString().Contains(criterioDeBusqueda)
                select new Medicos {
                    Nombre  = m.Nombre,
                    Apellido = m.Apellidos,
                    ID = m.ID
                }).ToList();

            datagridConcordanciasMedico.DataSource = coincidencias;
            datagridConcordanciasMedico.Refresh();
        }
    }
}
