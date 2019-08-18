﻿using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace DormzReactCore.Products {

    public class Product : Entity<int> {
        [Required]
        public string Description { get; set; }

        public decimal Price { get; set; }
    }
}
