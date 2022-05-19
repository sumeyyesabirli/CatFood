using CatFood.Business.FoodCqrs.Command.Requests;
using CatFood.Business.FoodCqrs.Query.Requests;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CatFood.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FoodsController(IMediator mediator)
        {
            _mediator = mediator;

        }
        [HttpGet] //Bütün verileri getiriyor
        public async Task<IActionResult> GetAll()
            => Ok(await _mediator.Send(new FoodQueryRequest()));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync([FromRoute] int id)
            => Ok(await _mediator.Send(new FoodByIdQueryRequest { Id = id }));

       [HttpPost] //eklemme 
       public async Task<IActionResult> InsertAsync([FromBody] CatFood.Business.FoodCqrs.Command.Requests.AddFoodCommandRequest request)
          => Ok(await _mediator.Send(request));

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
           => Ok(await _mediator.Send(new DeleteFoodCommandRequest { Id = id }));

        [HttpPost("{id}")]
        public async Task<IActionResult> Update([FromBody] CatFood.Business.FoodCqrs.Command.Requests.UpdateFoodCommandRequest request)
         => Ok(await _mediator.Send(request));






    }
}
