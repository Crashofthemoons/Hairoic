﻿// <auto-generated />
using System;
using HairoicAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HairoicAPI.Migrations
{
    [DbContext(typeof(HairoicAPIContext))]
    partial class HairoicAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HairoicAPI.Models.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("UserId");

                    b.HasKey("IngredientId");

                    b.HasIndex("UserId");

                    b.ToTable("Ingredient");

                    b.HasData(
                        new { IngredientId = 1, Name = "Alkylbenzene Sulfonate", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 2, Name = "Ammonium Laureth", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 3, Name = "Lauryl Sulfate", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 4, Name = "Ammonium", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 5, Name = "Sodium Xylenesulfonate", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 6, Name = "Dioctyl Sodium Sulfosuccinate", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 7, Name = "Ethyl PEG-15 Cocamine Sulfate", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 8, Name = "Sodium C14-16 Cocamine Sulfate", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 9, Name = "Sodium Cocoyl Sarcosinate", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 10, Name = "Sodium Laureth", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 11, Name = "Sodium Myreth", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 12, Name = "Sodium Lauryl Sulfoacetate", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 13, Name = "TEA-Dodecylbenzenesulfonate", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 14, Name = "Cocamidopropyl Betaine", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 15, Name = "Coco Betaine", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 16, Name = "Cocoamphoacetate", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 17, Name = "Cocoamphodipropionate", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 18, Name = "Disodium Cocoamphodiacetate", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 19, Name = "Lauroamphoacetate", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 20, Name = "Sodium Cocoyl Isethionate", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 21, Name = "Cetearyl Methiocne", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 22, Name = "Cetyl Dimethicone", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 23, Name = "Dimethicone", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 24, Name = "Stearyl Dimethicone", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 25, Name = "Amodimethicone", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 26, Name = "Cyclomethicone", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 27, Name = "Cyclopentasiloxane", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 28, Name = "Trimethysilylamodimethicone", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 29, Name = "Behenoxy Demethicone", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 30, Name = "Stearoxy Dimethicone", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 31, Name = "Pyrithicone Zinc 1%", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 32, Name = "Water", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 33, Name = "Glycol Distearate", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 34, Name = "Zinc Carbonate", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 35, Name = "Sodium Chloride", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 36, Name = "Fragrance", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 37, Name = "Sodium Benzoate", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 38, Name = "Guar Hydroxypropyltrimonium Chloride", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 39, Name = "Magnesium Carbonate Hydroxide", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 40, Name = "Methylchloroisothiazolinone", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 41, Name = "Methylisothiazolinone", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 42, Name = "Blue 1", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 43, Name = "Red 33", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 48, Name = "Polyquaternium-7", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 50, Name = "Glycerin", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 51, Name = "PEG-60 Almond Glycerides", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 52, Name = "PEG-40 Hydrogenated Castor Oil", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 53, Name = "Linum Usitatissimum (Linseed) Seed Extract", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 54, Name = "Salvia Hispanica Seed Extract", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 55, Name = "Hydrolyzed Rice Protein", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 56, Name = "Nymphaea Lotus Flower Extract", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 57, Name = "Melissa Officinalis Leaf Extract", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 58, Name = "Humulus Lupulus (Hops) Extract", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 59, Name = "Cymbopogon Schoenanthus Extract", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 60, Name = "Chamomilla Recutita (Matricaria) Extract", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 61, Name = "Rosmarinus Officinalis (Rosemary) Extract", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 62, Name = "Achillea Millefolium Extract", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 63, Name = "Hydroxyethylcellulose", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 64, Name = "PEG-7 Glyceryl Cocoate", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 65, Name = "Polyquaternium-10", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 66, Name = "Propylene Glycol", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 67, Name = "Hydroxypropyl Guar Hydroxypropyltrimonium Chloride", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 68, Name = "Aminomethyl Propanol", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 69, Name = "Phenoxyethanol", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 70, Name = "Ethylhexylglycerin", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { IngredientId = 71, Name = "Argania Spinosa Kernel Oil", UserId = "811e68cc-939e-4300-9561-bb4834326c31" }
                    );
                });

            modelBuilder.Entity("HairoicAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("UPC")
                        .IsRequired();

                    b.Property<string>("UserId");

                    b.HasKey("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Product");

                    b.HasData(
                        new { ProductId = 1, Name = "Deva Curl Low Poo Delight", UPC = "850963006195", UserId = "811e68cc-939e-4300-9561-bb4834326c31" },
                        new { ProductId = 2, Name = "Shea Moisture 100% Pure Argan Oil", UPC = "764302204022", UserId = "811e68cc-939e-4300-9561-bb4834326c31" }
                    );
                });

            modelBuilder.Entity("HairoicAPI.Models.ProductIngredient", b =>
                {
                    b.Property<int>("ProductIngredientId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IngredientId");

                    b.Property<int>("ProductId");

                    b.HasKey("ProductIngredientId");

                    b.HasIndex("IngredientId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductIngredient");

                    b.HasData(
                        new { ProductIngredientId = 1, IngredientId = 32, ProductId = 1 },
                        new { ProductIngredientId = 2, IngredientId = 14, ProductId = 1 },
                        new { ProductIngredientId = 3, IngredientId = 50, ProductId = 1 },
                        new { ProductIngredientId = 4, IngredientId = 15, ProductId = 1 },
                        new { ProductIngredientId = 5, IngredientId = 51, ProductId = 1 },
                        new { ProductIngredientId = 6, IngredientId = 52, ProductId = 1 },
                        new { ProductIngredientId = 7, IngredientId = 53, ProductId = 1 },
                        new { ProductIngredientId = 8, IngredientId = 54, ProductId = 1 },
                        new { ProductIngredientId = 9, IngredientId = 55, ProductId = 1 },
                        new { ProductIngredientId = 10, IngredientId = 56, ProductId = 1 },
                        new { ProductIngredientId = 11, IngredientId = 57, ProductId = 1 },
                        new { ProductIngredientId = 12, IngredientId = 58, ProductId = 1 },
                        new { ProductIngredientId = 13, IngredientId = 59, ProductId = 1 },
                        new { ProductIngredientId = 14, IngredientId = 60, ProductId = 1 },
                        new { ProductIngredientId = 15, IngredientId = 61, ProductId = 1 },
                        new { ProductIngredientId = 16, IngredientId = 62, ProductId = 1 },
                        new { ProductIngredientId = 17, IngredientId = 63, ProductId = 1 },
                        new { ProductIngredientId = 18, IngredientId = 64, ProductId = 1 },
                        new { ProductIngredientId = 19, IngredientId = 48, ProductId = 1 },
                        new { ProductIngredientId = 20, IngredientId = 65, ProductId = 1 },
                        new { ProductIngredientId = 21, IngredientId = 66, ProductId = 1 },
                        new { ProductIngredientId = 22, IngredientId = 36, ProductId = 1 },
                        new { ProductIngredientId = 23, IngredientId = 67, ProductId = 1 },
                        new { ProductIngredientId = 24, IngredientId = 68, ProductId = 1 },
                        new { ProductIngredientId = 25, IngredientId = 69, ProductId = 1 },
                        new { ProductIngredientId = 26, IngredientId = 70, ProductId = 1 },
                        new { ProductIngredientId = 27, IngredientId = 71, ProductId = 2 }
                    );
                });

            modelBuilder.Entity("HairoicAPI.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new { Id = "811e68cc-939e-4300-9561-bb4834326c31", AccessFailedCount = 0, ConcurrencyStamp = "3f2e8742-d739-41ff-afc1-6322f5972bd2", Email = "jenn@gmail.com", EmailConfirmed = true, LockoutEnabled = false, NormalizedEmail = "JENN@GMAIL.COM", NormalizedUserName = "JENN@GMAIL.COM", PasswordHash = "AQAAAAEAACcQAAAAEA4yzWwxxZNTRdksv3mfiBuvtSo7KLcE6YqsNlOvB8GOKc4CX7xdX2cdEcjK2i+j2g==", PhoneNumberConfirmed = false, SecurityStamp = "5d572cd0-d71c-40f2-80b4-ed8e185bd65c", TwoFactorEnabled = false, UserName = "jenn@gmail.com" }
                    );
                });

            modelBuilder.Entity("HairoicAPI.Models.Ingredient", b =>
                {
                    b.HasOne("HairoicAPI.Models.User", "User")
                        .WithMany("Ingredients")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("HairoicAPI.Models.Product", b =>
                {
                    b.HasOne("HairoicAPI.Models.User", "User")
                        .WithMany("Products")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("HairoicAPI.Models.ProductIngredient", b =>
                {
                    b.HasOne("HairoicAPI.Models.Ingredient", "Ingredient")
                        .WithMany("ProductIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HairoicAPI.Models.Product", "Product")
                        .WithMany("ProductIngredients")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
