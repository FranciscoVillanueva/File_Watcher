using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Dat
    {
        DataProductsEntities bd = new DataProductsEntities();

        public void Cambios()
        {
            bool cambios = bd.ChangeTracker.HasChanges();
            //DisplayStates(bd.ChangeTracker.Entries());
            
        }
    }

}
