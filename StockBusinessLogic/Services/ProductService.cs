using StockModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockBusinessLogic.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }

    public class ProductService: IProductService
    {
        public List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product{
                    Name="Apple",
                    Id=1
                },
                new Product{
                    Name="Peach",
                    Id=2
                }
            };

            return products;
        }
    }
}
