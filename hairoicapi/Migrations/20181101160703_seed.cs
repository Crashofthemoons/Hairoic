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
                    UserId = table.Column<string>(nullable: false)
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
                    UPC = table.Column<long>(nullable: false),
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
                values: new object[] { "ac5e977a-a970-4cdc-80e1-51e37d0866ef", 0, "e55edee9-99b5-4a4b-8611-e8d21e624cea", "jenn@gmail.com", true, false, null, "JENN@GMAIL.COM", "JENN@GMAIL.COM", "AQAAAAEAACcQAAAAEC89tL3B6m4wqE1uKPpgHyQ+od6IpD18IAp9zd3AjWfq0N57FUkZGcEV1o6L3rNqkw==", null, false, "e099d404-7358-45ec-8ed6-fb995916423d", false, "jenn@gmail.com" });

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "IngredientId", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, "Alkylbenzene Sulfonate", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 53, "Linum Usitatissimum (Linseed) Seed Extract", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 52, "PEG-40 Hydrogenated Castor Oil", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 51, "PEG-60 Almond Glycerides", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 50, "Glycerin", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 49, "Sodium Benzoate", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 48, "Polyquaternium-7", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 54, "Salvia Hispanica Seed Extract", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 47, "Sodium Chloride", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 45, "Glycol Distearate", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 44, "Water", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 43, "Red 33", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 42, "Blue 1", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 41, "Methylisothiazolinone", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 40, "Methylchloroisothiazolinone", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 46, "Zinc Carbonate", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 39, "Magnesium Carbonate Hydroxide", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 55, "Hydrolyzed Rice Protein", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 57, "Melissa Officinalis Leaf Extract", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 71, "Argania Spinosa Kernel Oil", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 70, "Ethylhexylglycerin", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 69, "Phenoxyethanol", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 68, "Aminomethyl Propanol", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 67, "Hydroxypropyl Guar Hydroxypropyltrimonium Chloride", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 66, "Propylene Glycol", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 56, "Nymphaea Lotus Flower Extract", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 65, "Polyquaternium-10", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 63, "Hydroxyethylcellulose", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 62, "Achillea Millefolium Extract", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 61, "Rosmarinus Officinalis (Rosemary) Extract", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 60, "Chamomilla Recutita (Matricaria) Extract", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 59, "Cymbopogon Schoenanthus Extract", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 58, "Humulus Lupulus (Hops) Extract", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 64, "PEG-7 Glyceryl Cocoate", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 38, "Guar Hydroxypropyltrimonium Chloride", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 37, "Sodium Benzoate", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 18, "Disodium Cocoamphodiacetate", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 17, "Cocoamphodipropionate", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 16, "Cocoamphoacetate", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 15, "Coco Betaine", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 14, "Cocamidopropyl Betaine", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 13, "TEA-Dodecylbenzenesulfonate", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 12, "Sodium Lauryl Sulfoacetate", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 36, "Fragrance", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 11, "Sodium Myreth", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 9, "Sodium Cocoyl Sarcosinate", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 8, "Sodium C14-16 Cocamine Sulfate", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 7, "Ethyl PEG-15 Cocamine Sulfate", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 6, "Dioctyl Sodium Sulfosuccinate", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 5, "Sodium Xylenesulfonate", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 4, "Ammonium", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 10, "Sodium Laureth", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 3, "Lauryl Sulfate", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 19, "Lauroamphoacetate", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 21, "Cetearyl Methiocne", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 35, "Sodium Chloride", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 34, "Zinc Carbonate", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 33, "Glycol Distearate", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 32, "Water", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 31, "Pyrithicone Zinc 1%", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 30, "Stearoxy Dimethicone", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 20, "Sodium Cocoyl Isethionate", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 29, "Behenoxy Demethicone", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 27, "Cyclopentasiloxane", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 26, "Cyclomethicone", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 25, "Amodimethicone", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 24, "Stearyl Dimethicone", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 23, "Dimethicone", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 22, "Cetyl Dimethicone", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 28, "Trimethysilylamodimethicone", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 2, "Ammonium Laureth", "ac5e977a-a970-4cdc-80e1-51e37d0866ef" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Name", "UPC", "UserId" },
                values: new object[,]
                {
                    { 1, "Deva Curl Low Poo Delight", 850963006195L, "ac5e977a-a970-4cdc-80e1-51e37d0866ef" },
                    { 2, "Shea Moisture 100% Pure Argan Oil", 764302204022L, "ac5e977a-a970-4cdc-80e1-51e37d0866ef" }
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
