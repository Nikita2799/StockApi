using StockModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace StockApi.ApiSrvices
{
    public interface IArrivalApiService
    {
        Task<List<Arrival>> GetList();
    }

    public class ArrivalApiService: IArrivalApiService
    {
        public async Task<List<Arrival>> GetList()
        {
            HttpClient client = new HttpClient();

            List<Arrival> arrivals = new List<Arrival>();

            var respone = await client.GetAsync("/api/arrivals");

            if (respone.IsSuccessStatusCode)
            {
                arrivals =await respone.Content.ReadAsAsync<List<Arrival>>();
            }

            return arrivals;
        }
    }
}