using DALJson;
using ProductInterface;

namespace DALFactory
{
    public class DalReferenceProductFactory : BaseCreator
    {
        public override IProduct GetDalProduct()
        {
            return new Product();
        }
    }
}
