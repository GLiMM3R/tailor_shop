using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Entity
{
    public class FabricReport
    {
        public int FabricId { get; set; }
        public byte[]? Image { get; set; }
        public string MaterialType { get; set; }
        public string ColorCode { get; set; }
        public int TotalUsedQuantity { get; set; }
        public decimal TotalValue { get; set; }
    }

    public class FabricStatistic
    {
        public int TotalFabrics { get; set; }
        public int TotalUsedFabrics { get; set; }
        public decimal TotalValue { get; set; }
        public decimal AverageValue { get; set; }
    }
}
