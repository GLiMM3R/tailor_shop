﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Model
{
    public enum Role
    {
        [Display(Name = "ຜູ້ໃຊ້")]
        User,
        [Display(Name = "ຜູ້ດູແລລະບົບ")]
        Admin
    }

    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Salt { get; set; }

        public Role Role { get; set; } = Role.User;

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
