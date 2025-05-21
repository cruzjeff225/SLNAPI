using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Core.Entities.Core.Entities;
using Core.Interfaces;

namespace Apliccation.Features.Personas.Commands
{
    public class CreatePersonaCommandHandler : IRequestHandler<CreatePersonaCommand, int>
    {
        private readonly IPersonaRepository _personaRepository;

        public CreatePersonaCommandHandler(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }
        public async Task<int> Handle(CreatePersonaCommand request, CancellationToken cancellationToken)
        {
            var persona = new Persona
            {
                Nombre = request.Nombre,
                Apellido = request.Apellido,
                FechaNacimiento = request.FechaNacimiento,
                Telefono = request.Telefono,
                DUI = request.DUI,
                fotografiaUrl = request.FotografiaUrl
            };
            var result = await _personaRepository.AddPersonaAsync(persona);
            return result.ID;
        }
    }
}


