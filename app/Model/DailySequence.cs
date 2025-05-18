using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Model
{
    public class DailySequence
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string DatePrefix { get; set; }

        [Required]
        public int LastNumber { get; set; } = 0;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}
