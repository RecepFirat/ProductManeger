using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSyncBase
{
    public abstract class SyncModule : ISyncModule
    {
        public virtual string ModuleName { get; set; } = "Product Sync Module";
        public abstract List<ProductItem> GetList();//metodu soyutladım  bunun ıcın sadece ımzasını bıraktım 
    }
}
