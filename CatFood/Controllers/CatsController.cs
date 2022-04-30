using CatFood.Business.CQRS.Queries.GetAllCat;
using CatFood.Business.CQRS.Queries.UpdadeCat;
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
        public async Task<IActionResult> GetAll([FromQuery] GetAllCatRequest request)
        {
            List<GetAllCatResponse> result = await mediator.Send(request);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromQuery] UpdateCatRequest request)
        {
            List<UpdateCatResponse> result = await mediator.Send(request);
            return Ok(result);
        }
    }
}
