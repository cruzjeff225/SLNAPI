using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Apliccation.Features.Personas.Commands
{
    public class CreatePersonaCommand : IRequest<int>
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string DUI { get; set; }
        public string FotografiaUrl { get; set; }
    }
}
