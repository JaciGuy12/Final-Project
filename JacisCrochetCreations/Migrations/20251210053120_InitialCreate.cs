using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JacisCrochetCreations.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 80, nullable: false),
                    Category = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Stock = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    CartItemId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    AddedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.CartItemId);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Content = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false),
                    Rating = table.Column<int>(type: "INTEGER", nullable: false),
                    PostedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, "Scarf", "A warm and cozy striped crochet scarf with soft textured stitches.", "/img/cozystripedscarf.png", "Cozy Striped Scarf", 25m, 15 },
                    { 2, "Scarf", "Rich berry-toned scarf perfect for winter outfits.", "/img/winterberryscarf.png", "Winter Berry Scarf", 28m, 12 },
                    { 3, "Scarf", "A light pastel-colored scarf ideal for springtime weather.", "/img/pastelbreezescarf.png", "Pastel Breeze Scarf", 22m, 20 },
                    { 4, "Scarf", "A gradient scarf fading from golden yellow to deep rose tones.", "/img/sunsetfadescarf.png", "Sunset Fade Scarf", 30m, 10 },
                    { 5, "Scarf", "Extra-thick chunky crochet scarf for ultimate warmth and comfort.", "/img/chunkycomfortscarf.png", "Chunky Comfort Scarf", 35m, 8 },
                    { 6, "Bag", "A compact everyday pouch with a secure crochet finish.", "/img/minicrossbodybag.png", "Mini Crossbody Pouch", 15m, 25 },
                    { 7, "Bag", "A sturdy handmade tote bag perfect for grocery runs and errands.", "/img/markettote.png", "Market Tote Bag", 30m, 10 },
                    { 8, "Bag", "A colorful boho-inspired crocheted shoulder bag with long fringe.", "/img/crochetbohofringebag.png", "Boho Fringe Shoulder Bag", 40m, 10 },
                    { 9, "Bag", "A vibrant bag created from traditional multicolor granny squares.", "/img/floralgrannysquarebag.png", "Floral Granny Square Bag", 35m, 8 },
                    { 10, "Bag", "Striped tote bag perfect for sunny beach days and vacations.", "/img/summerstripebeachbag.png", "Summer Stripe Beach Bag", 32m, 10 },
                    { 11, "Plushie", "A soft handmade amigurumi bunny wearing a striped sweater.", "/img/crochetbunnyplushie.png", "Cozy Bunny Plush", 20m, 18 },
                    { 12, "Plushie", "A peaceful amigurumi bear with adorable sleepy eyes.", "/img/sleepybearplush.png", "Sleepy Bear Plush", 22m, 15 },
                    { 13, "Plushie", "A small green dinosaur plush perfect for kids and collectors.", "/img/dinosaurplush.png", "Tiny Dinosaur Plush", 18m, 20 },
                    { 14, "Plushie", "A soft pastel-colored crocheted kitten plushie.", "/img/pastelkitten.png", "Pastel Kitten Plush", 20m, 14 },
                    { 15, "Plushie", "A cute pink-and-white amigurumi cow with strawberry accents.", "/img/strawberrycow.png", "Strawberry Cow Plush", 25m, 12 },
                    { 16, "Sweater", "A warm oversized crochet cardigan perfect for layering.", "/img/cozycardigan.jpg", "Cozy Cardigan", 55m, 6 },
                    { 17, "Sweater", "A colorful granny-square inspired patchwork sweater.", "/img/vintagepatchworksweater.png", "Vintage Patchwork Sweater", 60m, 5 },
                    { 18, "Sweater", "A warm striped pullover inspired by fall colors.", "/img/autumnstripessweater.jpg", "Autumn Stripes Pullover", 50m, 7 },
                    { 19, "Sweater", "A trendy lavender crochet cropped sweater.", "/img/lavendersweater.jpg", "Lavender Cropped Sweater", 45m, 9 },
                    { 20, "Sweater", "A classic textured crochet sweater in soft teal yarn.", "/img/tealcablesweater.jpg", "Teal Cable Sweater", 65m, 4 },
                    { 21, "Blanket", "A super soft pastel baby blanket with gentle stitching.", "/img/crochetbabyblanket.png", "Baby Soft Blanket", 45m, 8 },
                    { 22, "Blanket", "A large warm throw blanket for living room comfort.", "/img/cozythrowblanket.jpg", "Cozy Throw Blanket", 55m, 5 },
                    { 23, "Blanket", "A brightly colored rainbow striped crochet blanket.", "/img/rainbowburst.jpg", "Rainbow Burst Blanket", 60m, 4 },
                    { 24, "Blanket", "A minimalist cream and taupe aesthetic crochet blanket.", "/img/neutralblanket.jpg", "Neutral Aesthetic Blanket", 50m, 6 },
                    { 25, "Blanket", "A handmade granny-square blanket with colorful patchwork.", "/img/grannysquareblanket.jpg", "Granny Square Patch Blanket", 65m, 3 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Content", "Name", "PostedOn", "ProductId", "Rating" },
                values: new object[,]
                {
                    { 1, "So soft and warm! The colors look even better in person.", "Emily", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5 },
                    { 2, "Perfect length and super comfy. Ships fast too!", "Sarah", new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4 },
                    { 3, "The berry colors are gorgeous! Very festive.", "Jordan", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 5 },
                    { 4, "Warm enough for cold mornings. Great stitch work.", "Mia", new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4 },
                    { 5, "The pastel shades are dreamy!", "Lily", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 5 },
                    { 6, "Lightweight and perfect for spring.", "Kate", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4 },
                    { 7, "The gradient is stunning. Truly handmade beauty.", "Ava", new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 5 },
                    { 8, "I get compliments every time I wear it.", "Hannah", new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 5 },
                    { 9, "So chunky and cozy – it’s like wearing a cloud.", "Olivia", new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5 },
                    { 10, "Warm and stylish, perfect for winter.", "Beth", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4 },
                    { 11, "Perfect little bag for on-the-go!", "Chloe", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 5 },
                    { 12, "Fits my phone and keys. Super cute.", "Grace", new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4 },
                    { 13, "Strong enough for groceries!", "Nora", new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 5 },
                    { 14, "Very durable and stylish.", "Jade", new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 4 },
                    { 15, "The fringe is everything – total boho vibes.", "Riley", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 5 },
                    { 16, "Spacious and unique. Love it!", "Tessa", new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 4 },
                    { 17, "Beautiful craftsmanship and colors.", "Hope", new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 5 },
                    { 18, "So colorful and cheerful. My favorite bag now.", "Lauren", new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 5 },
                    { 19, "Holds towels, sunscreen, snacks – amazing.", "Isla", new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 5 },
                    { 20, "Bright and summery!", "Zoey", new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 4 },
                    { 21, "Cutest bunny ever – so soft!", "Paige", new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 5 },
                    { 22, "Perfect gift for my niece.", "Ella", new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 5 },
                    { 23, "The sleepy eyes are adorable.", "Maddie", new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 5 },
                    { 24, "Great bedtime plush for kids.", "Sophie", new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 4 },
                    { 25, "Tiny and cute – perfect desk buddy.", "Leo", new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 5 },
                    { 26, "My son carries it everywhere.", "Ethan", new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 5 },
                    { 27, "The pastel colors are precious.", "Aria", new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 5 },
                    { 28, "Soft and well-made.", "Naomi", new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 4 },
                    { 29, "Strawberry cow is everything!", "Daisy", new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 5 },
                    { 30, "Adorable and unique plush.", "Clara", new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 5 },
                    { 31, "So warm and oversized. I’m obsessed.", "Hailey", new DateTime(2025, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 5 },
                    { 32, "Beautiful yarn texture.", "Jo", new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 4 },
                    { 33, "Retro and stylish – compliments guaranteed.", "Ivy", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 5 },
                    { 34, "Love the colors and patchwork.", "Rae", new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 4 },
                    { 35, "Perfect fall sweater.", "Bri", new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 5 },
                    { 36, "Warm and comfy.", "Kara", new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 4 },
                    { 37, "Cute and trendy. Love the lavender.", "Jess", new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 5 },
                    { 38, "Perfect with high-waisted jeans.", "Morgan", new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 5 },
                    { 39, "Gorgeous cable pattern.", "Renee", new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 5 },
                    { 40, "Very warm and cozy.", "Sky", new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 4 },
                    { 41, "Perfect baby shower gift – so soft.", "Lena", new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 5 },
                    { 42, "Gentle and snuggly.", "Becca", new DateTime(2025, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 5 },
                    { 43, "Use it every night on the couch.", "Tori", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 5 },
                    { 44, "Warm and lovely texture.", "Megan", new DateTime(2025, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 4 },
                    { 45, "Bright and cheerful – kids love it.", "Kayla", new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 5 },
                    { 46, "Beautiful colors and so fun.", "Jay", new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 4 },
                    { 47, "Fits my room aesthetic perfectly.", "Molly", new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 5 },
                    { 48, "Soft, cozy, and minimalist.", "Ciara", new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 5 },
                    { 49, "A work of art – so nostalgic.", "Lori", new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 5 },
                    { 50, "Colorful and feels handmade with love.", "Dani", new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
