﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_crud.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public DateTime CreateAt { get; set; } 
    }
}
