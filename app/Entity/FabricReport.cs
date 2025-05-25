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
        public string MaterialType { get; set; }
        public string Color { get; set; }
        public int TotalUsedQuantity { get; set; }
        public decimal TotalValue { get; set; }
    }
}
