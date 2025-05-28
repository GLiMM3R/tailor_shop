using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace app.Entity
{
    public class InvoiceModel
    {
        public string InvoiceNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime? DueDate { get; set; } = null;
        public string SellerName { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public List<InvoiceItem> Items { get; set; }
        public decimal Subtotal => Items.Sum(item => item.Total);
        public decimal Discount { get; set; }
        public decimal DepositAmount { get; set; }
        public decimal TotalAmount => Subtotal - Discount;
    }

    public class InvoiceItem
    {
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total => Quantity * UnitPrice;
    }
}
