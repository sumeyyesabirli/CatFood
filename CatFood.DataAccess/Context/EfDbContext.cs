using CatFood.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFood.DataAccess.Context
{
    internal class EfDbContext : DbContext
    {
        public EfDbContext( DbContextOptions options) : base(options)
        {     

        }
        public DbSet<Cats> Cats { get; set; }
        public DbSet<Foods> Foods { get; set; }

    }
}
