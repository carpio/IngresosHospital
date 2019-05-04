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
    public partial class PacientesIngresos : Form
    {
        public PacientesIngresos()
        {
            InitializeComponent();
        }

        private void PacientesIngresos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ingresos_HospitalDataSet.Pacientes_Con_Ingresos' table. You can move, or remove it, as needed.
            //this.pacientes_Con_IngresosTableAdapter.Fill(this.ingresos_HospitalDataSet.Pacientes_Con_Ingresos);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pacientes_Con_IngresosTableAdapter.FillBy(this.ingresos_HospitalDataSet.Pacientes_Con_Ingresos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
