using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Core.Entities;
using Core.Interfaces;
using MediatR;

namespace Apliccation.Features.Personas.Queries
{
    public class GetAllPersonasQueryHandler : IRequestHandler<GetAllPersonasQuery, IEnumerable<Persona>>
    { 
        private readonly IPersonaRepository _personaRepository;

        public GetAllPersonasQueryHandler(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        public async Task<IEnumerable<Persona>> Handle(GetAllPersonasQuery request, CancellationToken cancellationToken)
        {
            return await _personaRepository.GetAllPersonasAsync();
        }
    }
}
