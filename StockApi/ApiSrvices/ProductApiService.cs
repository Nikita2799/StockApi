using StockModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace StockApi.ApiSrvices
{
    public interface IProductApiService
    {
        Task<List<Product>> GetList();
    }

    public class ProductApiService: IProductApiService
    {
        public async Task<List<Product>> GetList()
        {
            HttpClient client = new HttpClient();

            List<Product> products = new List<Product>();

            var respose = await client.GetAsync("/api/products");

            if (respose.IsSuccessStatusCode)
            {
                products = await respose.Content.ReadAsAsync<List<Product>>();
            }

            return products;
        }
    }
}