using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSyncBase
{
  public  interface  ISyncModule
    {//classımın ıcerısınde nelerın var olan neler var neler yok belırlemem gerekıyo
         string  ModuleName { get; set; }
        List<ProductItem> GetList();
    }
}
