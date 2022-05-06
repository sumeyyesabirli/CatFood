using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFood.Business.Query.Responses
{
    public class CatByIdQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CatType { get; set; }

    }
}
