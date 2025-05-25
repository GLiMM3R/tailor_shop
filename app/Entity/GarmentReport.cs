using System;
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
        public int TotalOrdered { get; set; }
        public int TotalQuantity { get; set; }
        public int TotalCustomers { get; set; }
        public decimal TotalSpending { get; set; }
    }
}
