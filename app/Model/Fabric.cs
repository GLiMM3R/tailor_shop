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
        public string MaterialType { get; set; }
        
        [Required]
        public string ColorName { get; set; }

        [Required]
        public string Color { get; set; }

        public decimal UnitPrice { get; set; } = 0;
    }
}
