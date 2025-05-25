using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Model
{
    public enum TransactionType
    {
        Cash = 0,
        Bank = 1,
        Deposit = 2,
    }

    public class Payment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        [Required]
        public decimal PaidAmount { get; set; }

        public TransactionType TransactionType { get; set; } = TransactionType.Cash;

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
