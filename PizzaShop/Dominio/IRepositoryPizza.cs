﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public interface IRepositoryPizza
    {
        DbSet IDbSet(Type type);
        Pizza Add(Pizza pizza);
    }
}
