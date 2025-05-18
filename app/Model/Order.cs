using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Model
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [Required]
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; } // Navigation Property

        [Required]
        public int FabricId { get; set; }
        public virtual Fabric Fabric { get; set; } // Navigation Property

        [Required]
        public int Qty { get; set; }

        [Required]
        public decimal Total { get; set; }

        public decimal TotalPaid { get; set; } = 0;

        public DateTime? PickUpDate { get; set; }

        public int Status { get; set; } = 0;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public virtual ICollection<Measurement> Measurements { get; set; } = new List<Measurement>();

        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
