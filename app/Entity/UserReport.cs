using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Entity
{
    public class UserReport
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int TotalOrders { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class UserStatistic
    {
        public int TotalUsers { get; set; }
        public int TotalOrders { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal AverageOrderValue => TotalOrders > 0 ? TotalAmount / TotalOrders : 0;
    }
}
