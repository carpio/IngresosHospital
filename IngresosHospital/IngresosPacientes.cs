using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngresosHospital
{
    public class IngresosPacientes
    {
        public int ID_Ingreso { get; set; }
        public DateTime FechaDeIngreso { get; set; }
        public string NombrePaciente { get; set; }
        public string ApellidoPaciente { get; set; }
        public string Habitacion { get; set; }
    }
}
