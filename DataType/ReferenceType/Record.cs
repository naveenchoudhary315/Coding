﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType.ReferenceType
{
    
        public record Person
        {
            public required string FirstName { get; init; }
            public required string LastName { get; init; }
        };
    
}
