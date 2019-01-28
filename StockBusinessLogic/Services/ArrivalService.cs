using StockModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockBusinessLogic
{
    public interface IArrivalService
    {
        List<Arrival> GetArrivals();
    }

    public class ArrivalService: IArrivalService
    {       
        public List<Arrival> GetArrivals()
        {
            var arrivals = new List<Arrival>
            {
                new Arrival{
                    GoodId=1,
                    Amount=10,
                    Date=DateTime.Now
                },
                new Arrival{
                    GoodId=2,
                    Amount=15,
                    Date=DateTime.Now
                }                                 
            };

            return arrivals;
        }
    }
}
