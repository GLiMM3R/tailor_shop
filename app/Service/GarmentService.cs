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
    public class FilterGarment
    {
        public string? Name { get; set; }
    }

    public class GarmentService
    {
        private readonly AppDbContext _context;

        public GarmentService(AppDbContext dbContext)
        {
            this._context = dbContext;
        }

        public async Task<Garment[]> GetAll(FilterGarment filter)
        {
            IQueryable<Garment> query = _context.Garments.AsQueryable();

            if (filter != null)
            {
                if (!string.IsNullOrEmpty(filter.Name))
                {
                    query = query.Where(c => c.Name != null && c.Name.ToLower().Contains(filter.Name.ToLower()));
                }
            }

            return await query.ToArrayAsync();
        }

        public async Task<Garment?> GetByID(int id)
        {
            var garment = await _context.Garments.FirstOrDefaultAsync(c => c.Id == id);

            if (garment == null)
            {
                return null;
            }

            return garment;
        }

        public async Task Create(Garment garment)
        {
            _context.Garments.Add(garment);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Garment garment)
        {
            _context.Garments.Update(garment);
            await _context.SaveChangesAsync();
        }
    }
}
