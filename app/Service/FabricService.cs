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
    public class FilterFabric
    {
        public string MaterialType { get; set; }
        public string ColorName { get; set; }
    }

    public class FabricService
    {
        private readonly AppDbContext _dbContext;

        public FabricService(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<Fabric[]> GetAll(FilterFabric? filter)
        {
            IQueryable<Fabric> query = _dbContext.Fabrics.AsQueryable();

            if (filter != null)
            {
                if (!string.IsNullOrEmpty(filter.MaterialType))
                {
                    query = query.Where(c => c.MaterialType != null && c.MaterialType.ToLower().Contains(filter.MaterialType.ToLower()));
                }

                if (!string.IsNullOrEmpty(filter.ColorName))
                {
                    query = query.Where(c => c.ColorName.ToLower().Contains(filter.ColorName.ToLower()));
                }
            }

            return await query.ToArrayAsync();
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
