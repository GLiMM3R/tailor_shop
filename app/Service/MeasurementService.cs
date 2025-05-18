using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.Database;
using app.Model;
using Microsoft.EntityFrameworkCore;

namespace app.Service
{
    public class FilterMeasurement
    {
        public int OrderId { get; set; }
        public string? BodyPart { get; set; }
    }

    public class MeasurementService
    {
        private readonly AppDbContext _context;

        public MeasurementService(AppDbContext dbContext)
        {
            this._context = dbContext;
        }

        public async Task<Measurement[]> GetAll(FilterMeasurement filter)
        {
            IQueryable<Measurement> query = _context.Measurements.AsQueryable();

            if(filter.OrderId == 0)
            {
                return [];
            }

            query = query.Where(c => c.OrderId == filter.OrderId);

            if (filter != null)
            {
                if (!string.IsNullOrEmpty(filter.BodyPart))
                {
                    query = query.Where(c => c.BodyPart != null && c.BodyPart.ToLower().Contains(filter.BodyPart.ToLower()));
                }
            }

            return await query.ToArrayAsync();
        }

        public async Task<Measurement?> GetByID(int id)
        {
            var measurement = await _context.Measurements.FirstOrDefaultAsync(c => c.Id == id);

            if (measurement == null)
            {
                return null;
            }
            return measurement;
        }

        public async Task Create(Measurement[] measurements)
        {
            _context.Measurements.AddRange(measurements);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Measurement measurement)
        {
            _context.Measurements.Update(measurement);
            await _context.SaveChangesAsync();
        }
    }
}
