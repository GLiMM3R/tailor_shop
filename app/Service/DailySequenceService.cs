using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app.Database;
using app.Model;

namespace app.Service
{
    public class DailySequenceService
    {
        private AppDbContext _context;
        public DailySequenceService(AppDbContext context)
        {
            this._context = context;
        }

        public int GetNextSequence(DateTime date)
        {
            string datePrefix = date.ToString("ddMMyyyy");
            var dailySequence = _context.DailySequences
                .FirstOrDefault(ds => ds.DatePrefix == datePrefix);

            if (dailySequence == null)
            {
                dailySequence = new DailySequence
                {
                    DatePrefix = datePrefix,
                    LastNumber = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };
                _context.DailySequences.Add(dailySequence);
            }
            else
            {
                dailySequence.LastNumber += 1;
                dailySequence.UpdatedAt = DateTime.Now;
            }

            _context.SaveChanges();
            return dailySequence.LastNumber;
        }


    }
}
