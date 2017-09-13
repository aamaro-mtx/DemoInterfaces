using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ViewModels
{
    public class ProductData : INotifyPropertyChanged
    {

        #region Propiedades

        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; } = 34;
        public int UnitsInStock { get; set; }
        public int CategoryId { get; set; }

        private string _productNameBf;

        public string ProductName
        {
            get { return _productNameBf; }
            set
            {
                if (value != _productNameBf)
                {
                    _productNameBf = value;
                    OnpropertyChanged();
                }
            }
        }

        #endregion Propiedades

        #region Métodos
        public void GetProductById(int id)
        {
            var b = new BLL.Product();
            b.ErrorEvent += (s, ev) => { /* Mostrar un messageBox*/};

            var product = b.GetProductById(id);
            ProductId = product.ProductId;
            ProductName = product.ProductName;
            UnitPrice = product.UnitPrice;
            UnitsInStock = product.UnitsInStock;
        }
        #endregion

        private void OnpropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
