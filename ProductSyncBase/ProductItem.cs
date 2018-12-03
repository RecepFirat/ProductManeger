using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSyncBase
{
  public  class ProductItem
    {
        public long? BarCode { get; set; }
        public string  Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
