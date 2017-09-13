using System.Linq;

namespace DALJson
{
    public class Product : ProductInterface.IProduct
    {
        public Entities.Product GetProductById(int id)
        {
            Entities.Product product;

            using (var reader = new System.IO.StreamReader("Products.json"))
            {
                var json = reader.ReadToEnd();
                var products = Newtonsoft.Json.JsonConvert.DeserializeObject<Entities.Product[]>(json);
                //product = products.Where(x => x.ProductId == id).FirstOrDefault();
                product = products.FirstOrDefault(x => x.ProductId == id);
            }
            return product;
        }
    }


}
