using System.ComponentModel;

namespace ViewModels
{
    public class Product2 : INotifyPropertyChanged
    {
        public Entities.Product Product { get; set; }

        private string _productNameBf;
        public string FProductName
        {
            get { return _productNameBf; }
            set
            {
                if (value != _productNameBf)
                {
                    _productNameBf = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FProductName)));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        /**/
    }
}
