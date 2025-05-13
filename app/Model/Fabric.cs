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

        [Required]
        public string Type { get; set; }

        [Required]
        public string Color { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
