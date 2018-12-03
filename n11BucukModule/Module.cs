using ProductSyncBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n11BucukModule
{
    public class Module : SyncModule
    {
        public override string ModuleName { get; set; } = "n 11  bucuk ürün modülü";
        public override List<ProductItem> GetList()
        {
           return new[] {
                new ProductItem(){  BarCode=1234,Code="A-121233",Name="A4 Optik mouse" , Price=15.5m},
                   new ProductItem(){  BarCode=1234,Code="A-12321",Name="A4 Kablolu mouse" , Price=15.5m},
                      new ProductItem(){  BarCode=1234,Code="A-12321",Name="A4 Optik mouse" , Price=67.75m},

            }.ToList();
        }
    }
}
