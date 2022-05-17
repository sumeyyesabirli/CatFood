
using CatFood.Business.Command.Requests;
using CatFood.Business.Command.Responses;
using CatFood.Business.Query.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatFood.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CatsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet] //Bütün verileri getiriyor
        public async Task<IActionResult> GetAll()
            => Ok(await _mediator.Send(new CatQueryRequest()));

        [HttpGet("{id}")] 
        public async Task<IActionResult> GetAsync([FromRoute] int id)
            => Ok(await _mediator.Send(new CatByIdQueryRequest { Id = id }));

         [HttpPost] //eklemme 
        public async Task<IActionResult> InsertAsync([FromBody] CatFood.Business.Command.Requests.AddCatCommandRequest request)
           => Ok(await _mediator.Send(request));


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id) 
            => Ok(await _mediator.Send(new DeleteCatCommandRequest { Id = id }));

      

        [HttpPost("{id}")]
        public async Task<IActionResult> Update([FromBody] CatFood.Business.Command.Requests.UpdateCatCommandRequest request)
         => Ok(await _mediator.Send(request));



    }
}