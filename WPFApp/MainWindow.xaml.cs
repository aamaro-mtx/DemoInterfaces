using System;
using System.Windows;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnClear.Click += btnClear_Click;

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as ViewModels.ProductData;
            vm.GetProductById(Convert.ToInt16(tbSearchProductID.Text));
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ViewModels.ProductData();
        }
    }
}
