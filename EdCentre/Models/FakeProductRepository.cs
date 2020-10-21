using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdCentre.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product> {
            new Product { Subject = "English", Price = 25 },
            new Product { Subject = "Math", Price = 30 },
            new Product { Subject = "Physics", Price = 30 }
        }.AsQueryable<Product>();
    }
}
