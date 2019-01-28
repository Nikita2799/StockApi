using StockModels.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace StockApi.ApiSrvices
{
    public interface IPurchaseService
    {
        Task<List<Purchase>> GetList();
    }

    public class PurchaseApiService
    {
        public async Task<List<Purchase>> GetList()
        {
            HttpClient client = new HttpClient();

            List<Purchase> purchases = new List<Purchase>();

            var respone = await client.GetAsync("/api/purchases");

            if (respone.IsSuccessStatusCode)
            {
                purchases = await respone.Content.ReadAsAsync<List<Purchase>>();
            }

            return purchases;
        }
    }
}