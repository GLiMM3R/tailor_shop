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

            var result = await query
                .GroupBy(o => o.CreatedAt.Date)
                .Select(g => new OverallSaleStatistic
                {
                    SubTotal = g.Sum(x => x.Subtotal),
                    TotalAmount = g.Sum(x => x.TotalAmount),
                    TotalOrders = g.Count(),
                    TotalAvg = g.Average(x => x.TotalAmount),
                    TotalPaid = _context.Payments
                        .Where(p => g.Select(x => x.Id).Contains(p.OrderId))
                        .Sum(p => (decimal?)p.PaidAmount) ?? 0,
                    Discount = g.Sum(x => x.Discount),
                    DepositAmount = g.Sum(x => x.DepositAmount)
                })
                .FirstOrDefaultAsync(); // Use FirstOrDefaultAsync instead of FirstOrDefault

            if (result == null)
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

            return result;
        }

        public async Task<CustomerStatistic> GetCustomerStatistic(DateTime fromDate, DateTime toDate)
        {
            IQueryable<Customer> query = _context.Customers
                .Include(c => c.Orders);

            var result = await query
                .GroupBy(o => o.Id)
                .Select(g => new CustomerStatistic
                {
                    TotalCustomers = g.Count(),
                    NewCustomers = g.Count(c => c.CreatedAt >= fromDate && c.CreatedAt <= toDate),
                    RepeatCustomers = g.Count(c => c.Orders.Count(o => o.Status != OrderStatus.Pending || o.Status != OrderStatus.Canceled) > 1)
                })
                .FirstOrDefaultAsync(); // Use FirstOrDefaultAsync instead of FirstOrDefault

            if (result == null)
            {
                return new CustomerStatistic
                {
                    TotalCustomers = 0,
                    NewCustomers = 0,
                    RepeatCustomers = 0
                };
            }

            return result;
        }

        public async Task<FabricStatistic> GetFabricsStatistic(DateTime fromDate, DateTime toDate)
        {
            IQueryable<Fabric> query = _context.Fabrics
                .Include(f => f.Orders);

            var result = await query
                .Select(f => new
                {
                    Fabric = f,
                    UsedOrders = f.Orders.Where(o => o.CreatedAt >= fromDate && o.CreatedAt <= toDate)
                })
                .GroupBy(x => x.Fabric.Id)
                .Select(g => new FabricStatistic
                {
                    TotalFabrics = g.Count(),
                    TotalUsedFabrics = g.Sum(x => x.UsedOrders.Sum(o => o.Quantity)),
                    TotalValue = g.Sum(x => x.Fabric.UnitPrice * x.UsedOrders.Sum(o => o.Quantity)),
                    AverageValue = g.Average(x => x.Fabric.UnitPrice * x.UsedOrders.Sum(o => o.Quantity))
                })
                .FirstOrDefaultAsync();

            if (result == null)
            {
                return new FabricStatistic
                {
                    TotalFabrics = 0,
                    TotalUsedFabrics = 0,
                    TotalValue = 0,
                    AverageValue = 0
                };
            }

            return result;
        }

        public async Task<GarmentStatistic> GetGarmentStatistic(DateTime fromDate, DateTime toDate)
        {
            IQueryable<Garment> query = _context.Garments
                .Include(f => f.Orders);

            var result = await query
                .Select(g => new
                {
                    Garment = g,
                    OrdersInRange = g.Orders
                        .Where(o => o.CreatedAt >= fromDate && o.CreatedAt <= toDate && o.Status != OrderStatus.Pending && o.Status != OrderStatus.Canceled)
                })
                .GroupBy(x => x.Garment.Id)
                .Select(g => new GarmentStatistic
                {
                    TotalGarments = g.Count(),
                    TotalValue = g.Sum(x => x.OrdersInRange.Sum(o => o.Quantity * (o.Garment.BasePrice ?? 0)))
                })
                .FirstOrDefaultAsync();

            if (result == null)
            {
                return new GarmentStatistic
                {
                    TotalGarments = 0,
                    TotalValue = 0
                };
            }

            return result;
        }

        // Pseudocode plan:
        // - In GetPaymentTransactionStatistic, group payments by OrderId instead of grouping all together (by 1).
        // - For each group (per order), calculate the same statistics as before, but aggregate across all groups for the final result.
        // - This means: flatten the grouped results into a single PaymentTransactionStatistic by summing/counting/averaging as appropriate.

        public async Task<PaymentTransactionStatistic> GetPaymentTransactionStatistic(DateTime fromDate, DateTime toDate)
        {
            IQueryable<Payment> query = _context.Payments
                .Include(pt => pt.Order)
                .Where(pt => pt.CreatedAt >= fromDate && pt.CreatedAt <= toDate);

            var grouped = await query
                .GroupBy(pt => new { pt.OrderId })
                .Select(g => new
                {
                    TotalAmount = g.Sum(pt => pt.TotalPrice),
                    TotalPaidAmount = g.Sum(pt => pt.PaidAmount),
                    TotalCashTransactions = g.Where(pt => pt.TransactionType == TransactionType.Cash).Sum(pt => pt.PaidAmount),
                    TotalBankTransactions = g.Where(pt => pt.TransactionType == TransactionType.Bank).Sum(pt => pt.PaidAmount),
                    TotalDepositTransactions = g.Where(pt => pt.TransactionType == TransactionType.Deposit).Sum(pt => pt.PaidAmount),
                    AverageTransactionAmount = g.Average(pt => pt.PaidAmount),
                    TransactionCount = g.Count()
                })
                .ToListAsync();

            if (grouped == null || grouped.Count == 0)
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
                TotalTransactions = grouped.Sum(x => x.TransactionCount),
                TotalPaidAmount = grouped.Sum(x => x.TotalPaidAmount),
                TotalCashTransactions = grouped.Sum(x => x.TotalCashTransactions),
                TotalBankTransactions = grouped.Sum(x => x.TotalBankTransactions),
                TotalDepositTransactions = grouped.Sum(x => x.TotalDepositTransactions),
                AverageTransactionAmount = grouped.Average(x => x.AverageTransactionAmount)
            };
        }
    }
}
