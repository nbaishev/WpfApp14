using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Яблоко",
                Price = 200,
                ProductImage = "Data/apple.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                ProductName = "Банан",
                Price = 400,
                ProductImage = "Data/banana.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                ProductName = "Стиральная машина",
                Price = 20000,
                ProductImage = "Data/washmachine.jpg",
                ProductCategory = ProductCategories.Appliances
            });
            lstBox.ItemsSource = products;
        }
    }
}
