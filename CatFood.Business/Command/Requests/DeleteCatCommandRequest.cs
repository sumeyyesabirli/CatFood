using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFood.Business.Command.Requests
{
    public class DeleteCatCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
