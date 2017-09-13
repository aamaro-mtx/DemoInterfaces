using DALFactory;

namespace BLL
{
    public partial class Product
    {
        private readonly BaseCreator _factory;

        public Product() : this(new DalReferenceProductFactory())
        {
        }

        public Product(DALFactory.BaseCreator factory)
        {
            _factory = factory;
        }

        public event ErrorEventHandler ErrorEvent;
        public delegate void ErrorEventHandler(object sender, ErrorEventArgs e);

        public Entities.Product GetProductById(int id)
        {
            Entities.Product result;
            if (id > 0)
            {
                var d = _factory.GetDalProduct();
                result = d.GetProductById(id);
                if (result == null)
                {
                    ErrorEvent?.Invoke(this, new ErrorEventArgs("Producto no encontrado"));
                }
                ErrorEvent?.Invoke(this, new ErrorEventArgs(_factory.GetIdentity(d)));
            }
            else
            {
                ErrorEvent?.Invoke(this, new ErrorEventArgs("El ID debe ser mayor que cero"));
                result = null;
            }
            return result;
        }
    }
}
