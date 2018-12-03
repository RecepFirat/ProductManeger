using ProductSyncBase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProductManeger
{
    internal static class ModuleManager
    {
        //Yuklenmıs modullerı tutmam   gerekiyo

        public static List<ISyncModule> Modules { get; set; } = new List<ISyncModule>();

        static ModuleManager()
        {
            var files = Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Modules"), "*.dll").ToList();  //Verdiğim degerleri alıp bi pathe kendı donusturuyo path.combine;
            files.ForEach(p =>
            {

                var assembly = Assembly.LoadFrom(p);
                //diyoki basetype olanlari al onların icerisinde ise basetypeı syncmodule olanları al diyoruz 
                var type = assembly.GetTypes().Where(x => x.BaseType != null).SingleOrDefault(x => x.BaseType.Name == "SyncModule");
                if (type != null)
                {
                    Modules.Add(Activator.CreateInstance(type) as ISyncModule);
                }

            });
        }
    }
}
