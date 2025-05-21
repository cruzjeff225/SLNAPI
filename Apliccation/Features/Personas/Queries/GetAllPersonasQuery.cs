using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Core.Entities;
using MediatR;

namespace Apliccation.Features.Personas.Queries
{
    public class GetAllPersonasQuery : IRequest<IEnumerable<Persona>>
    {
        
    }
}
