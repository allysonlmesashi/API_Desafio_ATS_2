using DesafioATS.Application.Commands.VacancyApplication;
using DesafioATS.Application.DTOs;
using DesafioATS.Application.Queries.VacancyApplication;
using DesafioATS.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DesafioATS.API.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class VacancyApplicationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VacancyApplicationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("Candidates/{vacancyId}")]
        public async Task<ActionResult<IEnumerable<VacancyApplication>>> GetAllCandidatesByVacancyId(Guid vacancyId)
        {
            var vacancyApplications = await _mediator.Send(new GetAllCandidatesByVacancyIdQuery(vacancyId));
            return Ok(vacancyApplications);
        }

        [HttpPost]
        public async Task<ActionResult<VacancyApplication>> Post([FromBody] VacancyApplicationDTO vacancyApplication)
        {
            var result = await _mediator.Send(new CreateVacancyApplicationCommand(vacancyApplication));
            vacancyApplication.Id = result.Id;
            return CreatedAtAction(nameof(GetAllCandidatesByVacancyId), new { vacancyId = vacancyApplication.VacancyId }, vacancyApplication);
        }
    }
}
