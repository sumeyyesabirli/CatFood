﻿using CatFood.Core.Repositories.Abstract;
using CatFood.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFood.DataAccess.Repositories
{
    public interface IFoodRepository  : IRepository <Foods>
    {
    }
}