using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Model
{
    public class Garment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }

        public decimal? BasePrice{ get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
