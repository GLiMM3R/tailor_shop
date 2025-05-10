using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.Database;
using app.Model;
using Microsoft.EntityFrameworkCore;

namespace app.Service
{
    public class FilterCustomer
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
    }

    public class CustomerService
    {
        private readonly AppDbContext _context;

        public CustomerService(AppDbContext context)
        {
            this._context = context;
        }

        public async Task<Customer[]> GetAll(FilterCustomer? filter)
        {
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
            }

            return await query.ToArrayAsync();
        }


        public async void Create(Customer dto)
        {
            await _context.Customers.AddAsync(dto);
        }
    }
}
