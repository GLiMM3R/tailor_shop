﻿using System;
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
        Pending = 0,
        InProgress = 1,
        Completed = 2,
        PickedUp = 3,
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
        public int GarmentId { get; set; }
        public virtual Garment Garment { get; set; } // Navigation Property [Required]

        public int FabricId { get; set; }
        public virtual Fabric Fabric { get; set; } // Navigation Property

        [Required]
        public int FabricUsedQty { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Subtotal { get; set; }

        public decimal Discount { get; set; } = 0;

        [Required]
        public decimal TotalAmount { get; set; }

        public decimal DepositAmount { get; set; } = 0;

        public DateTime? DueDate { get; set; }

        public DateTime? PickUpDate { get; set; }

        public string? Notes { get; set; }

        public OrderStatus Status { get; set; } = OrderStatus.Pending;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public virtual ICollection<Measurement> Measurements { get; set; } = new List<Measurement>();

        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
