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

                if (filter.Gender.HasValue)
                {
                    query = query.Where(c => c.Gender == filter.Gender.Value);
                }
            }

            return await query.ToArrayAsync();
        }

        public void Create(Customer dto)
        {
            _context.Customers.Add(dto);
            _context.SaveChanges();
        }

        public void Update(int id,Customer dto)
        {
            var customer = this.GetByID(id);

            if (customer == null)
            {
                throw new InvalidOperationException();
            }

            if(dto.Name != null && customer.Name != dto.Name)
            {
                customer.Name = dto.Name;
            }

            if (dto.Phone != null && customer.Phone != dto.Phone)
            {
                customer.Phone = dto.Phone;
            }

            if (dto.Address != null && customer.Address != dto.Address)
            {
                customer.Address = dto.Address;
            }

            if (customer.Gender != dto.Gender)
            {
                customer.Gender = dto.Gender;
            }

            _context.Customers.Update(customer);
            _context.SaveChanges();
        }

        public int Count()
        {
            return _context.Customers.Count();
        }
    }
}
