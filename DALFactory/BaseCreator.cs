using ProductInterface;

namespace DALFactory
{
    // Creator
    public abstract class BaseCreator
    {
        public abstract IProduct GetDalProduct();

        public string GetIdentity(IProduct product)
        {
            return product.GetType().FullName;
        }
    }
}
