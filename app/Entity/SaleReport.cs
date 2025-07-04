﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Entity
{
    public class SaleReport
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public string UserName { get; set; } // Added UserName property to include user information
        public string GarmentName { get; set; }
        public string FabricName { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal DepositAmount { get; set; }
        public decimal BalanceAmount => TotalAmount - DepositAmount;
        public string Status { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? PickUpDate { get; set; }
    }

    public class SaleStatistic
    {
        public int TotalOrders { get; set; }
        public int TotalCustomers { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalDeposit { get; set; }
        public decimal TotalBalance { get; set; }
    }
}
