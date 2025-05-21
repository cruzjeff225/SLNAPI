using Apliccation.Features.Personas.Commands;
using Apliccation.Features.Personas.Queries;
using Core.Entities.Core.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace apiPersonalAdmin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasControllers : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonasControllers(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Persona>>> GetPersonas()
        {
            var query = new GetAllPersonasQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<int>> CreatePersona(CreatePersonaCommand command)
        {
            var result = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetPersonas), new { id = result }, result);
        }
    }
}
