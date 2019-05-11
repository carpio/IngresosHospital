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
    public partial class AgregarPaciente : Form
    {
        Ingresos_HospitalEntities dbContext = new Ingresos_HospitalEntities();

        public AgregarPaciente()
        {
            InitializeComponent();
        }
        //Stackoverflow - Página para preguntas de programación o Tecnología
        private void botonGuardarMedico_Click(object sender, EventArgs e)
        {
            //1. Tomar los valores que se van a guardar
            var nombrePaciente = cajaTextoNombrePaciente.Text;
            var apellidoPaciente = cajaTextoApellidoPaciente.Text;
            var fechaPaciente = DateTime.Now;

            //Si Nombre y Apellidos son de tamaño menor o igual a 100, coninuar
            if (nombrePaciente.Length <= 100 && apellidoPaciente.Length <= 100)
            {
                //2. Crear un objeto (entidad) del tipo de la tabla (en este caso T_Paciente)
                T_Paciente nuevoPaciente = new T_Paciente();

                //3. Asignar los valores que se tomaron en el paso 1
                nuevoPaciente.Nombre = nombrePaciente;
                nuevoPaciente.Apellidos = apellidoPaciente;
                nuevoPaciente.Fecha = fechaPaciente;

                //Manejo de Excepción (Error) para cuando ocurra durante 
                //el INSERT en la base de datos
                try
                {
                    //4. Guardar en la base de datos el objeto que creamos en el paso 2
                    dbContext.T_Paciente.Add(nuevoPaciente);
                    dbContext.SaveChanges();
                    MessageBox.Show("Paciente guardado con éxito");
                }
                catch (Exception errorArrojado)
                {
                    MessageBox.Show(errorArrojado.Message);
                }
                //Limpar cajas de texto
                cajaTextoApellidoPaciente.Text = "";
                cajaTextoNombrePaciente.Text = "";
            }
            else
                MessageBox.Show("Nombre y apellido no debe tener más de 100 caracteres");
        }
    

        private void botonMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
        }

        private void botonNuevoIngreso_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ingresos = new Ingresos();
            ingresos.Show();
        }

        private void botonBuscarPaciente_Click(object sender, EventArgs e)
        {
            this.Hide();
            var buscarPaciente = new BuscarPaciente();
            buscarPaciente.Show();
        }
    }
}
