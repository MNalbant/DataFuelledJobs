﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public Address Address { get; set; }
        public int Phone { get; set; }


    }
}
