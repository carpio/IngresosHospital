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
            MedicosParaGrid();
        }

        private void botonEditarMedico_Click(object sender, EventArgs e)
        {
            if (datagridConcordanciasMedico.SelectedCells.Count > 0)
            {                
                var renglon = datagridConcordanciasMedico.SelectedCells[0].OwningRow;

                //Obtener el ID del elemento (renglón) que se va a actualizar
                var idMedico = Convert.ToInt32(renglon.Cells[0].FormattedValue);
                try
                {
                    //Obtener de la base de datos, los valores anteriores
                    var medico = (from medicoDB in dbContext.T_Medico
                              where medicoDB.ID == idMedico
                              select medicoDB
                              ).FirstOrDefault();
                    //Obtener de la interfaz de usuario los nuevos valores para Nombre y Apellido
                    var nuevoNombre = renglon.Cells[1].FormattedValue;
                    var nuevoApellido = renglon.Cells[2].FormattedValue;

                    //Asignar al médico de la base de datos, los nuevos valores que traje de la interfaz
                    medico.Nombre = nuevoNombre.ToString();
                    medico.Apellidos = nuevoApellido.ToString();

                    //Permitir que el usuario confirme los cambios para el renglón específico
                    DialogResult dialogo = MessageBox.Show("El médico con ID: " + idMedico.ToString() + " será actualizado.", "¿Desea continuar?", MessageBoxButtons.OKCancel);

                    if (dialogo == DialogResult.OK)
                    {                    
                        dbContext.Entry(medico).State = System.Data.Entity.EntityState.Modified;
                        dbContext.SaveChanges();
                        MessageBox.Show("Médico actualizado con éxito");
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

                MedicosParaGrid();
            }
        }

        private void MedicosParaGrid()
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
                 select new Medicos
                 {
                     Nombre = m.Nombre,
                     Apellido = m.Apellidos,
                     ID = m.ID
                 }).ToList();

            datagridConcordanciasMedico.DataSource = coincidencias;
            datagridConcordanciasMedico.Refresh();
        }

        private void botonEliminarMedico_Click(object sender, EventArgs e)
        {
            if (datagridConcordanciasMedico.SelectedCells.Count > 0)
            {
                var renglon = datagridConcordanciasMedico.SelectedCells[0].OwningRow;

                //Obtener el ID del elemento (renglón) que se va a actualizar
                var idMedico = Convert.ToInt32(renglon.Cells[0].FormattedValue);
                try
                {
                    //Obtener de la base de datos, los valores anteriores
                    var medico = (from medicoDB in dbContext.T_Medico
                                  where medicoDB.ID == idMedico
                                  select medicoDB
                              ).FirstOrDefault();
                    
                    //Permitir que el usuario confirme la eliminación para el renglón específico
                    DialogResult dialogo = MessageBox.Show("El médico con ID: " + idMedico.ToString() + " será eliminado.", "¿Desea continuar?", MessageBoxButtons.OKCancel);

                    if (dialogo == DialogResult.OK)
                    {

                        //Primero se deben eliminar los ingresos (T_Ingresos) que haya hecho el médico
                        //Obtener todos los ingresos el médico
                        var ingresosConMedicoAeliminar = (from ingresosDB in dbContext.T_Ingresos
                                                          where ingresosDB.ID_Medico == idMedico
                                                          select ingresosDB
                                                          ).ToList();
                        //Eliminar cada ingreso que hizo el médico de la base de datos
                        foreach(var ingreso in ingresosConMedicoAeliminar)
                        {
                            dbContext.T_Ingresos.Remove(ingreso);
                            dbContext.SaveChanges();
                        }
                        //Eliminar al médico de la base de datos
                        dbContext.T_Medico.Remove(medico);                        
                        dbContext.SaveChanges();
                        MessageBox.Show("El médico fue eliminado con éxito");
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

                MedicosParaGrid();
            }
        }
    }
}
