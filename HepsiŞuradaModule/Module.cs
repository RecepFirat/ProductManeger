using ProductSyncBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiŞuradaModule
{
    public class Module : SyncModule
    {
        public override string ModuleName { get; set; } = "HepsiSurada ürün modulu";
        public override List<ProductItem> GetList()
        {
            return new[] {
                new ProductItem(){  BarCode=1234,Code="A-123",Name="A4 Optik mouse" , Price=15.5m},
                   new ProductItem(){  BarCode=1234,Code="A-124",Name="A4 Kablolu mouse" , Price=15.5m},
                      new ProductItem(){  BarCode=1234,Code="A-125",Name="A4 Optik mouse" , Price=67.75m},

            }.ToList();
        }
    }
}
