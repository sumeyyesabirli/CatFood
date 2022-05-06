using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFood.Business.Command.Requests
{
    public class AddCatCommandRequest :IRequest<bool>
    {
        public string Name { get; set; }
        public string CatType { get; set; }
    }
}
