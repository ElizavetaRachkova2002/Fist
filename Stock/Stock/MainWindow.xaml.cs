using System;
using System.Collections.Generic;
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

namespace Stock
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Product> MyProducts = new List<Product>();
        public MainWindow()
        {
            InitializeComponent();
            MainContent.Visibility = Visibility.Visible;
            BrdAddProduct.Visibility = Visibility.Collapsed;
            BrdAddExistingProduct.Visibility = Visibility.Collapsed;
            BrdAddNewProduct.Visibility = Visibility.Collapsed;
            BrdAddPackage.Visibility = Visibility.Collapsed;
        }

        private void AddPackage_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Focusable = false;
            BrdAddPackage.Visibility = Visibility.Visible;
            BrdAddPackage.Focusable = true;
            BrdAddExistingPackage.Visibility = Visibility.Visible;
            BrdAddNewPackage.Visibility = Visibility.Collapsed;

        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Focusable = false;
            BrdAddProduct.Visibility = Visibility.Visible;
            BrdAddProduct.Focusable = true;
            BrdAddExistingProduct.Visibility = Visibility.Visible;
            BrdAddNewProduct.Visibility = Visibility.Collapsed;



        }

        private void BtnAddNewProduct_Click(object sender, RoutedEventArgs e)
        {
            BrdAddExistingProduct.Visibility = Visibility.Collapsed;
            BrdAddNewProduct.Visibility = Visibility.Visible;
        }

        private void BtnExistingProduct_Click(object sender, RoutedEventArgs e)
        {
            BrdAddNewProduct.Visibility = Visibility.Collapsed;
            BrdAddExistingProduct.Visibility = Visibility.Visible;
        }

        private void BtnExistingPackage_Click(object sender, RoutedEventArgs e)
        {
            BrdAddNewPackage.Visibility = Visibility.Collapsed;
            BrdAddExistingPackage.Visibility = Visibility.Visible;
        }

        private void BtnAddNewPackage_Click(object sender, RoutedEventArgs e)
        {
            BrdAddExistingPackage.Visibility = Visibility.Collapsed;
            BrdAddNewPackage.Visibility = Visibility.Visible;
        }

        private void ToMainButton_Click(object sender, RoutedEventArgs e)
        {
            BrdAddPackage.Visibility = Visibility.Collapsed;
            BrdAddProduct.Visibility = Visibility.Collapsed;
            MainContent.Focusable = true;
        }

        private void Btn_Add_New_Product_Click(object sender, RoutedEventArgs e)
        {
 //           MyProducts.Add()
        }
    }
}
