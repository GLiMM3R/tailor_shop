using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Constant
{
    public class Period
    {
        public enum PeriodType
        {
            [Display(Name = "ມຶ້ນີ້")]
            Today,
            [Display(Name = "ມື້ວານ")]
            Yesterday,
            [Display(Name = "ອາທິດນີ້")]
            ThisWeek,
            [Display(Name = "ເດືອນນີ້")]
            ThisMonth,
            [Display(Name = "ປີນີ້")]
            ThisYear,
            [Display(Name = "ໄຕມາດນີ້")]
            ThisQuarter,
            [Display(Name = "7ມື້ທີ່ແລ້ວ")]
            Last7Days,
            [Display(Name = "30ມື້ທີ່ແລ້ວ")]
            Last30Days,
            [Display(Name = "ອາທິດທີ່ແລ້ວ")]
            LastWeek,
            [Display(Name = "ເດືອນທີ່ແລ້ວ")]
            LastMonth,
            [Display(Name = "ປີກ່ອນ")]
            LastYear,
        }

        public static string GetEnumDisplayName(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attr = field.GetCustomAttributes(typeof(DisplayAttribute), false)
                            .FirstOrDefault() as DisplayAttribute;
            return attr?.Name ?? value.ToString();
        }
    }
}
