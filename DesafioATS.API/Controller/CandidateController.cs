using DesafioATS.Application.Commands.Candidate;
using DesafioATS.Application.DTOs;
using DesafioATS.Application.Queries.Candidate;
using DesafioATS.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Matching;

namespace DesafioATS.API.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CandidateController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CandidateController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Candidate>> GetById(Guid id)
        {
            var candidate = await _mediator.Send(new GetCandidateByIdQuery(id));
            if (candidate == null)
            {
                return NotFound();
            }
            return Ok(candidate);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Candidate>>> GetAll()
        {
            var candidates = await _mediator.Send(new GetAllCandidatesQuery());
            return Ok(candidates);
        }

        [HttpPost]
        public async Task<ActionResult<Candidate>> Post([FromBody] CandidateDTO candidate)
        {
            var result = await _mediator.Send(new CreateCandidateCommand(candidate));
            candidate.Id = result.Id;
            return CreatedAtAction(nameof(GetById), new { id = candidate.Id }, candidate);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] CandidateDTO candidate)
        {
            var result = await _mediator.Send(new UpdateCandidateCommand(id, candidate));

            if (result != null)
                return NoContent();
            else
                return NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (await _mediator.Send(new DeleteCandidateCommand(id)))
                return NoContent();         
            return NotFound();
        }
    }
}
