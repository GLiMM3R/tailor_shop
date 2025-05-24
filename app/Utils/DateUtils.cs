using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Utils
{
    public class DateUtils
    {
        public static DateTime GetStartOfDay(DateTime date)
        {
            return date.Date; // Returns the date with time set to 00:00:00
        }

        public static DateTime GetEndOfDay(DateTime date)
        {
            return date.Date.AddDays(1).AddTicks(-1); // Returns the date with time set to 23:59:59.9999999
        }

        public static (DateTime StartOfWeek, DateTime EndOfWeek) GetWeekRange(DateTime date)
        {
            // Assume week starts on Monday
            int diff = (7 + (date.DayOfWeek - DayOfWeek.Monday)) % 7;
            DateTime startOfWeek = date.AddDays(-1 * diff).Date;
            DateTime endOfWeek = startOfWeek.AddDays(6).Date.AddDays(1).AddTicks(-1); // End of Sunday
            return (startOfWeek, endOfWeek);
        }

        public static (DateTime StartOfMonth, DateTime EndOfMonth) GetMonthRange(DateTime date)
        {
            DateTime startOfMonth = new DateTime(date.Year, date.Month, 1);
            DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1).Date.AddDays(1).AddTicks(-1); // End of last day of month
            return (startOfMonth, endOfMonth);
        }

        public static (DateTime StartOfYear, DateTime EndOfYear) GetYearRange(DateTime date)
        {
            DateTime startOfYear = new DateTime(date.Year, 1, 1);
            DateTime endOfYear = new DateTime(date.Year, 12, 31).Date.AddDays(1).AddTicks(-1); // End of last day of year
            return (startOfYear, endOfYear);
        }

        public static (DateTime StartOfQuarter, DateTime EndOfQuarter) GetQuarterRange(DateTime date)
        {
            int quarterNumber = ((date.Month - 1) / 3) + 1;
            int startMonth = (quarterNumber - 1) * 3 + 1;
            DateTime startOfQuarter = new DateTime(date.Year, startMonth, 1);
            DateTime endOfQuarter = startOfQuarter.AddMonths(3).AddDays(-1).Date.AddDays(1).AddTicks(-1); // End of last day of quarter
            return (startOfQuarter, endOfQuarter);
        }
        public static (DateTime Start, DateTime End) GetLast1DayRange(DateTime now)
        {
            DateTime end = GetEndOfDay(now);
            DateTime start = GetStartOfDay(now.AddDays(-1));
            return (start, end);
        }

        public static (DateTime Start, DateTime End) GetLast7DaysRange(DateTime now)
        {
            DateTime end = GetEndOfDay(now);
            DateTime start = GetStartOfDay(now.AddDays(-7));
            return (start, end);
        }

        public static (DateTime Start, DateTime End) GetLastMonthRange(DateTime now)
        {
            DateTime thisMonthStart = new DateTime(now.Year, now.Month, 1);
            DateTime lastMonthEnd = thisMonthStart.AddTicks(-1);
            DateTime lastMonthStart = new DateTime(lastMonthEnd.Year, lastMonthEnd.Month, 1);
            return (lastMonthStart, GetEndOfDay(lastMonthEnd));
        }

        public static (DateTime Start, DateTime End) GetLastYearRange(DateTime now)
        {
            DateTime thisYearStart = new DateTime(now.Year, 1, 1);
            DateTime lastYearEnd = thisYearStart.AddTicks(-1);
            DateTime lastYearStart = new DateTime(lastYearEnd.Year, 1, 1);
            return (lastYearStart, GetEndOfDay(lastYearEnd));
        }


    }
}
