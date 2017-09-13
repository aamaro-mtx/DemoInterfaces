using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductHC : ProductInterface.IProduct
    {
        public Entities.Product GetProductByID (int ID)
        {
            // LINQ
            // select * from products where productid = id
            //var Item2 = from P in Products where P.ProductID == ID select P;
            //var Item3 = Item2.FirstOrDefault();

            var Item = Products.Where(x => x.ProductID == ID).FirstOrDefault();
            return Item;
        }

        List<Entities.Product> Products = new List<Entities.Product>
        {
            new Entities.Product
            {
                ProductID = 1,
                ProductName = "Azucar",
                UnitPrice = 12,
                UnitsInStock = 100,
                CategoryID = 1
            },
            new Entities.Product
            {
                ProductID = 2,
                ProductName = "Frijol",
                UnitPrice = 23,
                UnitsInStock = 200,
                CategoryID = 2
            },
            new Entities.Product
            {
                ProductID = 3,
                ProductName = "Leche",
                UnitPrice = 127,
                UnitsInStock = 1000,
                CategoryID = 3
            },

        };
    }
}
