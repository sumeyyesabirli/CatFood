using CatFood.Business.Command.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFood.Business.Command.Requests
{
    public class UpdateCatCommandRequest : IRequest<UpdateCatCommandResponse>
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public string CatType { get; set; }

    }
}
