using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.Model;

namespace app.Entity
{
    public class CustomerReport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int OrderCount { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalSpent { get; set; }
        public DateTime LastOrderDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class CustomerStatistic {
        public int TotalCustomers { get; set; }
        public int NewCustomers { get; set; }
        public int RepeatCustomers { get; set; }
    }
}
