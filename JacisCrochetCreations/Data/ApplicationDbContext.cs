using JacisCrochetCreations.Models;
using Microsoft.EntityFrameworkCore;

namespace JacisCrochetCreations.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Product)
                .WithMany(p => p.Reviews)
                .HasForeignKey(r => r.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

         
            modelBuilder.Entity<Product>().HasData(

                // scarves
                new Product {
                    ProductId = 1,
                    Name = "Cozy Striped Scarf",
                    Category = "Scarf",
                    Price = 25,
                    Stock = 15,
                    Description = "A warm and cozy striped crochet scarf with soft textured stitches.",
                    ImageUrl = "/img/cozystripedscarf.png"
                },

                new Product {
                    ProductId = 2,
                    Name = "Winter Berry Scarf",
                    Category = "Scarf",
                    Price = 28,
                    Stock = 12,
                    Description = "Rich berry-toned scarf perfect for winter outfits.",
                    ImageUrl = "/img/winterberryscarf.png"
                },

                new Product {
                    ProductId = 3,
                    Name = "Pastel Breeze Scarf",
                    Category = "Scarf",
                    Price = 22,
                    Stock = 20,
                    Description = "A light pastel-colored scarf ideal for springtime weather.",
                    ImageUrl = "/img/pastelbreezescarf.png"
                },

                new Product {
                    ProductId = 4,
                    Name = "Sunset Fade Scarf",
                    Category = "Scarf",
                    Price = 30,
                    Stock = 10,
                    Description = "A gradient scarf fading from golden yellow to deep rose tones.",
                    ImageUrl = "/img/sunsetfadescarf.png"
                },

                new Product {
                    ProductId = 5,
                    Name = "Chunky Comfort Scarf",
                    Category = "Scarf",
                    Price = 35,
                    Stock = 8,
                    Description = "Extra-thick chunky crochet scarf for ultimate warmth and comfort.",
                    ImageUrl = "/img/chunkycomfortscarf.png"
                },

                // bags
                new Product {
                    ProductId = 6,
                    Name = "Mini Crossbody Pouch",
                    Category = "Bag",
                    Price = 15,
                    Stock = 25,
                    Description = "A compact everyday pouch with a secure crochet finish.",
                    ImageUrl = "/img/minicrossbodybag.png"
                },

                new Product {
                    ProductId = 7,
                    Name = "Market Tote Bag",
                    Category = "Bag",
                    Price = 30,
                    Stock = 10,
                    Description = "A sturdy handmade tote bag perfect for grocery runs and errands.",
                    ImageUrl = "/img/markettote.png"
                },

                new Product {
                    ProductId = 8,
                    Name = "Boho Fringe Shoulder Bag",
                    Category = "Bag",
                    Price = 40,
                    Stock = 10,
                    Description = "A colorful boho-inspired crocheted shoulder bag with long fringe.",
                    ImageUrl = "/img/crochetbohofringebag.png"
                },

                new Product {
                    ProductId = 9,
                    Name = "Floral Granny Square Bag",
                    Category = "Bag",
                    Price = 35,
                    Stock = 8,
                    Description = "A vibrant bag created from traditional multicolor granny squares.",
                    ImageUrl = "/img/floralgrannysquarebag.png"
                },

                new Product {
                    ProductId = 10,
                    Name = "Summer Stripe Beach Bag",
                    Category = "Bag",
                    Price = 32,
                    Stock = 10,
                    Description = "Striped tote bag perfect for sunny beach days and vacations.",
                    ImageUrl = "/img/summerstripebeachbag.png"
                },

                // amigurumi plushies
                new Product {
                    ProductId = 11,
                    Name = "Cozy Bunny Plush",
                    Category = "Plushie",
                    Price = 20,
                    Stock = 18,
                    Description = "A soft handmade amigurumi bunny wearing a striped sweater.",
                    ImageUrl = "/img/crochetbunnyplushie.png"
                },

                new Product {
                    ProductId = 12,
                    Name = "Sleepy Bear Plush",
                    Category = "Plushie",
                    Price = 22,
                    Stock = 15,
                    Description = "A peaceful amigurumi bear with adorable sleepy eyes.",
                    ImageUrl = "/img/sleepybearplush.png"
                },

                new Product {
                    ProductId = 13,
                    Name = "Tiny Dinosaur Plush",
                    Category = "Plushie",
                    Price = 18,
                    Stock = 20,
                    Description = "A small green dinosaur plush perfect for kids and collectors.",
                    ImageUrl = "/img/dinosaurplush.png"
                },

                new Product {
                    ProductId = 14,
                    Name = "Pastel Kitten Plush",
                    Category = "Plushie",
                    Price = 20,
                    Stock = 14,
                    Description = "A soft pastel-colored crocheted kitten plushie.",
                    ImageUrl = "/img/pastelkitten.png"
                },

                new Product {
                    ProductId = 15,
                    Name = "Strawberry Cow Plush",
                    Category = "Plushie",
                    Price = 25,
                    Stock = 12,
                    Description = "A cute pink-and-white amigurumi cow with strawberry accents.",
                    ImageUrl = "/img/strawberrycow.png"
                },

                // -sweaters
                new Product {
                    ProductId = 16,
                    Name = "Cozy Cardigan",
                    Category = "Sweater",
                    Price = 55,
                    Stock = 6,
                    Description = "A warm oversized crochet cardigan perfect for layering.",
                    ImageUrl = "/img/cozycardigan.jpg"
                },

                new Product {
                    ProductId = 17,
                    Name = "Vintage Patchwork Sweater",
                    Category = "Sweater",
                    Price = 60,
                    Stock = 5,
                    Description = "A colorful granny-square inspired patchwork sweater.",
                    ImageUrl = "/img/vintagepatchworksweater.png"
                },

                new Product {
                    ProductId = 18,
                    Name = "Autumn Stripes Pullover",
                    Category = "Sweater",
                    Price = 50,
                    Stock = 7,
                    Description = "A warm striped pullover inspired by fall colors.",
                    ImageUrl = "/img/autumnstripessweater.jpg"
                },

                new Product {
                    ProductId = 19,
                    Name = "Lavender Cropped Sweater",
                    Category = "Sweater",
                    Price = 45,
                    Stock = 9,
                    Description = "A trendy lavender crochet cropped sweater.",
                    ImageUrl = "/img/lavendersweater.jpg"
                },

                new Product {
                    ProductId = 20,
                    Name = "Teal Cable Sweater",
                    Category = "Sweater",
                    Price = 65,
                    Stock = 4,
                    Description = "A classic textured crochet sweater in soft teal yarn.",
                    ImageUrl = "/img/tealcablesweater.jpg"
                },

                // blankets
                new Product {
                    ProductId = 21,
                    Name = "Baby Soft Blanket",
                    Category = "Blanket",
                    Price = 45,
                    Stock = 8,
                    Description = "A super soft pastel baby blanket with gentle stitching.",
                    ImageUrl = "/img/crochetbabyblanket.png"
                },

                new Product {
                    ProductId = 22,
                    Name = "Cozy Throw Blanket",
                    Category = "Blanket",
                    Price = 55,
                    Stock = 5,
                    Description = "A large warm throw blanket for living room comfort.",
                    ImageUrl = "/img/cozythrowblanket.jpg"
                },

                new Product {
                    ProductId = 23,
                    Name = "Rainbow Burst Blanket",
                    Category = "Blanket",
                    Price = 60,
                    Stock = 4,
                    Description = "A brightly colored rainbow striped crochet blanket.",
                    ImageUrl = "/img/rainbowburst.jpg"
                },

                new Product {
                    ProductId = 24,
                    Name = "Neutral Aesthetic Blanket",
                    Category = "Blanket",
                    Price = 50,
                    Stock = 6,
                    Description = "A minimalist cream and taupe aesthetic crochet blanket.",
                    ImageUrl = "/img/neutralblanket.jpg"
                },

                new Product {
                    ProductId = 25,
                    Name = "Granny Square Patch Blanket",
                    Category = "Blanket",
                    Price = 65,
                    Stock = 3,
                    Description = "A handmade granny-square blanket with colorful patchwork.",
                    ImageUrl = "/img/grannysquareblanket.jpg"
                }
            );

         
            var baseDate = new DateTime(2025, 1, 1);

            modelBuilder.Entity<Review>().HasData(

                // 1 Cozy Striped Scarf
                new Review { ReviewId = 1, ProductId = 1, Name = "Emily", Content = "So soft and warm! The colors look even better in person.", Rating = 5, PostedOn = baseDate },
                new Review { ReviewId = 2, ProductId = 1, Name = "Sarah", Content = "Perfect length and super comfy. Ships fast too!", Rating = 4, PostedOn = baseDate.AddDays(1) },

                // 2 Winter Berry Scarf
                new Review { ReviewId = 3, ProductId = 2, Name = "Jordan", Content = "The berry colors are gorgeous! Very festive.", Rating = 5, PostedOn = baseDate.AddDays(2) },
                new Review { ReviewId = 4, ProductId = 2, Name = "Mia", Content = "Warm enough for cold mornings. Great stitch work.", Rating = 4, PostedOn = baseDate.AddDays(3) },

                // 3 Pastel Breeze Scarf
                new Review { ReviewId = 5, ProductId = 3, Name = "Lily", Content = "The pastel shades are dreamy!", Rating = 5, PostedOn = baseDate.AddDays(4) },
                new Review { ReviewId = 6, ProductId = 3, Name = "Kate", Content = "Lightweight and perfect for spring.", Rating = 4, PostedOn = baseDate.AddDays(5) },

                // 4 Sunset Fade Scarf
                new Review { ReviewId = 7, ProductId = 4, Name = "Ava", Content = "The gradient is stunning. Truly handmade beauty.", Rating = 5, PostedOn = baseDate.AddDays(6) },
                new Review { ReviewId = 8, ProductId = 4, Name = "Hannah", Content = "I get compliments every time I wear it.", Rating = 5, PostedOn = baseDate.AddDays(7) },

                // 5 Chunky Comfort Scarf
                new Review { ReviewId = 9, ProductId = 5, Name = "Olivia", Content = "So chunky and cozy – it’s like wearing a cloud.", Rating = 5, PostedOn = baseDate.AddDays(8) },
                new Review { ReviewId = 10, ProductId = 5, Name = "Beth", Content = "Warm and stylish, perfect for winter.", Rating = 4, PostedOn = baseDate.AddDays(9) },

                // 6 Mini Crossbody Pouch
                new Review { ReviewId = 11, ProductId = 6, Name = "Chloe", Content = "Perfect little bag for on-the-go!", Rating = 5, PostedOn = baseDate.AddDays(10) },
                new Review { ReviewId = 12, ProductId = 6, Name = "Grace", Content = "Fits my phone and keys. Super cute.", Rating = 4, PostedOn = baseDate.AddDays(11) },

                // 7 Market Tote Bag
                new Review { ReviewId = 13, ProductId = 7, Name = "Nora", Content = "Strong enough for groceries!", Rating = 5, PostedOn = baseDate.AddDays(12) },
                new Review { ReviewId = 14, ProductId = 7, Name = "Jade", Content = "Very durable and stylish.", Rating = 4, PostedOn = baseDate.AddDays(13) },

                // 8 Boho Fringe Shoulder Bag
                new Review { ReviewId = 15, ProductId = 8, Name = "Riley", Content = "The fringe is everything – total boho vibes.", Rating = 5, PostedOn = baseDate.AddDays(14) },
                new Review { ReviewId = 16, ProductId = 8, Name = "Tessa", Content = "Spacious and unique. Love it!", Rating = 4, PostedOn = baseDate.AddDays(15) },

                // 9 Floral Granny Square Bag
                new Review { ReviewId = 17, ProductId = 9, Name = "Hope", Content = "Beautiful craftsmanship and colors.", Rating = 5, PostedOn = baseDate.AddDays(16) },
                new Review { ReviewId = 18, ProductId = 9, Name = "Lauren", Content = "So colorful and cheerful. My favorite bag now.", Rating = 5, PostedOn = baseDate.AddDays(17) },

                // 10 Summer Stripe Beach Bag
                new Review { ReviewId = 19, ProductId = 10, Name = "Isla", Content = "Holds towels, sunscreen, snacks – amazing.", Rating = 5, PostedOn = baseDate.AddDays(18) },
                new Review { ReviewId = 20, ProductId = 10, Name = "Zoey", Content = "Bright and summery!", Rating = 4, PostedOn = baseDate.AddDays(19) },

                // 11 Cozy Bunny Plush
                new Review { ReviewId = 21, ProductId = 11, Name = "Paige", Content = "Cutest bunny ever – so soft!", Rating = 5, PostedOn = baseDate.AddDays(20) },
                new Review { ReviewId = 22, ProductId = 11, Name = "Ella", Content = "Perfect gift for my niece.", Rating = 5, PostedOn = baseDate.AddDays(21) },

                // 12 Sleepy Bear Plush
                new Review { ReviewId = 23, ProductId = 12, Name = "Maddie", Content = "The sleepy eyes are adorable.", Rating = 5, PostedOn = baseDate.AddDays(22) },
                new Review { ReviewId = 24, ProductId = 12, Name = "Sophie", Content = "Great bedtime plush for kids.", Rating = 4, PostedOn = baseDate.AddDays(23) },

                // 13 Tiny Dinosaur Plush
                new Review { ReviewId = 25, ProductId = 13, Name = "Leo", Content = "Tiny and cute – perfect desk buddy.", Rating = 5, PostedOn = baseDate.AddDays(24) },
                new Review { ReviewId = 26, ProductId = 13, Name = "Ethan", Content = "My son carries it everywhere.", Rating = 5, PostedOn = baseDate.AddDays(25) },

                // 14 Pastel Kitten Plush
                new Review { ReviewId = 27, ProductId = 14, Name = "Aria", Content = "The pastel colors are precious.", Rating = 5, PostedOn = baseDate.AddDays(26) },
                new Review { ReviewId = 28, ProductId = 14, Name = "Naomi", Content = "Soft and well-made.", Rating = 4, PostedOn = baseDate.AddDays(27) },

                // 15 Strawberry Cow Plush
                new Review { ReviewId = 29, ProductId = 15, Name = "Daisy", Content = "Strawberry cow is everything!", Rating = 5, PostedOn = baseDate.AddDays(28) },
                new Review { ReviewId = 30, ProductId = 15, Name = "Clara", Content = "Adorable and unique plush.", Rating = 5, PostedOn = baseDate.AddDays(29) },

                // 16 Cozy Cardigan
                new Review { ReviewId = 31, ProductId = 16, Name = "Hailey", Content = "So warm and oversized. I’m obsessed.", Rating = 5, PostedOn = baseDate.AddDays(30) },
                new Review { ReviewId = 32, ProductId = 16, Name = "Jo", Content = "Beautiful yarn texture.", Rating = 4, PostedOn = baseDate.AddDays(31) },

                // 17 Vintage Patchwork Sweater
                new Review { ReviewId = 33, ProductId = 17, Name = "Ivy", Content = "Retro and stylish – compliments guaranteed.", Rating = 5, PostedOn = baseDate.AddDays(32) },
                new Review { ReviewId = 34, ProductId = 17, Name = "Rae", Content = "Love the colors and patchwork.", Rating = 4, PostedOn = baseDate.AddDays(33) },

                // 18 Autumn Stripes Pullover
                new Review { ReviewId = 35, ProductId = 18, Name = "Bri", Content = "Perfect fall sweater.", Rating = 5, PostedOn = baseDate.AddDays(34) },
                new Review { ReviewId = 36, ProductId = 18, Name = "Kara", Content = "Warm and comfy.", Rating = 4, PostedOn = baseDate.AddDays(35) },

                // 19 Lavender Cropped Sweater
                new Review { ReviewId = 37, ProductId = 19, Name = "Jess", Content = "Cute and trendy. Love the lavender.", Rating = 5, PostedOn = baseDate.AddDays(36) },
                new Review { ReviewId = 38, ProductId = 19, Name = "Morgan", Content = "Perfect with high-waisted jeans.", Rating = 5, PostedOn = baseDate.AddDays(37) },

                // 20 Teal Cable Sweater
                new Review { ReviewId = 39, ProductId = 20, Name = "Renee", Content = "Gorgeous cable pattern.", Rating = 5, PostedOn = baseDate.AddDays(38) },
                new Review { ReviewId = 40, ProductId = 20, Name = "Sky", Content = "Very warm and cozy.", Rating = 4, PostedOn = baseDate.AddDays(39) },

                // 21 Baby Soft Blanket
                new Review { ReviewId = 41, ProductId = 21, Name = "Lena", Content = "Perfect baby shower gift – so soft.", Rating = 5, PostedOn = baseDate.AddDays(40) },
                new Review { ReviewId = 42, ProductId = 21, Name = "Becca", Content = "Gentle and snuggly.", Rating = 5, PostedOn = baseDate.AddDays(41) },

                // 22 Cozy Throw Blanket
                new Review { ReviewId = 43, ProductId = 22, Name = "Tori", Content = "Use it every night on the couch.", Rating = 5, PostedOn = baseDate.AddDays(42) },
                new Review { ReviewId = 44, ProductId = 22, Name = "Megan", Content = "Warm and lovely texture.", Rating = 4, PostedOn = baseDate.AddDays(43) },

                // 23 Rainbow Burst Blanket
                new Review { ReviewId = 45, ProductId = 23, Name = "Kayla", Content = "Bright and cheerful – kids love it.", Rating = 5, PostedOn = baseDate.AddDays(44) },
                new Review { ReviewId = 46, ProductId = 23, Name = "Jay", Content = "Beautiful colors and so fun.", Rating = 4, PostedOn = baseDate.AddDays(45) },

                // 24 Neutral Aesthetic Blanket
                new Review { ReviewId = 47, ProductId = 24, Name = "Molly", Content = "Fits my room aesthetic perfectly.", Rating = 5, PostedOn = baseDate.AddDays(46) },
                new Review { ReviewId = 48, ProductId = 24, Name = "Ciara", Content = "Soft, cozy, and minimalist.", Rating = 5, PostedOn = baseDate.AddDays(47) },

                // 25 Granny Square Patch Blanket
                new Review { ReviewId = 49, ProductId = 25, Name = "Lori", Content = "A work of art – so nostalgic.", Rating = 5, PostedOn = baseDate.AddDays(48) },
                new Review { ReviewId = 50, ProductId = 25, Name = "Dani", Content = "Colorful and feels handmade with love.", Rating = 5, PostedOn = baseDate.AddDays(49) }
            );
        }
    }
}



