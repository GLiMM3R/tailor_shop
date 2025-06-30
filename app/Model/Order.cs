using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace app.Model
{
    public enum OrderStatus
    {
        [Display(Name = "ລໍຖ້າ")]
        Pending = 0,
        [Display(Name = "ກຳລັງປະຕິບັດ")]
        InProgress = 1,
        [Display(Name = "ສຳເລັດ")]
        Completed = 2,
        [Display(Name = "ຮັບແລ້ວ")]
        PickedUp = 3,
        [Display(Name = "ຍົກເລີກ")]
        Canceled = 4
    }

    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required] // It's good practice to also mark properties intended to be unique as Required
        public string OrderNumber { get; set; }

        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [Required]
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; } // Navigation Property

        [Required]
        public decimal Subtotal { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

        public decimal DepositAmount { get; set; } = 0;

        // Add this method to the Order class
        public decimal TotalPaid()
        {
            return Payments?.Sum(p => p.PaidAmount) ?? 0m;
        }

        public DateTime? DueDate { get; set; }

        public DateTime? PickUpDate { get; set; }

        public string? Notes { get; set; }

        public OrderStatus Status { get; set; } = OrderStatus.Pending;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }

    public class OrderStatistic
    {
        public int TotalOrders { get; set; }
        public int InProgressOrders { get; set; }
        public int CompletedOrders { get; set; }
        public int PickedUpOrders { get; set; }
        public int CanceledOrders { get; set; }
    }
}
