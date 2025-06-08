using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.Database;
using app.Entity;
using app.Model;
using Microsoft.EntityFrameworkCore;

namespace app.Service
{
    public class StatisticService
    {
        private AppDbContext _context;
        public StatisticService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<OverallSaleStatistic> GetOverallSaleStatistic(DateTime fromDate, DateTime toDate)
        {
            IQueryable<Order> query = _context.Orders
                .Where(o => o.CreatedAt >= fromDate && o.CreatedAt <= toDate);

            var orders = await query.ToListAsync();

            if (orders == null || orders.Count == 0)
            {
                return new OverallSaleStatistic
                {
                    SubTotal = 0,
                    TotalAmount = 0,
                    TotalOrders = 0,
                    TotalAvg = 0,
                    TotalPaid = 0,
                    Discount = 0,
                    DepositAmount = 0
                };
            }

            var orderIds = orders.Select(o => o.Id).ToList();
            var totalPaid = await _context.Payments
                .Where(p => orderIds.Contains(p.OrderId))
                .SumAsync(p => (decimal?)p.PaidAmount) ?? 0;

            return new OverallSaleStatistic
            {
                SubTotal = orders.Sum(x => x.Subtotal),
                TotalAmount = orders.Sum(x => x.TotalAmount),
                TotalOrders = orders.Count,
                TotalAvg = orders.Average(x => x.TotalAmount),
                TotalPaid = totalPaid,
                Discount = orders.Sum(x => x.Discount),
                DepositAmount = orders.Sum(x => x.DepositAmount)
            };
        }

        public async Task<CustomerStatistic> GetCustomerStatistic(DateTime fromDate, DateTime toDate)
        {
            var customers = await _context.Customers
                .Include(c => c.Orders)
                .ToListAsync();

            int totalCustomers = customers.Count;
            int newCustomers = customers.Count(c => c.CreatedAt >= fromDate && c.CreatedAt <= toDate);
            int repeatCustomers = customers.Count(c =>
                c.Orders != null &&
                c.Orders.Count(o => o.Status != OrderStatus.Pending && o.Status != OrderStatus.Canceled) > 1
            );

            return new CustomerStatistic
            {
                TotalCustomers = totalCustomers,
                NewCustomers = newCustomers,
                RepeatCustomers = repeatCustomers
            };
        }

        public async Task<FabricStatistic> GetFabricsStatistic(DateTime fromDate, DateTime toDate)
        {
            // Get all fabrics and their related orders in the date range
            var fabrics = await _context.Fabrics
                .Include(f => f.Orders)
                .ToListAsync();

            int totalFabrics = fabrics.Count;
            int totalUsedFabrics = 0;
            decimal totalValue = 0;

            foreach (var fabric in fabrics)
            {
                var usedOrders = fabric.Orders
                    .Where(o => o.CreatedAt >= fromDate && o.CreatedAt <= toDate);

                int usedQty = usedOrders.Sum(o => o.Quantity);
                totalUsedFabrics += usedQty;
            }

            return new FabricStatistic
            {
                TotalFabrics = totalFabrics,
                TotalUsedFabrics = totalUsedFabrics,
                TotalValue = 0,
                AverageValue = 0
            };
        }

        public async Task<GarmentStatistic> GetGarmentStatistic(DateTime fromDate, DateTime toDate)
        {
            // Pseudocode:
            // - Query all garments
            // - For each garment, filter its orders by date and status
            // - Sum up the total value (quantity * base price) for all valid orders
            // - Count total garments (distinct garments with at least one valid order in range)

            var garments = await _context.Garments
                .Include(g => g.Orders)
                .ToListAsync();

            int totalGarments = 0;
            decimal totalValue = 0;

            foreach (var garment in garments)
            {
                var validOrders = garment.Orders
                    .Where(o => o.CreatedAt >= fromDate && o.CreatedAt <= toDate
                        && o.Status != OrderStatus.Pending && o.Status != OrderStatus.Canceled);

                int orderCount = validOrders.Any() ? 1 : 0;
                totalGarments += orderCount;
                totalValue += validOrders.Sum(o => o.Quantity * (garment.BasePrice ?? 0));
            }

            return new GarmentStatistic
            {
                TotalGarments = totalGarments,
                TotalValue = totalValue
            };
        }

        // Pseudocode plan:
        // - In GetPaymentTransactionStatistic, group payments by OrderId instead of grouping all together (by 1).
        // - For each group (per order), calculate the same statistics as before, but aggregate across all groups for the final result.
        // - This means: flatten the grouped results into a single PaymentTransactionStatistic by summing/counting/averaging as appropriate.

        public async Task<PaymentTransactionStatistic> GetPaymentTransactionStatistic(DateTime fromDate, DateTime toDate)
        {
            IQueryable<Payment> query = _context.Payments
                .Where(pt => pt.CreatedAt >= fromDate && pt.CreatedAt <= toDate);

            var payments = await query.ToListAsync();

            if (payments == null || payments.Count == 0)
            {
                return new PaymentTransactionStatistic
                {
                    TotalTransactions = 0,
                    TotalPaidAmount = 0,
                    TotalCashTransactions = 0,
                    TotalBankTransactions = 0,
                    TotalDepositTransactions = 0,
                    AverageTransactionAmount = 0
                };
            }

            return new PaymentTransactionStatistic
            {
                TotalTransactions = payments.Count,
                TotalPaidAmount = payments.Sum(pt => pt.PaidAmount),
                TotalCashTransactions = payments.Where(pt => pt.TransactionType == TransactionType.Cash).Sum(pt => pt.PaidAmount),
                TotalBankTransactions = payments.Where(pt => pt.TransactionType == TransactionType.Bank).Sum(pt => pt.PaidAmount),
                TotalDepositTransactions = payments.Where(pt => pt.TransactionType == TransactionType.Deposit).Sum(pt => pt.PaidAmount),
                AverageTransactionAmount = payments.Average(pt => pt.PaidAmount)
            };
        }

        public async Task<OrderStatistic> GetOrderStatistic(DateTime fromDate, DateTime toDate)
        {
            IQueryable<Order> query = _context.Orders
                .Where(o => o.CreatedAt >= fromDate && o.CreatedAt <= toDate);

            var orders = await query.ToListAsync();

            if (orders == null || orders.Count == 0)
            {
                return new OrderStatistic
                {
                    TotalOrders = 0,
                    InProgressOrders = 0,
                    CompletedOrders = 0,
                    PickedUpOrders = 0,
                    CanceledOrders = 0
                };
            }
            return new OrderStatistic
            {
                TotalOrders = orders.Count,
                InProgressOrders = orders.Count(o => o.Status == OrderStatus.InProgress),
                CompletedOrders = orders.Count(o => o.Status == OrderStatus.Completed),
                PickedUpOrders = orders.Count(o => o.Status == OrderStatus.PickedUp),
                CanceledOrders = orders.Count(o => o.Status == OrderStatus.Canceled)
            };
        }
    }
}
