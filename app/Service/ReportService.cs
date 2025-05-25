using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.Database;
using app.Entity;
using app.Model;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
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

        public enum CustomerReportType
        {
            [Display(Name = "ທັງໝົດ")]
            All,
            [Display(Name = "ລູກຄ້າໃໝ່")]
            NewCustomer,
            [Display(Name = "ລູກຄ້າປະຈຳ")]
            RepeatCustomer,
            [Display(Name = "ລູກຄ້າໃຊ້ຈ່າຍສູງ")]
            TopSpendingCustomer,
            [Display(Name = "ລູກຄ້າສັ່ງຊື້ຫຼາຍ")]
            TopOrderCustomer,
        }

        public async Task<ListResult<CustomerReport>> GetCustomerReport(DateTime fromDate, DateTime toDate, Pagination pagination, CustomerReportType reportType = CustomerReportType.All)
        {
            var skip = (pagination?.Page - 1 ?? 0) * (pagination?.PageSize ?? 10);
            if (skip < 0) skip = 0;

            IQueryable<Customer> query = _context.Customers
                .Include(c => c.Orders);

            if (reportType == CustomerReportType.NewCustomer)
            {
                query = query.Where(c => c.CreatedAt >= fromDate && c.CreatedAt <= toDate);
            }
            else if (reportType == CustomerReportType.RepeatCustomer)
            {
                query = query.Where(c => c.Orders.Any(o => o.CreatedAt >= fromDate && o.CreatedAt <= toDate) && c.Orders.Count > 1);
            }
            else if (reportType == CustomerReportType.TopSpendingCustomer)
            {
                // Filter customers who have orders in the date range
                query = query.Where(c => c.Orders.Any(o => o.CreatedAt >= fromDate && o.CreatedAt <= toDate));
            }
            else if (reportType == CustomerReportType.TopOrderCustomer)
            {
                query = query.Where(c => c.Orders.Any(o => o.CreatedAt >= fromDate && o.CreatedAt <= toDate));
            }

            var grouped = query.Select(c => new CustomerReport
            {
                Id = c.Id,
                Name = c.Name ?? "",
                Gender = c.Gender,
                Phone = c.Phone ?? "",
                Address = c.Address ?? "",
                OrderCount = c.Orders.Count(o => o.CreatedAt >= fromDate && o.CreatedAt <= toDate),
                TotalQuantity = c.Orders.Where(o => o.CreatedAt >= fromDate && o.CreatedAt <= toDate).Sum(o => o.Quantity),
                TotalSpent = c.Orders.Where(o => o.CreatedAt >= fromDate && o.CreatedAt <= toDate).Sum(o => o.TotalAmount),
                LastOrderDate = c.Orders.Where(o => o.CreatedAt >= fromDate && o.CreatedAt <= toDate).OrderByDescending(o => o.CreatedAt).Select(o => o.CreatedAt).FirstOrDefault(),
                CreatedAt = c.CreatedAt,
                UpdatedAt = c.UpdatedAt
            });

            // Apply ordering for TopSpendingCustomer and TopOrderCustomer
            if (reportType == CustomerReportType.TopSpendingCustomer)
            {
                grouped = grouped.OrderByDescending(r => r.TotalSpent);
            }
            else if (reportType == CustomerReportType.TopOrderCustomer)
            {
                grouped = grouped.OrderByDescending(r => r.TotalQuantity);
            }

            var total = await grouped.CountAsync();
            var data = await grouped
                .Skip(skip)
                .Take(pagination?.PageSize ?? 10)
                .ToArrayAsync();

            return new ListResult<CustomerReport>
            {
                Data = data,
                Total = total
            };
        }

        public enum FabricReportType
        {
            [Display(Name = "ທັງໝົດ")]
            All,
            [Display(Name = "ຖືກໃຊ້ຫຼາຍ")]
            MostUsedQuantity,
            [Display(Name = "ມູນຄ່າສູງ")]
            TopValue
        }

        public async Task<ListResult<FabricReport>> GetFabricReport(DateTime fromDate, DateTime toDate, Pagination pagination, FabricReportType reportType)
        {
            var skip = (pagination?.Page - 1 ?? 0) * (pagination?.PageSize ?? 10);
            if (skip < 0) skip = 0;


            IQueryable<Fabric> query = _context.Fabrics
                .Include(c => c.Orders);

            var grouped = query.Select(c => new FabricReport
            {
                FabricId = c.Id,
                MaterialType = c.MaterialType,
                Color = c.Color,
                TotalUsedQuantity = c.Orders
                    .Where(o => o.CreatedAt >= fromDate && o.CreatedAt <= toDate)
                    .Sum(o => o.FabricUsedQty),
                TotalValue = c.UnitPrice * c.Orders
                    .Where(o => o.CreatedAt >= fromDate && o.CreatedAt <= toDate)
                    .Sum(o => o.FabricUsedQty)     
            });

           if (reportType == FabricReportType.MostUsedQuantity)
            {
                // Fabrics with the highest total used quantity
                grouped = grouped.OrderByDescending(r => r.TotalUsedQuantity);
            }
            else if (reportType == FabricReportType.TopValue)
            {
                // Fabrics with the highest total value
                grouped = grouped.OrderByDescending(r => r.TotalValue);
            }
            else
            {
                // Default ordering for All report type
                grouped = grouped.OrderByDescending(r => r.FabricId);
            }

            var total = await grouped.CountAsync();
            var data = await grouped
                .Skip(skip)
                .Take(pagination?.PageSize ?? 10)
                .ToArrayAsync();

            return new ListResult<FabricReport>
            {
                Data = data,
                Total = total
            };
        }
        //public async Task<ListResult<FabricReport>> GetFabricReport(DateTime fromDate, DateTime toDate, Pagination pagination, FabricReportType reportType)
        //{
        //    var skip = (pagination?.Page - 1 ?? 0) * (pagination?.PageSize ?? 10);
        //    if (skip < 0) skip = 0;

        //    // Only include completed orders in the date range
        //    var query = _context.Orders
        //        .Include(o => o.Fabric) // Include Fabric navigation property
        //        .Where(o => o.CreatedAt >= fromDate && o.CreatedAt <= toDate)
        //        .Where(o => o.Status != OrderStatus.Pending && o.Status != OrderStatus.Canceled);

        //    // Group by FabricId
        //    var grouped = query
        //        .GroupBy(o => o.FabricId)
        //        .Select(g => new FabricReport
        //        {
        //            FabricId = g.Key,
        //            MaterialType = g.Select(o => o.Fabric.MaterialType).FirstOrDefault() ?? "", // Fix: Access the MaterialType property of the Fabric entity
        //            Color = g.Select(o => o.Fabric.Color).FirstOrDefault() ?? "", // Fix: Access the Color property of the Fabric entity
        //            TotalOrdered = g.Count(),
        //            TotalUsed = g.Sum(o => o.FabricUsedQty),
        //            TotalCustomers = g.Select(x => x.CustomerId).Distinct().Count(),
        //            TotalSpending = g.Sum(x => x.TotalAmount),
        //        });

        //    // Apply ordering for TopSpendingCustomer and TopOrderCustomer
        //    if (reportType == FabricReportType.TopSpending)
        //    {
        //        grouped = grouped.OrderByDescending(r => r.TotalSpending);
        //    }
        //    else if (reportType == FabricReportType.MostCustomer)
        //    {
        //        grouped = grouped.OrderByDescending(r => r.TotalCustomers);
        //    }
        //    else if (reportType == FabricReportType.MostUsed)
        //    {
        //        grouped = grouped.OrderByDescending(r => r.TotalUsed);
        //    }
        //    else if (reportType == FabricReportType.TopOrder)
        //    {
        //        grouped = grouped.OrderByDescending(r => r.TotalOrdered);
        //    }
        //    else
        //    {
        //        // Default ordering for All report type
        //        grouped = grouped.OrderByDescending(r => r.FabricId);
        //    }

        //    var total = await grouped.CountAsync();
        //    var data = await grouped
        //        .OrderByDescending(r => r.FabricId) // Adjusted ordering to use FabricId
        //        .Skip(skip)
        //        .Take(pagination?.PageSize ?? 10)
        //        .ToArrayAsync();

        //    return new ListResult<FabricReport>
        //    {
        //        Data = data,
        //        Total = total
        //    };
        //}

        public enum GarmentReportType
        {
            [Display(Name = "ທັງໝົດ")]
            All,
            [Display(Name = "ລູກຄ້າສັ່ງຊື້ຫຼາຍ")]
            MostCustomer,
            [Display(Name = "ລູກຄ້າໃຊ້ຈ່າຍສູງ")]
            TopSpending,
            [Display(Name = "ສັ່ງຊື້ຫຼາຍ")]
            TopOrder,
            [Display(Name = "ຈຳນວນ")]
            TopQuantity
        }

        public async Task<ListResult<GarmentReport>> GetGarmentReport(DateTime fromDate, DateTime toDate, Pagination pagination, GarmentReportType reportType)
        {
            var skip = (pagination?.Page - 1 ?? 0) * (pagination?.PageSize ?? 10);
            if (skip < 0) skip = 0;

            // Only include completed orders in the date range
            IQueryable<Garment> query = _context.Garments
                .Include(o => o.Orders);

            // Group by FabricId
            var grouped = query
                .Select(g => new GarmentReport
                {
                    Id = g.Id,
                    Name = g.Name, // Fix: Access the Name property of the Garment entity
                    TotalOrdered = g.Orders.Count(o => o.CreatedAt >= fromDate && o.CreatedAt <= toDate),
                    TotalQuantity = g.Orders.Where(o => o.CreatedAt >= fromDate && o.CreatedAt <= toDate).Sum(o => o.Quantity),
                    TotalCustomers = g.Orders.Select(o => o.CustomerId).Distinct().Count(),
                    TotalSpending = g.Orders.Where(o => o.CreatedAt >= fromDate && o.CreatedAt <= toDate).Sum(o => o.TotalAmount),
                });

            // Apply ordering for TopSpendingCustomer and TopOrderCustomer
            if (reportType == GarmentReportType.TopSpending)
            {
                grouped = grouped.OrderByDescending(r => r.TotalSpending);
            }
            else if (reportType == GarmentReportType.MostCustomer)
            {
                grouped = grouped.OrderByDescending(r => r.TotalCustomers);
            }
            else if (reportType == GarmentReportType.TopOrder)
            {
                grouped = grouped.OrderByDescending(r => r.TotalOrdered);
            }
            else if (reportType == GarmentReportType.TopQuantity)
            {
                grouped = grouped.OrderByDescending(r => r.TotalQuantity);
            }
            else
            {
                // Default ordering for All report type
                grouped = grouped.OrderByDescending(r => r.Id);
            }

            var total = await grouped.CountAsync();
            var data = await grouped
                .Skip(skip)
                .Take(pagination?.PageSize ?? 10)
                .ToArrayAsync();

            return new ListResult<GarmentReport>
            {
                Data = data,
                Total = total
            };
        }
    }
}
