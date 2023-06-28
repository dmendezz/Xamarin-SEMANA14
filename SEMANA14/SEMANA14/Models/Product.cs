﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SEMANA14.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime FechaVencimiento { get; set; }

    }
}
