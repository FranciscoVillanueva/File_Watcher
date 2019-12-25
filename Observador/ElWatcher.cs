using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observador
{
    class ElWatcher
    {
        
        readonly string Dir;
        DataProductsEntities D = new DataProductsEntities();
        int IdA; 

        public ElWatcher(string PATH, int id)
        {
            Dir = PATH;
            IdA = id;
        }

        public void Ciclo()
        {
            //System.Threading.Thread.Sleep(1000);
            int IdQueViene = new DataProductsEntities().ChangesOnProduct.Select(x => x.IdLog).ToList().Last();
            List<ChangesOnProduct> cambios = new DataProductsEntities().ChangesOnProduct.Where(x => x.IdLog > IdA).ToList();

            if (IdQueViene != IdA)
            {
                foreach (var item in cambios)
                {
                    switch (item.ActionMade)
                    {
                        case 1:
                            Console.WriteLine("se agrego en la base de datos el producto con id: " + item.IdProduct);                        
                            CreaXmlDelProducto(item.IdProduct);
                            break;
                        case 2:
                            Console.WriteLine("Se borro de la base de datos el producto con id: " + item.IdProduct);
                            if (File.Exists(Dir + item.IdProduct + ".xml"))
                            {
                                BorraXmlDelProducto(item.IdProduct);
                            }
                            break;
                        case 3:
                            Console.WriteLine("Se edito en la base de datos producto con id: " + item.IdProduct);
                            if (File.Exists(Dir + item.IdProduct + ".xml"))
                            {
                                BorraXmlDelProducto(item.IdProduct);

                                CreaXmlDelProducto(item.IdProduct);
                            }
                            else
                            {
                                CreaXmlDelProducto(item.IdProduct);
                            }
                            
                            break;
                        default:
                            break;
                    }
                }
                IdA = IdQueViene;
            }
            
        }

        public void CreaXmlDelProducto(int IdProduct)
        {
            DataProductsEntities Da = new DataProductsEntities();
            Da.Configuration.ProxyCreationEnabled = false;
            Products P = Da.
                            Products.Where(x => x.Id == IdProduct).
                            FirstOrDefault();
            string Ps = new Casteador().Serial<Products>(P);
            ProdEnt Pr = new Casteador().Deserial<ProdEnt>(Ps);
            new XmlDocumento(Dir + IdProduct + ".xml")
                .AgregaObjetoAListaXml<ProdEnt>(new List<ProdEnt>(),Pr);
        }

        public void BorraXmlDelProducto(int IdProduct)
        {
            File.Delete(Dir + IdProduct + ".xml");
        }
    }
}
