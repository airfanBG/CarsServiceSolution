﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Models.Contracts
{
    public interface IBaseEntity:IAuditInfo
    {
        public string Id { get; set; }
        
    }
}
