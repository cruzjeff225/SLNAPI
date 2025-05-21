using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apliccation.Features.Personas.Commands;
using AutoMapper;
using Core.Entities.Core.Entities;

namespace Apliccation.Mappings
{
    public class PersonaProfile : Profile
    {
        public PersonaProfile()
        {
            CreateMap<CreatePersonaCommand, Persona>();
        }
    }
}
