using DesafioATS.Application.Commands.Vacancy;
using DesafioATS.Application.DTOs;
using DesafioATS.Application.Queries.Vacancy;
using DesafioATS.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DesafioATS.API.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class VacancyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VacancyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Vacancy>> GetById(Guid id)
        {
            var vacancy = await _mediator.Send(new GetVacancyByIdQuery(id));
            if (vacancy == null)
            {
                return NotFound();
            }
            return Ok(vacancy);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vacancy>>> GetAll()
        {
            var vacancies = await _mediator.Send(new GetAllVacanciesQuery());
            return Ok(vacancies);
        }

        [HttpPost]
        public async Task<ActionResult<Vacancy>> Post([FromBody] VacancyDTO vacancy)
        {
            var result = await _mediator.Send(new CreateVacancyCommand(vacancy));
            vacancy.Id = result.Id;
            return CreatedAtAction(nameof(GetById), new { id = vacancy.Id }, vacancy);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] VacancyDTO vacancy)
        {
            var result = await _mediator.Send(new UpdateVacancyCommand(id, vacancy));

            if (result != null)
                return NoContent();
            else
                return NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (await _mediator.Send(new DeleteVacancyCommand(id)))
                return NoContent();
            return NotFound();
        }
    }
}
