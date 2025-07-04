﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.Model;

namespace app.Entity
{
    public class PaymentTransactionReport
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public TransactionType TransactionType { get; set; } // Cash, Bank, Deposit
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class PaymentTransactionStatistic {
        public int TotalTransactions { get; set; }
        public decimal TotalPaidAmount { get; set; }
        public decimal TotalCashTransactions { get; set; }
        public decimal TotalBankTransactions { get; set; }
        public decimal TotalDepositTransactions { get; set; }
        public decimal AverageTransactionAmount { get; set; }

    }
}
