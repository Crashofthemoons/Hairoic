using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HairoicAPI.Models
{
    public class HairoicAPIContext : DbContext
    {
        public HairoicAPIContext (DbContextOptions<HairoicAPIContext> options)
            : base(options) {}

        public DbSet<HairoicAPI.Models.Ingredient> Ingredient { get; set; }
        public DbSet<HairoicAPI.Models.Product> Product { get; set; }
        public DbSet<HairoicAPI.Models.ProductIngredient> ProductIngredient { get; set; }
        public DbSet<HairoicAPI.Models.User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            // Restrict deletion of related order when OrderProducts entry is removed

            //modelBuilder.Entity<ProductIngredient>()
            //    .HasOne(l => l.ProductId)
            //    .OnDelete(DeleteBehavior.Restrict);

            User user = new User
            {
                Name = "Jenn",
                UserName = "jenn@gmail.com",
                NormalizedUserName = "JENN@GMAIL.COM",
                Email = "jenn@gmail.com",
                NormalizedEmail = "JENN@GMAIL.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var passwordHash = new PasswordHasher<User>();
            user.PasswordHash = passwordHash.HashPassword(user, "Shampoo2!");
            modelBuilder.Entity<User>().HasData(user);


            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 1,
                    Name = "Alkylbenzene Sulfonate"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 2,
                    Name = "Ammonium Laureth"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 3,
                    Name = "Lauryl Sulfate"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 4,
                    Name = "Ammonium"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 5,
                    Name = "Sodium Xylenesulfonate"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 6,
                    Name = "Dioctyl Sodium Sulfosuccinate"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 7,
                    Name = "Ethyl PEG-15 Cocamine Sulfate"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 8,
                    Name = "Sodium C14-16 Cocamine Sulfate"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 9,
                    Name = "Sodium Cocoyl Sarcosinate"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 10,
                    Name = "Sodium Laureth"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 11,
                    Name = "Sodium Myreth"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 12,
                    Name = "Sodium Lauryl Sulfoacetate"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 13,
                    Name = "TEA-Dodecylbenzenesulfonate"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 14,
                    Name = "Cocamidopropyl Betaine"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 15,
                    Name = "Coco Betaine"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 16,
                    Name = "Cocoamphoacetate"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 17,
                    Name = "Cocoamphodipropionate"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 18,
                    Name = "Disodium Cocoamphodiacetate"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 19,
                    Name = "Lauroamphoacetate"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 20,
                    Name = "Sodium Cocoyl Isethionate"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 21,
                    Name = "Cetearyl Methiocne"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 22,
                    Name = "Cetyl Dimethicone"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 23,
                    Name = "Dimethicone"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 24,
                    Name = "Stearyl Dimethicone"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 25,
                    Name = "Amodimethicone"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 26,
                    Name = "Cyclomethicone"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 27,
                    Name = "Cyclopentasiloxane"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 28,
                    Name = "Trimethysilylamodimethicone"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 29,
                    Name = "Behenoxy Demethicone"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 30,
                    Name = "Stearoxy Dimethicone"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 31,
                    Name = "Pyrithicone Zinc 1%"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 32,
                    Name = "Water"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 33,
                    Name = "Glycol Distearate"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 34,
                    Name = "Zinc Carbonate"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 35,
                    Name = "Sodium Chloride"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 36,
                    Name = "Fragrance"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 37,
                    Name = "Sodium Benzoate"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 38,
                    Name = "Guar Hydroxypropyltrimonium Chloride"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 39,
                    Name = "Magnesium Carbonate Hydroxide"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 40,
                    Name = "Methylchloroisothiazolinone"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 41,
                    Name = "Methylisothiazolinone"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 42,
                    Name = "Blue 1"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 43,
                    Name = "Red 33"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 44,
                    Name = "Water"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 45,
                    Name = "Glycol Distearate"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 46,
                    Name = "Zinc Carbonate"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 47,
                    Name = "Sodium Chloride"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 48,
                    Name = "Polyquaternium-7"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 49,
                    Name = "Sodium Benzoate"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 50,
                    Name = "Glycerin"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 51,
                    Name = "PEG-60 Almond Glycerides"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 52,
                    Name = "PEG-40 Hydrogenated Castor Oil"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 53,
                    Name = "Linum Usitatissimum (Linseed) Seed Extract"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 54,
                    Name = "Salvia Hispanica Seed Extract"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 55,
                    Name = "Hydrolyzed Rice Protein"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 56,
                    Name = "Nymphaea Lotus Flower Extract"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 57,
                    Name = "Melissa Officinalis Leaf Extract"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 58,
                    Name = "Humulus Lupulus (Hops) Extract"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 59,
                    Name = "Cymbopogon Schoenanthus Extract"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 60,
                    Name = "Chamomilla Recutita (Matricaria) Extract"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 61,
                    Name = "Rosmarinus Officinalis (Rosemary) Extract"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 62,
                    Name = "Achillea Millefolium Extract"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 63,
                    Name = "Hydroxyethylcellulose"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 64,
                    Name = "PEG-7 Glyceryl Cocoate"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 65,
                    Name = "Polyquaternium-10"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 66,
                    Name = "Propylene Glycol"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 67,
                    Name = "Hydroxypropyl Guar Hydroxypropyltrimonium Chloride"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 68,
                    Name = "Aminomethyl Propanol"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 69,
                    Name = "Phenoxyethanol"
                },
                new Ingredient()
                {
                    UserId = user.Id,
                    IngredientId = 70,
                    Name = "Ethylhexylglycerin"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    UserId = user.Id,
                    ProductId = 1,
                    Name = "Deva Curl Low Poo Delight",
                    UPC = 850963006195
                }
            );

            modelBuilder.Entity<ProductIngredient>().HasData(
                new ProductIngredient()
                {
                    ProductIngredientId = 1,
                    ProductId = 1,
                    IngredientId = 44
                },
                new ProductIngredient()
                {
                    ProductIngredientId = 2,
                    ProductId = 1,
                    IngredientId = 14
                },
                new ProductIngredient()
                {
                    ProductIngredientId = 3,
                    ProductId = 1,
                    IngredientId = 50
                },
                new ProductIngredient()
                {
                    ProductIngredientId = 4,
                    ProductId = 1,
                    IngredientId = 15
                },
                new ProductIngredient()
                {
                    ProductIngredientId = 5,
                    ProductId = 1,
                    IngredientId = 51
                },
                new ProductIngredient()
                {
                    ProductIngredientId = 6,
                    ProductId = 1,
                    IngredientId = 52
                },
                new ProductIngredient()
                {
                    ProductIngredientId = 7,
                    ProductId = 1,
                    IngredientId = 53
                },
                new ProductIngredient()
                {
                    ProductIngredientId = 8,
                    ProductId = 1,
                    IngredientId = 54
                },
                new ProductIngredient()
                {
                    ProductIngredientId = 9,
                    ProductId = 1,
                    IngredientId = 55
                },
                new ProductIngredient()
                {
                    ProductIngredientId = 10,
                    ProductId = 1,
                    IngredientId = 56
                },
                new ProductIngredient()
                {
                    ProductIngredientId = 11,
                    ProductId = 1,
                    IngredientId = 57
                },
                new ProductIngredient()
                {
                    ProductIngredientId = 12,
                    ProductId = 1,
                    IngredientId = 58
                },
                new ProductIngredient()
                {
                    ProductIngredientId = 13,
                    ProductId = 1,
                    IngredientId = 59
                },
                new ProductIngredient()
                {
                    ProductIngredientId = 14,
                    ProductId = 1,
                    IngredientId = 60
                },
                new ProductIngredient()
                {
                    ProductIngredientId = 15,
                    ProductId = 1,
                    IngredientId = 61
                },
                new ProductIngredient()
                {
                    ProductIngredientId = 16,
                    ProductId = 1,
                    IngredientId = 62
                },
                new ProductIngredient()
                {
                    ProductIngredientId = 17,
                    ProductId = 1,
                    IngredientId = 63
                },
                new ProductIngredient()
                {
                    ProductIngredientId = 18,
                    ProductId = 1,
                    IngredientId = 64
                },
                new ProductIngredient()
                {
                    ProductIngredientId = 19,
                    ProductId = 1,
                    IngredientId = 48
                },
                new ProductIngredient()
                {
                    ProductIngredientId = 20,
                    ProductId = 1,
                    IngredientId = 65
                },
                new ProductIngredient()
                {
                    ProductIngredientId = 21,
                    ProductId = 1,
                    IngredientId = 66
                },
                new ProductIngredient()
                {
                    ProductIngredientId = 22,
                    ProductId = 1,
                    IngredientId = 36
                },
                new ProductIngredient()
                {
                    ProductIngredientId = 23,
                    ProductId = 1,
                    IngredientId = 67
                },
                new ProductIngredient()
                {
                    ProductIngredientId = 24,
                    ProductId = 1,
                    IngredientId = 68
                },
                new ProductIngredient()
                {
                    ProductIngredientId = 25,
                    ProductId = 1,
                    IngredientId = 69
                },
                new ProductIngredient()
                {
                    ProductIngredientId = 26,
                    ProductId = 1,
                    IngredientId = 70
                }
            );

        }
    }
}
