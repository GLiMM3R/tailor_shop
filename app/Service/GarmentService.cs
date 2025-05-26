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
    public class FilterGarment : Pagination
    {
        public FilterGarment(int page, int pageSize) : base(page, pageSize)
        {
            this.Page = page;
            this.PageSize = pageSize;
        }

        public string? Search { get; set; }
    }

    public class GarmentService
    {
        private readonly AppDbContext _context;

        public GarmentService(AppDbContext dbContext)
        {
            this._context = dbContext;
        }

        public async Task<ListResult<Garment>> GetAll(FilterGarment? filter)
        {
            var skip = (filter?.Page - 1 ?? 0) * (filter?.PageSize ?? 10);
            if (skip < 0) skip = 0;

            IQueryable<Garment> query = _context.Garments.AsQueryable();

            if (filter != null)
            {
                if (!string.IsNullOrEmpty(filter.Search))
                {
                    query = query.Where(c => c.Name != null && c.Name.ToLower().Contains(filter.Search.ToLower()));
                }
            }

            var total = await query.CountAsync();
            var data = await query.Skip(skip).Take(filter?.PageSize ?? 0).ToArrayAsync();

            return new ListResult<Garment>
            {
                Data = data,
                Total = total
            };
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
