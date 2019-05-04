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
    public partial class BuscarPaciente : Form
    {
        Ingresos_HospitalEntities dbContext = new Ingresos_HospitalEntities();

        public BuscarPaciente()
        {
            InitializeComponent();
        }

        public void PacientesParaGrid()
        {
            var criterioBusqueda = cajaTextoBusqueda.Text;

            var pacientes = (from p in dbContext.T_Paciente
                             where p.Apellidos.Contains(criterioBusqueda) ||
                             p.Nombre.Contains(criterioBusqueda) ||
                             p.ID.ToString().Contains(criterioBusqueda)
                             select new Pacientes {
                                 ID = p.ID,
                                 Apellido = p.Apellidos,
                                 Nombre = p.Nombre
                             }).ToList();

            dataGridViewPacientes.DataSource = pacientes;

            dataGridViewPacientes.Refresh();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            PacientesParaGrid();
        }

        private void botonEditarPaciente_Click(object sender, EventArgs e)
        {
            if (dataGridViewPacientes.SelectedCells.Count > 0)
            {
                var renglon = dataGridViewPacientes.SelectedCells[0].OwningRow;

                //Obtener el ID del elemento (renglón) que se va a actualizar
                var idPaciente = Convert.ToInt32(renglon.Cells[0].FormattedValue);
                try
                {
                    //Obtener de la base de datos, los valores anteriores
                    var paciente = (from medicoDB in dbContext.T_Paciente
                                  where medicoDB.ID == idPaciente
                                  select medicoDB
                              ).FirstOrDefault();
                    //Obtener de la interfaz de usuario los nuevos valores para Nombre y Apellido
                    var nuevoNombre = renglon.Cells[1].FormattedValue;
                    var nuevoApellido = renglon.Cells[2].FormattedValue;

                    //Asignar al paciente de la base de datos, los nuevos valores que traje de la interfaz
                    paciente.Nombre = nuevoNombre.ToString();
                    paciente.Apellidos = nuevoApellido.ToString();

                    //Permitir que el usuario confirme los cambios para el renglón específico
                    DialogResult dialogo = MessageBox.Show("El Paciente con ID: " + idPaciente.ToString() + " será actualizado.", "¿Desea continuar?", MessageBoxButtons.OKCancel);

                    //Si el usuario presiona OK, entonces se guardan los cambios:
                    if (dialogo == DialogResult.OK)
                    {
                        dbContext.Entry(paciente).State = System.Data.Entity.EntityState.Modified;
                        dbContext.SaveChanges();
                        MessageBox.Show("Paciente actualizado con éxito");
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

                PacientesParaGrid();
            }
        }

        private void botonEliminarPaciente_Click(object sender, EventArgs e)
        {
            if (dataGridViewPacientes.SelectedCells.Count > 0)
            {
                var renglon = dataGridViewPacientes.SelectedCells[0].OwningRow;

                //Obtener el ID del elemento (renglón) que se va a actualizar
                var idPaciente = Convert.ToInt32(renglon.Cells[0].FormattedValue);
                try
                {
                    //Obtener de la base de datos, los valores anteriores
                    var paciente = (from medicoDB in dbContext.T_Paciente
                                  where medicoDB.ID == idPaciente
                                  select medicoDB
                              ).FirstOrDefault();

                    //Permitir que el usuario confirme la eliminación para el renglón específico
                    DialogResult dialogo = MessageBox.Show("El paciente con ID: " + idPaciente.ToString() + " será eliminado.", "¿Desea continuar?", MessageBoxButtons.OKCancel);

                    if (dialogo == DialogResult.OK)
                    {

                        //Primero se deben eliminar los ingresos (T_Ingresos) del paciente
                        //Obtener todos los ingresos del paciente
                        var ingresosConPacienteAeliminar = (from ingresosDB in dbContext.T_Ingresos
                                                          where ingresosDB.ID_Medico == idPaciente
                                                          select ingresosDB
                                                          ).ToList();
                        //Eliminar cada ingreso que tenga el paciente de la base de datos
                        foreach (var ingreso in ingresosConPacienteAeliminar)
                        {
                            dbContext.T_Ingresos.Remove(ingreso);
                            dbContext.SaveChanges();
                        }
                        //Eliminar al paciente de la base de datos
                        dbContext.T_Paciente.Remove(paciente);
                        dbContext.SaveChanges();
                        MessageBox.Show("El paciente fue eliminado con éxito");
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

                PacientesParaGrid();
            }
        }
    }
}
