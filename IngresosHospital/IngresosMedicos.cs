using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngresosHospital
{
    public class IngresosMedicos
    {
        public int ID_Ingreso { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Habitacion { get; set; }
        public string NombreMedico { get; set; }
        public string ApellidoMedico { get; set; }
    }
}
