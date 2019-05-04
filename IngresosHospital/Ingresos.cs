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
    public partial class Ingresos : Form
    {
        Ingresos_HospitalEntities dbContext = new Ingresos_HospitalEntities();

        public Ingresos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ingresos_Load(object sender, EventArgs e)
        {
            //Obtener lista de médicos de la base de datos con LINQ
            var medicos = (from medicosDB in dbContext.T_Medico
                           select new Medicos {
                               ID = medicosDB.ID,                               
                               Nombre = medicosDB.Nombre + " " + medicosDB.Apellidos
                           }).ToList();

            //Obtener lista de pacientes de la base de datos con LINQ
            var pacientes = (from pacientesDB in dbContext.T_Paciente
                             select new Pacientes
                             {
                                 ID = pacientesDB.ID,                                 
                                 Nombre = pacientesDB.Nombre + " " + pacientesDB.Apellidos
                             }).ToList();

            //Llenar el combobox Médicos
            cbMedico.DataSource = medicos;
            //Identificar la columna que se va a mostrar en la lista
            cbMedico.DisplayMember = "Nombre";
            //Indicar la columna de valores
            cbMedico.ValueMember = "ID";

            cbPaciente.DataSource = pacientes;
            cbPaciente.DisplayMember = "Nombre";
            cbPaciente.ValueMember = "ID";

        }

        private void botonRegistrarIngreso_Click(object sender, EventArgs e)
        {
            //1. Obtener valores de la interfaz de usuario

            //Obtener el ID del médico que seleccionó el usuario
            var idMedico = Convert.ToInt32(cbMedico.SelectedValue);

            //Obtener el ID del paciente que seleccionó el usuario
            var idPaciente = Convert.ToInt32(cbPaciente.SelectedValue);

            //Obtener la habitacion
            var habitacion = cajaTextoHabitacion.Text;

            //Obtener la fecha
            var fecha = DateTime.Now;

            //Crear una ventana preguntando si desea o no continuar
            //guardando los cambios

            //MessageBox.Show Recibe 3 parámetros en este caso:
            //Primer parámetro: Es el mensaje o la pregunta
            //Segundo parámetro: Título
            //Tercer parámetro: Botones (de la clase MessageBoxButtons)
            DialogResult dialogo = 
                MessageBox.Show("¿Está seguro que desea guardar el nuevo ingreso?", "Confirmar", MessageBoxButtons.YesNo);

            if (dialogo == DialogResult.Yes)
            {
                //2. Crear la entidad (objeto) que voy a guardar
                var nuevoIngreso = new T_Ingresos();

                //Asignar los valores que metió el usuario al objeto T_Ingresos
                //recién creado para poder guardar en la base de datos
                nuevoIngreso.Fecha = fecha;
                nuevoIngreso.ID_Medico = idMedico;
                nuevoIngreso.ID_Paciente = idPaciente;
                nuevoIngreso.Habitacion = habitacion;

                //3. Agregar el nuevo ingreso a su tabla (entidad u objeto)
                //Guardar en la base de datos
                dbContext.T_Ingresos.Add(nuevoIngreso);
                try
                {
                    dbContext.SaveChanges();

                    MessageBox.Show("Ingreso guardado con éxito");

                    cajaTextoHabitacion.Text = "";
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }                
            }
            if(dialogo == DialogResult.No)
            {
                cajaTextoHabitacion.Text = "";
            }
        }
    }
}
