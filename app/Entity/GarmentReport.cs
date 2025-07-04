﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Entity
{
    public class GarmentReport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalOrders { get; set; }
        public int TotalCustomers { get; set; }
        public decimal TotalValue { get; set; }
    }

    public class GarmentStatistic
    {
        public int TotalGarments { get; set; }
        public decimal TotalValue { get; set; }
    }
}
