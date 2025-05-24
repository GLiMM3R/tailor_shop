using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.Database;
using app.Entity;
using app.Model;
using Microsoft.EntityFrameworkCore;
using static app.Service.OrderService;

namespace app.Service
{
    public class ListResult<T>
    {
        public T[] Data { get; set; } = Array.Empty<T>();
        public int Total { get; set; }
    }

    public class ReportService
    {
        private AppDbContext _context;
        public ReportService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ListResult<OverallSaleReport>> GetOverallSaleReport(DateTime fromDate, DateTime toDate, Pagination pagination)
        {
            var skip = (pagination?.Page - 1 ?? 0) * (pagination?.PageSize ?? 10);
            if (skip < 0) skip = 0;

            // Only include completed orders in the date range
            var query = _context.Orders
                .Where(o => o.CreatedAt >= fromDate && o.CreatedAt <= toDate)
                .Where(o => o.Status != OrderStatus.Pending && o.Status != OrderStatus.Canceled);

            // Group by date (date only, ignore time)
            var grouped = query
                .GroupBy(o => o.CreatedAt.Date)
                .Select(g => new OverallSaleReport
                {
                    OrderDate = g.Key,
                    TotalOrders = g.Count(),
                    TotalCustomers = g.Select(x => x.CustomerId).Distinct().Count(),
                    TotalQuantity = g.Sum(x => x.Quantity),
                    Subtotal = g.Sum(x => x.Subtotal),
                    Discount = g.Sum(x => x.Discount),
                    DepositAmount = g.Sum(x => x.DepositAmount),
                    TotalAmount = g.Sum(x => x.TotalAmount),
                    TotalPaid = _context.Payments
                        .Where(p => g.Select(x => x.Id).Contains(p.OrderId))
                        .Sum(p => (decimal?)p.TotalPrice) ?? 0
                });

            var total = await grouped.CountAsync();
            var data = await grouped
                .OrderByDescending(r => r.OrderDate)
                .Skip(skip)
                .Take(pagination?.PageSize ?? 10)
                .ToArrayAsync();

            return new ListResult<OverallSaleReport>
            {
                Data = data,
                Total = total
            };
        }
    }
}
