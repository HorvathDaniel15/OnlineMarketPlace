﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketPlace.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> ReadAllAsync();
        Task<T> ReadAsync(int id);
        Task CreateAsync(T item);
        Task UpdateAsync(T item);
        Task DeleteAsync(int id);
    }
}
