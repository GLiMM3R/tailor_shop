using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Entity
{
    public class OverallSaleReport
    {
        public DateTime OrderDate { get; set; }
        public int TotalOrders { get; set; }
        public int TotalCustomers { get; set; }
        public int TotalQuantity { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Discount { get; set; }
        public decimal DepositAmount { get; set; }
        public decimal TotalPaid { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class OverallSaleStatistic
    {
        public decimal SubTotal { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalOrders { get; set; }
        public decimal TotalAvg { get; set; }
        public decimal TotalPaid { get; set; }
        public decimal Discount { get; set; }
        public decimal DepositAmount { get; set; }
    }
}
