using CatFood.Business.Query.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFood.Business.Query.Requests
{
    public class CatQueryRequest :IRequest<List<CatQueryResponse>>
    {
    }
}
