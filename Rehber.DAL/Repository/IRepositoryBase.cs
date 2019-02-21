﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rehber.DAL.Repository
{
    public interface IRepositoryBase<T> where T:class
    {
        void Add(T item);
        void Update(T item);
        void Delete(T item);
        ICollection<T> GetAll(Expression<Func<T, bool>> paramater = null);
    }
}
