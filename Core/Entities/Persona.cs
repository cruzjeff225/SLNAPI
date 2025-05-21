using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    namespace Core.Entities
    {
        public class Persona : BaseEntity
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string Telefono { get; set; }
            public string DUI { get; set; }
            public string fotografiaUrl { get; set; }

            public int Edad
            {
                get
                { 
                    var today = DateTime.Today;
                    var age = today.Year - FechaNacimiento.Year;
                    if (FechaNacimiento.Date > today.AddYears(-age)) age--;
                    return age;
                }
            }
        }
            
    }
}

