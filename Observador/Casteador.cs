using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Observador
{
    public class Casteador
    {
        //tienes que agregar la referencia en el asembly, System.Web.Extensions
        //Solution Explorer->Right Click on Project Name -> 
        //Click on Manage Nuget Packages -> Search for newtonsoft -> 
        //Click on install button
        public string Serial<T>(T b)
        {
            string json = new JavaScriptSerializer().Serialize(b);
            return json;
        }

        public T Deserial<T>(string s)
        {
            T root = JsonConvert.DeserializeObject<T>(s);
            return root;
        }

        public List<ProdEnt> CasteaProducts_ProdEnt(List<Products> ob)
        {
            List<string> s = ob.Select(x => Serial(x)).ToList();
            List<ProdEnt> ret = s.Select(x => Deserial<ProdEnt>(x)).ToList();
            return ret;
        }

        public List<Products> CasteaProdEnt_Products(List<ProdEnt> ob)
        {
            List<string> s = ob.Select(x => Serial(x)).ToList();
            List<Products> ret = s.Select(x => Deserial<Products>(x)).ToList();
            return ret;
        }
    }
}
