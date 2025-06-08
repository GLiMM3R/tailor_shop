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
    public class FilterFabric : Pagination
    {
        public FilterFabric(int page, int pageSize) : base(page, pageSize)
        {
            this.Page = page;
            this.PageSize = pageSize;
        }

        public string? Search { get; set; }
    }

    public class FabricService
    {
        private readonly AppDbContext _dbContext;

        public FabricService(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<ListResult<Fabric>> GetAll(FilterFabric? filter)
        {
            var skip = (filter?.Page - 1 ?? 0) * (filter?.PageSize ?? 10);
            if (skip < 0) skip = 0;

            IQueryable<Fabric> query = _dbContext.Fabrics.AsQueryable();

            if (filter != null)
            {
                if (!string.IsNullOrEmpty(filter.Search))
                {
                    query = query.Where(c => c.MaterialType.ToLower().Contains(filter.Search.ToLower()) || c.ColorCode.ToLower().Contains(filter.Search.ToLower()));
                }
            }

            var total = await query.CountAsync();
            var data = await query.Skip(skip).Take(filter?.PageSize ?? 0).ToArrayAsync();

            return new ListResult<Fabric>
            {
                Data = data,
                Total = total
            };
        }

        public async Task<Fabric?> GetByID(int id)
        {
            var fabric = await _dbContext.Fabrics.FirstOrDefaultAsync(c => c.Id == id);

            if (fabric == null)
            {
                return null;
            }

            return fabric;
        }

        public async Task Create(Fabric fabric)
        {
            _dbContext.Fabrics.Add(fabric);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(Fabric fabric)
        {
            _dbContext.Fabrics.Update(fabric);
            await _dbContext.SaveChangesAsync();
        }
    }
}
