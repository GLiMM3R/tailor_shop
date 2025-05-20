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
    public class DailySequenceService
    {
        private AppDbContext _context;
        public DailySequenceService(AppDbContext context)
        {
            this._context = context;
        }

        public async Task<string> GetNextSequence(DateTime date)
        {
            string datePrefix = date.ToString("ddMMyyyy");
            var dailySequence = await _context.DailySequences
                .FirstOrDefaultAsync(ds => ds.DatePrefix == datePrefix);

            if (dailySequence == null)
            {
                dailySequence = new DailySequence
                {
                    DatePrefix = datePrefix,
                    LastNumber = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };
                await _context.DailySequences.AddAsync(dailySequence);
            }
            else
            {
                dailySequence.LastNumber += 1;
                dailySequence.UpdatedAt = DateTime.Now;
            }

            await _context.SaveChangesAsync();
            return $"{datePrefix}-{dailySequence.LastNumber.ToString("D4")}";
        }


    }
}
