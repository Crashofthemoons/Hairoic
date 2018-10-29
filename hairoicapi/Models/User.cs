﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HairoicAPI.Models
{
    public class User : IdentityUser
    {
        [Required]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }

    }
}
