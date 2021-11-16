using TestWebApp.Models;
using System;
using System.Linq;

namespace TestWebApp.Data
{
    public class DbInitializer
    {
        public static void Initialize(ObjectContext context)
        {
            context.Database.EnsureCreated();

            // Look for any product.
            if (context.Product.Any())
            {
                return;   // DB has been seeded
            }

            var products = new Product[]
            {
                new Product{Cate_id=1, Name="Quần jean", Price=49, Unit=2},
                new Product{Cate_id=2, Name="Áo sơ mi", Price=149, Unit=1},
                new Product{Cate_id=2,Name="Áo hoodie" , Price=249, Unit=4},
                new Product{Cate_id=3, Name="Mũ lưỡi trai", Price=99, Unit=7},
                new Product{Cate_id=3, Name="Kính râm", Price=79, Unit=10},
            };

            foreach (Product s in products)
            {
                context.Product.Add(s);
            }
            context.SaveChanges();

            var category = new Category[]
            {
                new Category{Name="Quần"},
                new Category{Name="Áo"},
                new Category{Name="Phụ kiện"},
            };
            foreach (Category c in category)
            {
                context.Category.Add(c);
            }
            context.SaveChanges();
        }
    }
}
