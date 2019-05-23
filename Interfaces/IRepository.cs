﻿using LibraryAmoCRM.Implements;
using LibraryAmoCRM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAmoCRM.Interfaces
{
    public interface IRepository<T>
    {
        Task<T> Add(T item);
    }
}
