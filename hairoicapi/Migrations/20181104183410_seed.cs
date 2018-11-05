using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HairoicAPI.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    IngredientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.IngredientId);
                    table.ForeignKey(
                        name: "FK_Ingredient_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    UPC = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductIngredient",
                columns: table => new
                {
                    ProductIngredientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    IngredientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductIngredient", x => x.ProductIngredientId);
                    table.ForeignKey(
                        name: "FK_ProductIngredient_Ingredient_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredient",
                        principalColumn: "IngredientId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductIngredient_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dbdc519b-06fb-4fd9-ba7a-141effba3719", 0, "abb8abf2-17f0-48e9-9823-7799aefcf5f8", "jenn@gmail.com", true, false, null, "JENN@GMAIL.COM", "JENN@GMAIL.COM", "AQAAAAEAACcQAAAAEF9iMJQCSSYWqbPgwGU2FsnvwQdyiosJQP0Owu/6byuK+EFC77ZUsZHPoM/Xhxtgvw==", null, false, "6e78638d-8e96-4d79-8d47-5b4c8b25f13c", false, "jenn@gmail.com" });

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "IngredientId", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, "Alkylbenzene Sulfonate", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 53, "Linum Usitatissimum (Linseed) Seed Extract", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 52, "PEG-40 Hydrogenated Castor Oil", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 51, "PEG-60 Almond Glycerides", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 50, "Glycerin", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 49, "Sodium Benzoate", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 48, "Polyquaternium-7", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 54, "Salvia Hispanica Seed Extract", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 47, "Sodium Chloride", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 45, "Glycol Distearate", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 44, "Water", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 43, "Red 33", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 42, "Blue 1", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 41, "Methylisothiazolinone", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 40, "Methylchloroisothiazolinone", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 46, "Zinc Carbonate", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 39, "Magnesium Carbonate Hydroxide", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 55, "Hydrolyzed Rice Protein", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 57, "Melissa Officinalis Leaf Extract", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 71, "Argania Spinosa Kernel Oil", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 70, "Ethylhexylglycerin", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 69, "Phenoxyethanol", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 68, "Aminomethyl Propanol", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 67, "Hydroxypropyl Guar Hydroxypropyltrimonium Chloride", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 66, "Propylene Glycol", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 56, "Nymphaea Lotus Flower Extract", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 65, "Polyquaternium-10", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 63, "Hydroxyethylcellulose", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 62, "Achillea Millefolium Extract", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 61, "Rosmarinus Officinalis (Rosemary) Extract", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 60, "Chamomilla Recutita (Matricaria) Extract", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 59, "Cymbopogon Schoenanthus Extract", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 58, "Humulus Lupulus (Hops) Extract", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 64, "PEG-7 Glyceryl Cocoate", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 38, "Guar Hydroxypropyltrimonium Chloride", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 37, "Sodium Benzoate", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 18, "Disodium Cocoamphodiacetate", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 17, "Cocoamphodipropionate", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 16, "Cocoamphoacetate", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 15, "Coco Betaine", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 14, "Cocamidopropyl Betaine", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 13, "TEA-Dodecylbenzenesulfonate", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 12, "Sodium Lauryl Sulfoacetate", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 36, "Fragrance", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 11, "Sodium Myreth", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 9, "Sodium Cocoyl Sarcosinate", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 8, "Sodium C14-16 Cocamine Sulfate", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 7, "Ethyl PEG-15 Cocamine Sulfate", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 6, "Dioctyl Sodium Sulfosuccinate", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 5, "Sodium Xylenesulfonate", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 4, "Ammonium", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 10, "Sodium Laureth", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 3, "Lauryl Sulfate", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 19, "Lauroamphoacetate", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 21, "Cetearyl Methiocne", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 35, "Sodium Chloride", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 34, "Zinc Carbonate", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 33, "Glycol Distearate", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 32, "Water", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 31, "Pyrithicone Zinc 1%", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 30, "Stearoxy Dimethicone", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 20, "Sodium Cocoyl Isethionate", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 29, "Behenoxy Demethicone", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 27, "Cyclopentasiloxane", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 26, "Cyclomethicone", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 25, "Amodimethicone", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 24, "Stearyl Dimethicone", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 23, "Dimethicone", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 22, "Cetyl Dimethicone", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 28, "Trimethysilylamodimethicone", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 2, "Ammonium Laureth", "dbdc519b-06fb-4fd9-ba7a-141effba3719" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Name", "UPC", "UserId" },
                values: new object[,]
                {
                    { 1, "Deva Curl Low Poo Delight", "850963006195", "dbdc519b-06fb-4fd9-ba7a-141effba3719" },
                    { 2, "Shea Moisture 100% Pure Argan Oil", "764302204022", "dbdc519b-06fb-4fd9-ba7a-141effba3719" }
                });

            migrationBuilder.InsertData(
                table: "ProductIngredient",
                columns: new[] { "ProductIngredientId", "IngredientId", "ProductId" },
                values: new object[,]
                {
                    { 1, 44, 1 },
                    { 25, 69, 1 },
                    { 24, 68, 1 },
                    { 23, 67, 1 },
                    { 22, 36, 1 },
                    { 21, 66, 1 },
                    { 20, 65, 1 },
                    { 19, 48, 1 },
                    { 18, 64, 1 },
                    { 17, 63, 1 },
                    { 16, 62, 1 },
                    { 15, 61, 1 },
                    { 26, 70, 1 },
                    { 14, 60, 1 },
                    { 12, 58, 1 },
                    { 11, 57, 1 },
                    { 10, 56, 1 },
                    { 9, 55, 1 },
                    { 8, 54, 1 },
                    { 7, 53, 1 },
                    { 6, 52, 1 },
                    { 5, 51, 1 },
                    { 4, 15, 1 },
                    { 3, 50, 1 },
                    { 2, 14, 1 },
                    { 13, 59, 1 },
                    { 27, 71, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_UserId",
                table: "Ingredient",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_UserId",
                table: "Product",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductIngredient_IngredientId",
                table: "ProductIngredient",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductIngredient_ProductId",
                table: "ProductIngredient",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductIngredient");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
