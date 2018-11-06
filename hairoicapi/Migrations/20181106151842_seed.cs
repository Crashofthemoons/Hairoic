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
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    UPC = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ProductIngredient_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "811e68cc-939e-4300-9561-bb4834326c31", 0, "3f2e8742-d739-41ff-afc1-6322f5972bd2", "jenn@gmail.com", true, false, null, "JENN@GMAIL.COM", "JENN@GMAIL.COM", "AQAAAAEAACcQAAAAEA4yzWwxxZNTRdksv3mfiBuvtSo7KLcE6YqsNlOvB8GOKc4CX7xdX2cdEcjK2i+j2g==", null, false, "5d572cd0-d71c-40f2-80b4-ed8e185bd65c", false, "jenn@gmail.com" });

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "IngredientId", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, "Alkylbenzene Sulfonate", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 37, "Sodium Benzoate", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 38, "Guar Hydroxypropyltrimonium Chloride", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 39, "Magnesium Carbonate Hydroxide", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 40, "Methylchloroisothiazolinone", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 41, "Methylisothiazolinone", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 42, "Blue 1", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 43, "Red 33", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 48, "Polyquaternium-7", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 50, "Glycerin", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 51, "PEG-60 Almond Glycerides", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 52, "PEG-40 Hydrogenated Castor Oil", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 53, "Linum Usitatissimum (Linseed) Seed Extract", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 54, "Salvia Hispanica Seed Extract", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 55, "Hydrolyzed Rice Protein", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 36, "Fragrance", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 56, "Nymphaea Lotus Flower Extract", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 58, "Humulus Lupulus (Hops) Extract", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 59, "Cymbopogon Schoenanthus Extract", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 60, "Chamomilla Recutita (Matricaria) Extract", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 61, "Rosmarinus Officinalis (Rosemary) Extract", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 62, "Achillea Millefolium Extract", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 63, "Hydroxyethylcellulose", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 64, "PEG-7 Glyceryl Cocoate", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 65, "Polyquaternium-10", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 66, "Propylene Glycol", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 67, "Hydroxypropyl Guar Hydroxypropyltrimonium Chloride", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 68, "Aminomethyl Propanol", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 69, "Phenoxyethanol", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 70, "Ethylhexylglycerin", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 71, "Argania Spinosa Kernel Oil", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 57, "Melissa Officinalis Leaf Extract", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 35, "Sodium Chloride", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 34, "Zinc Carbonate", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 33, "Glycol Distearate", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 2, "Ammonium Laureth", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 3, "Lauryl Sulfate", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 4, "Ammonium", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 5, "Sodium Xylenesulfonate", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 6, "Dioctyl Sodium Sulfosuccinate", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 7, "Ethyl PEG-15 Cocamine Sulfate", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 8, "Sodium C14-16 Cocamine Sulfate", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 9, "Sodium Cocoyl Sarcosinate", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 10, "Sodium Laureth", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 11, "Sodium Myreth", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 12, "Sodium Lauryl Sulfoacetate", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 13, "TEA-Dodecylbenzenesulfonate", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 14, "Cocamidopropyl Betaine", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 15, "Coco Betaine", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 16, "Cocoamphoacetate", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 17, "Cocoamphodipropionate", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 18, "Disodium Cocoamphodiacetate", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 32, "Water", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 31, "Pyrithicone Zinc 1%", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 30, "Stearoxy Dimethicone", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 29, "Behenoxy Demethicone", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 28, "Trimethysilylamodimethicone", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 27, "Cyclopentasiloxane", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 26, "Cyclomethicone", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 24, "Stearyl Dimethicone", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 23, "Dimethicone", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 22, "Cetyl Dimethicone", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 21, "Cetearyl Methiocne", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 20, "Sodium Cocoyl Isethionate", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 19, "Lauroamphoacetate", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 25, "Amodimethicone", "811e68cc-939e-4300-9561-bb4834326c31" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Name", "UPC", "UserId" },
                values: new object[,]
                {
                    { 1, "Deva Curl Low Poo Delight", "850963006195", "811e68cc-939e-4300-9561-bb4834326c31" },
                    { 2, "Shea Moisture 100% Pure Argan Oil", "764302204022", "811e68cc-939e-4300-9561-bb4834326c31" }
                });

            migrationBuilder.InsertData(
                table: "ProductIngredient",
                columns: new[] { "ProductIngredientId", "IngredientId", "ProductId" },
                values: new object[,]
                {
                    { 1, 32, 1 },
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
