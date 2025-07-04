﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Model
{
    public enum Gender
    {
        [Display(Name = "ຊາຍ")]
        Male,
        [Display(Name = "ຍິງ")]
        Female
    }

    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(12)]
        public string Phone { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
