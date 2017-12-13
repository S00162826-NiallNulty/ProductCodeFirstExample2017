namespace Products.Migrations.ProductMigrations
{
    using Products.Controllers;
    using Products.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Products.Models.ProductDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ProductMigrations";
        }

        protected override void Seed(Products.Models.ProductDbContext context)
        {
            SeedCategoryProducts(context);
        }

        private void SeedCategoryProducts(ProductDbContext context)
        {
            context.Categories.AddOrUpdate(c => c.CategoryName,
                new Category[]
                {
                    new Category{
                    CategoryName = "Plumbing",
                    productsInCategory = new Product[]
                    {
                        new Product{Description = "stopper",
                                     FirstStockedOn = DateTime.Now - new TimeSpan(364,2,0,0),
                                        LastOrderDate = DateTime.Now - new TimeSpan(5,0,0),
                                            QuantityInStock = 200,
                                                UnitPrice = 0.20f } }

                        }
                });
        }
    }
}
