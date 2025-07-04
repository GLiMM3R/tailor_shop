﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Model
{
    public enum BodyType
    {
        UpperBody = 0,
        LowerBody = 1,
    }

    public class Measurement
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; } // Navigation Property

        [Required]
        public BodyType BodyType { get; set; } = BodyType.UpperBody;

        [Required]
        public string BodyPart { get; set; }

        [Required]
        public decimal Value { get; set; }

        [Required]
        public string Unit {  get; set; }

        public DateTime MeasurementDate { get; set; } = DateTime.Now;
    }
}
