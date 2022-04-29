using CatFood.Business.CQRS.Queries.GetAllCat;
using Entities.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatFood.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatsController : ControllerBase
    {
        private readonly IMediator mediator;

        public CatsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllCatRequest request)
        {
            List<GetAllCatResponse> result = await mediator.Send(request);
            return Ok(result);
        }
    }
}
