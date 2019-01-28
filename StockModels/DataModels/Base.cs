using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockModels.DataModels
{
    public abstract class Base
    {
        public int GoodId { get; set; }

        public int Amount  { get; set; }

        public DateTime Date;
    }
}
