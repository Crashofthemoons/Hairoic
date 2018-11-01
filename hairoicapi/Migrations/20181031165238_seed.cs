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
                values: new object[] { "e75defa0-369d-4d86-a0d6-41a43ed09db3", 0, "ad6afd35-c49e-446e-b0e8-2ec88e4901fa", "jenn@gmail.com", true, false, null, "JENN@GMAIL.COM", "JENN@GMAIL.COM", "AQAAAAEAACcQAAAAEJGkYu27s7g1CoMJPyfFwZLpaAMcz0cLhbxFcqvlDztuTR6lSgl1mIcyQGZTuzHbPw==", null, false, "e962f8e8-53a2-4af2-aa50-785a49a6cd11", false, "jenn@gmail.com" });

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "IngredientId", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, "Alkylbenzene Sulfonate", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 51, "PEG-60 Almond Glycerides", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 50, "Glycerin", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 49, "Sodium Benzoate", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 48, "Polyquaternium-7", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 47, "Sodium Chloride", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 46, "Zinc Carbonate", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 52, "PEG-40 Hydrogenated Castor Oil", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 45, "Glycol Distearate", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 43, "Red 33", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 42, "Blue 1", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 41, "Methylisothiazolinone", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 40, "Methylchloroisothiazolinone", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 39, "Magnesium Carbonate Hydroxide", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 38, "Guar Hydroxypropyltrimonium Chloride", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 44, "Water", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 37, "Sodium Benzoate", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 53, "Linum Usitatissimum (Linseed) Seed Extract", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 55, "Hydrolyzed Rice Protein", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 69, "Phenoxyethanol", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 68, "Aminomethyl Propanol", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 67, "Hydroxypropyl Guar Hydroxypropyltrimonium Chloride", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 66, "Propylene Glycol", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 65, "Polyquaternium-10", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 64, "PEG-7 Glyceryl Cocoate", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 54, "Salvia Hispanica Seed Extract", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 63, "Hydroxyethylcellulose", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 61, "Rosmarinus Officinalis (Rosemary) Extract", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 60, "Chamomilla Recutita (Matricaria) Extract", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 59, "Cymbopogon Schoenanthus Extract", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 58, "Humulus Lupulus (Hops) Extract", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 57, "Melissa Officinalis Leaf Extract", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 56, "Nymphaea Lotus Flower Extract", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 62, "Achillea Millefolium Extract", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 70, "Ethylhexylglycerin", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 36, "Fragrance", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 34, "Zinc Carbonate", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 15, "Coco Betaine", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 14, "Cocamidopropyl Betaine", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 13, "TEA-Dodecylbenzenesulfonate", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 12, "Sodium Lauryl Sulfoacetate", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 11, "Sodium Myreth", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 10, "Sodium Laureth", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 16, "Cocoamphoacetate", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 9, "Sodium Cocoyl Sarcosinate", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 7, "Ethyl PEG-15 Cocamine Sulfate", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 6, "Dioctyl Sodium Sulfosuccinate", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 5, "Sodium Xylenesulfonate", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 4, "Ammonium", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 3, "Lauryl Sulfate", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 2, "Ammonium Laureth", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 8, "Sodium C14-16 Cocamine Sulfate", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 35, "Sodium Chloride", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 17, "Cocoamphodipropionate", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 19, "Lauroamphoacetate", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 33, "Glycol Distearate", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 32, "Water", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 31, "Pyrithicone Zinc 1%", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 30, "Stearoxy Dimethicone", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 29, "Behenoxy Demethicone", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 28, "Trimethysilylamodimethicone", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 18, "Disodium Cocoamphodiacetate", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 27, "Cyclopentasiloxane", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 25, "Amodimethicone", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 24, "Stearyl Dimethicone", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 23, "Dimethicone", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 22, "Cetyl Dimethicone", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 21, "Cetearyl Methiocne", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 20, "Sodium Cocoyl Isethionate", "e75defa0-369d-4d86-a0d6-41a43ed09db3" },
                    { 26, "Cyclomethicone", "e75defa0-369d-4d86-a0d6-41a43ed09db3" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Name", "UPC", "UserId" },
                values: new object[] { 1, "Deva Curl Low Poo Delight", 850963006195L, "e75defa0-369d-4d86-a0d6-41a43ed09db3" });

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
