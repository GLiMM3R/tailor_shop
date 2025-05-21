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
    public class FilterPayment
    {
        public int? OrderId { get; set; }
        public int? Status { get; set; }
    }

    public class PaymentService
    {
        private AppDbContext _context;
        public PaymentService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Payment[]> GetAll(FilterPayment? filter)
        {
            IQueryable<Payment> query = _context.Payments.AsQueryable();

            if (filter != null)
            {
                if (filter.OrderId != null) // Fix: Check for default value of int instead of null
                {
                    query = query.Where(c => c.OrderId == filter.OrderId);
                }
            }

            return await query.ToArrayAsync();
        }

        public async Task<Payment?> GetByID(int id)
        {
            var payment = await _context.Payments.FirstOrDefaultAsync(c => c.Id == id);

            if (payment == null)
            {
                return null;
            }

            return payment;
        }

        public async Task Create(Payment payment)
        {
            _context.Payments.Add(payment);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Payment payment)
        {
            _context.Payments.Update(payment);
            await _context.SaveChangesAsync();
        }
    }
}
