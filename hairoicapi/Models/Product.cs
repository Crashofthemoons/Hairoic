﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HairoicAPI.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string UPC { get; set; }

        //[Required]
        public User User { get; set; }

        public string UserId { get; set; }

        public virtual ICollection<ProductIngredient> ProductIngredients { get; set; }

        [NotMapped]
        public List<Ingredient> Ingredients { get; set; }

    }
}
