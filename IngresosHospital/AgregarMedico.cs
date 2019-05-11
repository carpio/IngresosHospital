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
    public partial class AgregarMedico : Form
    {
        Ingresos_HospitalEntities dbContext = new Ingresos_HospitalEntities();

        public AgregarMedico()
        {
            InitializeComponent();
        }

        private void botonMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
        }

        private void botonGuardarMedico_Click(object sender, EventArgs e)
        {
            //1. Tomar los valores que se van a guardar
            var nombreMedico = cajaTextoNombreMedico.Text;
            var apellidoMedico = cajaTextoApellidoMedico.Text;
            var fechaMedico = DateTime.Now;

            //Si Nombre y Apellidos son de tamaño menor o igual a 100, coninuar
            if (nombreMedico.Length <= 100 && apellidoMedico.Length <= 100)
            {
                //2. Crear un objeto del tipo de la tabla (en este caso T_Medico)
                T_Medico nuevoMedico = new T_Medico();

                //3. Asignar los valores que se tomaron en el paso 1
                nuevoMedico.Nombre = nombreMedico;
                nuevoMedico.Apellidos = apellidoMedico;
                nuevoMedico.Fecha = fechaMedico;

                //Manejo de Excepción (Error) para cuando ocurra durante 
                //el INSERT en la base de datos
                try {
                    //4. Guardar en la base de datos el objeto que creamos en el paso 2
                    dbContext.T_Medico.Add(nuevoMedico);
                    dbContext.SaveChanges();
                    MessageBox.Show("Médico guardado con éxito");
                }
                catch(Exception errorArrojado)
                {
                    MessageBox.Show(errorArrojado.Message);
                }
                //Limpar cajas de texto
                cajaTextoApellidoMedico.Text = "";
                cajaTextoNombreMedico.Text = "";
            }
            else
                MessageBox.Show("Nombre y apellido no debe tener más de 100 caracteres");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var actualizarMedico = new BuscarMedico();
            actualizarMedico.Show();
        }
    }
}
