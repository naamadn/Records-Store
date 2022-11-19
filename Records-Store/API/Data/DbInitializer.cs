using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace API.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(StoreContext context, UserManager<User> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new User
                {
                    UserName = "bob",
                    Email = "bob@test.com"
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
                await userManager.AddToRoleAsync(user, "Member");

                var admin = new User
                {
                    UserName = "admin",
                    Email = "admin@test.com"
                };

                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRolesAsync(admin, new[] {"Member", "Admin"});
            }

            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Best of Bowie",
                    Artist =
                        "David Bowie",
                    Price = 2000,
                    PictureUrl = "/images/products/BestofBowie.png",
                    Brand = "Sony",
                    Genre = "Classic Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Ray of Light",
                    Artist = "Madonna",
                    Price = 15000,
                    PictureUrl = "/images/products/RayofLight.png",
                    Brand = "Universal ",
                    Genre = "Pop",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Legend",
                    Artist =
                        "Bob Marley",
                    Price = 18000,
                    PictureUrl = "/images/products/Legend.png",
                    Brand = "Island Records",
                    Genre = "Reggae",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Abbey Road",
                    Artist =
                        "The Beatles",
                    Price = 30000,
                    PictureUrl = "/images/products/AbbeyRoad.png",
                    Brand = "Virgin Records",
                    Genre = "Classic Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Music for the Jilted Generation",
                    Artist =
                        "The Prodigy",
                    Price = 25000,
                    PictureUrl = "/images/products/MusicfortheJiltedGenerationclear.png",
                    Brand = "Atlantic Records",
                    Genre = "Electronic",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Back to Black",
                    Artist =
                        "Amy Winehouse",
                    Price = 12000,
                    PictureUrl = "/images/products/BackToBlack.png",
                    Brand = "Universal ",
                    Genre = "Soul",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Master of Puppets",
                    Artist =
                        "Metallica",
                    Price = 1000,
                    PictureUrl = "/images/products/MasterofPuppets.png",
                    Brand = "Atlantic Records",
                    Genre = "Metal",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "OK Computer",
                    Artist =
                        "Radiohead",
                    Price = 8000,
                    PictureUrl = "/images/products/OkComputer.png",
                    Brand = "Universal ",
                    Genre = "Alternative Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Nevermind",
                    Artist =
                        "Nirvana",
                    Price = 1500,
                    PictureUrl = "/images/products/Nevermind.png",
                    Brand = "Sony",
                    Genre = "Grunge",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Appetite for Destruction",
                    Artist =
                        "Guns N' Roses",
                    Price = 1800,
                    PictureUrl = "/images/products/AppetiteforDestruction.png",
                    Brand = "Virgin Records",
                    Genre = "Hard Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Post",
                    Artist =
                        "Björk",
                    Price = 1500,
                    PictureUrl = "/images/products/Post.png",
                    Brand = "Island Records",
                    Genre = "Electronic",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Californication",
                    Artist =
                        "Red Hot Chili Peppers",
                    Price = 1600,
                    PictureUrl = "/images/products/Californication.png",
                    Brand = "Universal ",
                    Genre = "Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Dookie",
                    Artist =
                        "Green Day",
                    Price = 1400,
                    PictureUrl = "/images/products/Dookie.png",
                    Brand = "Warner ",
                    Genre = "Punk Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Violator",
                    Artist =
                        "Depeche Mode",
                    Price = 25000,
                    PictureUrl = "/images/products/Violator.png",
                    Brand = "Atlantic Records",
                    Genre = "Synthpop",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Greatest Hits",
                    Artist =
                        "Queen",
                    Price = 18999,
                    PictureUrl = "/images/products/GreatestHits.png",
                    Brand = "Warner",
                    Genre = "Classic Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "AM",
                    Artist =
                        "Arctic Monkeys",
                    Price = 19999,
                    PictureUrl = "/images/products/AM.png",
                    Brand = "Universal ",
                    Genre = "Indie Rock",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "The Smiths",
                    Artist = "The Smiths",
                    Price = 15000,
                    PictureUrl = "/images/products/TheSmiths.png",
                    Brand = "Sony",
                    Genre = "Indie",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Britney",
                    Artist =
                        "Britney Spears",
                    Price = 18000,
                    PictureUrl = "/images/products/Britney.png",
                    Brand = "Virgin Records",
                    Genre = "Pop",
                    QuantityInStock = 100
                },
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}