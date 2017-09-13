using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALExtra
{
    public class Product:ProductInterface.IProduct
    {
        public Entities.Product GetProductByID(int ID)
        {            
            return new Entities.Product
            {
                ProductID = ID,
                ProductName = "ProductName",
                 CategoryID = 99,
                  UnitPrice = 27,
                   UnitsInStock = 5
            };
        }
    }
}
