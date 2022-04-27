using CatFood.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFood.DataAccess.Entities
{
    public class Cats :BaseEntity
    {
        public string Name { get; set; }
        public string CatType { get; set; }
    }
}
