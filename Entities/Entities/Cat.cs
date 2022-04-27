using CatFood.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFood.Entities.Entities
{
    public class Cat :BaseEntity
    {
        public string Name { get; set; }
        public string CatType { get; set; }
    }
}
