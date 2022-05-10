
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
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var query = new CatQueryRequest();
            return Ok(await _mediator.Send(query));
        }
        [HttpPost("add")]
       public async Task<IActionResult> Add(AddCatCommandRequest request)
        {
          
            return Ok(await _mediator.Send(request));
        }


       








        /// [HttpGet("getall")]
        /// public async Task<IActionResult> GetAll() => Ok(await _mediator.Send(new CatQueryRequest()));
        ///
        /// [HttpGet("getbyid")]
        ///public async Task<IActionResult> GetById(int id) => Ok(await _mediator.Send(new CatByIdQueryRequest { Id = id }));
        ///
        ///
        //  [HttpPost("add")]
        //  public async Task<IActionResult> Add(AddCatCommandRequest request) => Ok(await _mediator.Send(request));

        /// [HttpDelete("{id}")]
        /// public async Task<IActionResult> Delete(int id) => Ok(await _mediator.Send(new DeleteCatCommandRequest { Id = id }));
        ///
        /// [HttpPut("{id}")]
        /// public async Task<IActionResult> Put(int id, UpdateCatCommandRequest request)
        /// {
        ///     request.Id = id;
        ///     return Ok(await _mediator.Send(request));
        /// }


    }
}