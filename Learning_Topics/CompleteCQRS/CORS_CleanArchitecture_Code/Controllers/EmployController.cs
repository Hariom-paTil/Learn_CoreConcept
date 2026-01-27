using CORS.Application.CQRS.Commands;
using CORS.Application.CQRS.Queries;
using CORS.Application.DTOs;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CORS_CleanArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployController : ControllerBase
    {

        private readonly IMediator _mediator;

        public EmployController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _mediator.Send(new GetAllEmployQuery());
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(EmployDto dto)
        {
            await _mediator.Send(new CreateEmployCommand(dto));
            return Ok("Employ Created");
        }
    }
}
