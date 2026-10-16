using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApEC.Models
{
    public class ProductService : Iproductservice
    {
        public async Task<List<string>> GetProduct()
        {
            return await Task.FromResult(new List<string>
            {
                "Rahul",
                "Laptop",
                "Apple",
                "Ball"
            });
        }
    }
}
