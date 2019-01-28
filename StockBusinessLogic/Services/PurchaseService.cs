using StockModels.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockBusinessLogic.Services
{
    public interface IPurchaseService
    {
        List<Purchase> GetPurchases();
    }

    public class PurchaseService : IPurchaseService
    {
        public List<Purchase> GetPurchases()
        {
            var purchase = new List<Purchase>
            {
                new Purchase{
                    GoodId=1,
                    Amount=5,
                    Date=DateTime.Now
                },
                new Purchase{
                    GoodId=2,
                    Amount=7,
                    Date=DateTime.Now
                }
            };

            return purchase;
        }
    }
}
