using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Model
{
    public class Fabric
    {
        [Key]
        public int Id { get; set; }

        public byte[]? Image { get; set; }

        [Required]
        public string MaterialType { get; set; }

        [Required]
        public string ColorCode { get; set; } = string.Empty;

        public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
