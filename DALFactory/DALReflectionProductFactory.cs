using System.Linq;
using ProductInterface;

namespace DALFactory
{
    // ConcreteCreator
    public class DalReflectionProductFactory : BaseCreator
    {
        public override IProduct GetDalProduct()
        {
            IProduct product = null;

            var assemblyPath = System.Configuration.ConfigurationManager.AppSettings["Product"];
            var assemblyObject = System.Reflection.Assembly.LoadFrom(assemblyPath);
            //var productType = assemblyObject.GetTypes().Where(T => typeof(IProduct).IsAssignableFrom(T)).FirstOrDefault();
            var productType = assemblyObject.GetTypes().FirstOrDefault(T => typeof(IProduct).IsAssignableFrom(T));
            if (productType != null)
            {
                if (productType.FullName != null)
                    product = assemblyObject.CreateInstance(productType.FullName) as IProduct;
            }
            return product;
        }

    }
}
