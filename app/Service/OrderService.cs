using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.Database;
using app.Model;
using Microsoft.EntityFrameworkCore;

namespace app.Service
{
    public class FilterOrder : Pagination
    {
        public FilterOrder(int page, int pageSize) : base(page, pageSize)
        {
            this.Page = page;
            this.PageSize = pageSize;
        }

        public string? Search { get; set; }
        public OrderStatus? Status { get; set; }
    }
    public class OrderService
    {
        private AppDbContext _context;
        public OrderService(AppDbContext context)
        {
            this._context = context;
        }

        public async Task<ListResult<Order>> GetAll(FilterOrder? filter)
        {
            var skip = (filter?.Page - 1 ?? 0) * (filter?.PageSize ?? 10);
            if (skip < 0) skip = 0;

            IQueryable<Order> query = _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Garment)
                .Include(o => o.Fabric)
                .Include(o => o.User);

            if (filter != null)
            {
                if (!string.IsNullOrEmpty(filter.Search))
                {
                    string searchLower = filter.Search.ToLower();
                    query = query.Where(
                        c => c.OrderNumber.ToLower().Contains(searchLower)
                        || c.Customer.Name.ToLower().Contains(searchLower)
                        || c.Customer.Phone.ToLower().Contains(searchLower)
                    );
                }

                if (filter.Status != null)
                {
                    query = query.Where(c => c.Status == filter.Status);
                }
            }

            var total = await query.CountAsync();
            var orders = await query
                .OrderByDescending(o => o.CreatedAt)
                .Skip(skip)
                .Take(filter?.PageSize ?? 10)
                .ToArrayAsync();

            return new ListResult<Order>
            {
                Data = orders,
                Total = total
            };
        }

        public async Task<Order?> GetByID(int id)
        {
            var order = await _context.Orders.Include(o => o.Customer).FirstOrDefaultAsync(c => c.Id == id);

            if (order == null)
            {
                return null;
            }
            return order;
        }

        public async Task<Order?> GetByOrderNumber(string orderNumber)
        {
            var order = await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Garment)
                .Include(o => o.Fabric)
                .Include(o => o.User)
                .Include(o => o.Payments)
                .FirstOrDefaultAsync(c => c.OrderNumber == orderNumber);

            if (order == null)
            {
                return null;
            }
            return order;
        }

        public async Task Create(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Order order)
        {
            _context.Orders.Update(order);
            await _context.SaveChangesAsync();
        }
    }
}
