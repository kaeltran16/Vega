﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vega.Extensions;

namespace Vega.Models
{
    public class VehicleQuery: IQueryObject
    {
        public int? MakeId { get; set; }
        public int? ModelId { get; set; }
        public string SortBy { get; set; }
        public bool IsAscending { get; set; }

        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
