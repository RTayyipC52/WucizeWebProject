﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGenericService<T>
    {
        List<T> GetAll();
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        T GetById(int id);
    }
}
