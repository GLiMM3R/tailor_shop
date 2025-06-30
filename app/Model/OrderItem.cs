using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Model
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

        [Required]
        public int GarmentId { get; set; }
        [ForeignKey("GarmentId")]
        public virtual Garment Garment { get; set; } // Navigation Property [Required]

        public int FabricId { get; set; }
        [ForeignKey("FarbricId")]
        public virtual Fabric Fabric { get; set; } // Navigation Property

        [Required]
        public int Quantity { get; set; }

        public virtual ICollection<Measurement> Measurements { get; set; } = new List<Measurement>();
    }
}
