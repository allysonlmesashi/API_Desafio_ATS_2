using DesafioATS.Application.Commands.CandidateResume;
using DesafioATS.Application.DTOs;
using DesafioATS.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DesafioATS.API.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CandidateResumeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CandidateResumeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<CandidateResume>> Post([FromBody] CandidateResumeDTO candidateResume)
        {
            var result = await _mediator.Send(new CreateCandidateResumeCommand(candidateResume));
            candidateResume.Id = result.Id;
            return CreatedAtAction(nameof(Post), new { id = candidateResume.Id }, candidateResume);
        }
    }
}
