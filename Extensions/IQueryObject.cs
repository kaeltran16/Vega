﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vega.Extensions
{
    public interface IQueryObject
    {
        string SortBy { get; set; }
        bool IsAscending { get; set; }
         int Page { get; set; }
         int PageSize { get; set; }
    }
}
