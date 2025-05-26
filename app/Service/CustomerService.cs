using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.Database;
using app.Model;
using Microsoft.EntityFrameworkCore;

namespace app.Service
{
    public class FilterCustomer : Pagination
    {
        public FilterCustomer(int page, int pageSize) : base(page, pageSize)
        {
            this.Page = page;
            this.PageSize = pageSize;
        }

        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }

        public Gender? Gender { get; set; }
    }

    public class CustomerService
    {
        private readonly AppDbContext _context;

        public CustomerService(AppDbContext context)
        {
            this._context = context;
        }

        public Customer? GetByID(int id)
        {
            return this._context.Customers.FirstOrDefault(o => o.Id == id);
        }

        public async Task<ListResult<Customer>> GetAll(FilterCustomer? filter)
        {
            var skip = (filter?.Page - 1 ?? 0) * (filter?.PageSize ?? 10);
            if (skip < 0) skip = 0;

            IQueryable<Customer> query = _context.Customers.AsQueryable();

            if (filter != null)
            {
                if (filter.Id.HasValue)
                {
                    query = query.Where(c => c.Id == filter.Id.Value);
                }

                if (!string.IsNullOrEmpty(filter.Name))
                {
                    query = query.Where(c => c.Name != null && c.Name.ToLower().Contains(filter.Name.ToLower()));
                }

                if (!string.IsNullOrEmpty(filter.Phone))
                {
                    query = query.Where(c => c.Phone != null && c.Phone.Contains(filter.Phone));
                }

                if (filter.Gender.HasValue)
                {
                    query = query.Where(c => c.Gender == filter.Gender.Value);
                }
            }
            var total = await query.CountAsync();
            var data = await query.Skip(skip).Take(filter?.PageSize ?? 10).ToArrayAsync();

            return new ListResult<Customer>
            {
                Data = data,
                Total = total
            };
        }

        public async Task Create(Customer dto)
        {
            _context.Customers.Add(dto);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Customer customer)
        {
            _context.Customers.Update(customer);
            await _context.SaveChangesAsync();
        }

        public int Count()
        {
            return _context.Customers.Count();
        }
    }
}
