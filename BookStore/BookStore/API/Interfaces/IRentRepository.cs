﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;

namespace BookStore.API.Interfaces
{
    public interface IRentRepository : IRepository<Rent>
    {
        IEnumerable<Rent> GetByCustomerId(int? customerId);
    }
}