using Microsoft.EntityFrameworkCore;
using ShopCart.Web.Models;

namespace ShopCart.Web.infrastructure
{
    public static class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();
            if (context.Products.Count() == 0 && context.Categories.Count() == 0)
            {
                Category fruits = new Category { Name = "Fruits", Slug="fruits" };
                Category shirts = new Category { Name = "Shirts", Slug="shirts" };

                context.Products.AddRange(
                    new Product
                    {
                        Name="Apples",
                        Slug="apples",
                        Description="Jucy apples",
                        Price=1.50M,
                        Category=fruits,
                        Image="apples.jpg"
                    },
                    new Product
                    {
                        Name="Bananas",
                        Slug="bananas",
                        Description="Fresh bananas",
                        Price=2M,
                        Category=fruits,
                        Image="bananas.jpg"
                    },
                    new Product
                    {
                        Name="Watermelon",
                        Slug= "watermelon",
                        Description= "juicy watermelon",
                        Price=0.50M,
                        Category=fruits,
                        Image= "watermelon.jpg"
                    },
                    new Product
                    {
                        Name="White shirt",
                        Slug= "white-shirt",
                        Description= "White shirt",
                        Price=5.99M,
                        Category=shirts,
                        Image= "white shirt.jpg"
                    },
                    new Product
                    {
                        Name="Black shirt",
                        Slug= "black-shirt",
                        Description= "black shirt",
                        Price=6.99M,
                        Category=shirts,
                        Image= "black shirt.jpg"
                    },
                    new Product
                    {
                        Name="Red shirt",
                        Slug= "red-shirt",
                        Description= "Red shirt",
                        Price=7.99M,
                        Category=shirts,
                        Image= "red shirt.jpg"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
