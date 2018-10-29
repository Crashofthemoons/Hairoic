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
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false)
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
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d7dc5261-e790-46e5-b2eb-d9093e51cd08", 0, "e82ba2e5-91c9-496e-8572-878e2536019c", "jenn@gmail.com", true, false, null, "Jenn", "JENN@GMAIL.COM", "JENN@GMAIL.COM", "AQAAAAEAACcQAAAAELqGDeeLhOHM79Q7ZUWLzjgMsZR7vaWIo5IkkRQzhz/8yOj2IVN2Xsk2IsIo+hhT+g==", null, false, "3003fc45-de8e-447c-ad1e-0df4823688ca", false, "jenn@gmail.com" });

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "IngredientId", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, "Alkylbenzene Sulfonate", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 51, "PEG-60 Almond Glycerides", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 50, "Glycerin", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 49, "Sodium Benzoate", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 48, "Polyquaternium-7", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 47, "Sodium Chloride", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 46, "Zinc Carbonate", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 52, "PEG-40 Hydrogenated Castor Oil", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 45, "Glycol Distearate", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 43, "Red 33", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 42, "Blue 1", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 41, "Methylisothiazolinone", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 40, "Methylchloroisothiazolinone", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 39, "Magnesium Carbonate Hydroxide", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 38, "Guar Hydroxypropyltrimonium Chloride", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 44, "Water", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 37, "Sodium Benzoate", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 53, "Linum Usitatissimum (Linseed) Seed Extract", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 55, "Hydrolyzed Rice Protein", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 69, "Phenoxyethanol", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 68, "Aminomethyl Propanol", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 67, "Hydroxypropyl Guar Hydroxypropyltrimonium Chloride", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 66, "Propylene Glycol", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 65, "Polyquaternium-10", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 64, "PEG-7 Glyceryl Cocoate", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 54, "Salvia Hispanica Seed Extract", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 63, "Hydroxyethylcellulose", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 61, "Rosmarinus Officinalis (Rosemary) Extract", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 60, "Chamomilla Recutita (Matricaria) Extract", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 59, "Cymbopogon Schoenanthus Extract", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 58, "Humulus Lupulus (Hops) Extract", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 57, "Melissa Officinalis Leaf Extract", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 56, "Nymphaea Lotus Flower Extract", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 62, "Achillea Millefolium Extract", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 70, "Ethylhexylglycerin", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 36, "Fragrance", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 34, "Zinc Carbonate", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 15, "Coco Betaine", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 14, "Cocamidopropyl Betaine", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 13, "TEA-Dodecylbenzenesulfonate", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 12, "Sodium Lauryl Sulfoacetate", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 11, "Sodium Myreth", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 10, "Sodium Laureth", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 16, "Cocoamphoacetate", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 9, "Sodium Cocoyl Sarcosinate", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 7, "Ethyl PEG-15 Cocamine Sulfate", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 6, "Dioctyl Sodium Sulfosuccinate", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 5, "Sodium Xylenesulfonate", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 4, "Ammonium", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 3, "Lauryl Sulfate", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 2, "Ammonium Laureth", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 8, "Sodium C14-16 Cocamine Sulfate", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 35, "Sodium Chloride", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 17, "Cocoamphodipropionate", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 19, "Lauroamphoacetate", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 33, "Glycol Distearate", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 32, "Water", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 31, "Pyrithicone Zinc 1%", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 30, "Stearoxy Dimethicone", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 29, "Behenoxy Demethicone", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 28, "Trimethysilylamodimethicone", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 18, "Disodium Cocoamphodiacetate", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 27, "Cyclopentasiloxane", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 25, "Amodimethicone", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 24, "Stearyl Dimethicone", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 23, "Dimethicone", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 22, "Cetyl Dimethicone", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 21, "Cetearyl Methiocne", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 20, "Sodium Cocoyl Isethionate", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" },
                    { 26, "Cyclomethicone", "d7dc5261-e790-46e5-b2eb-d9093e51cd08" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Name", "UPC", "UserId" },
                values: new object[] { 1, "Deva Curl Low Poo Delight", 850963006195L, "d7dc5261-e790-46e5-b2eb-d9093e51cd08" });

            migrationBuilder.InsertData(
                table: "ProductIngredient",
                columns: new[] { "ProductIngredientId", "IngredientId", "ProductId" },
                values: new object[,]
                {
                    { 1, 44, 1 },
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
                    { 14, 60, 1 },
                    { 13, 59, 1 },
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
                    { 25, 69, 1 },
                    { 26, 70, 1 }
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
