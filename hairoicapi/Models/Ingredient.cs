using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HairoicAPI.Models
{
    public class Ingredient
    {
        [Key]
        public int IngredientId { get; set; }

        [Required]
        public string Name { get; set; }
 
        public User User { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual ICollection<ProductIngredient> ProductIngredients { get; set; }
    }
}
