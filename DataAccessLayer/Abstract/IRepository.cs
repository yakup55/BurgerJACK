﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayerr.Abstract
{
    public interface IRepository<T>
    {
        List<T> List();
        void Insert(T entity);
        T Get(Expression<Func<T, bool>> filter);
        void Update(T entity);
        void Delete(T entity);
        
        List<T> List(Expression<Func<T, bool>> filter); 
    }
}