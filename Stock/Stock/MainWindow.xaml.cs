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
        List<Package> MyPackages = new List<Package>();
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 40; i++)
            {
                MyProducts.Add(new Product("тетрадь", "", "", "", 5667, 5, 3, 2, "Коробка", "40x40"));
            }
            productGrid.ItemsSource = MyProducts;
            for (int i = 0; i < 30; i++)
            {
                MyPackages.Add(new Package("коробка", "20*20", 5));
            }
            packageGrid.ItemsSource = MyPackages;
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

        private void Btn_Add_New_Package_Click(object sender, RoutedEventArgs e)
        {
            string name =Pack_New_Name.Text;
            Pack_New_Name.Clear();
            string size =Pack_New_Size.Text;
            Pack_New_Size.Clear();
            int count = int.Parse(Pack_New_Count.Text);
            Pack_New_Count.Clear();
            Package package=new Package(name, size, count);
            MyPackages.Add(package);
            BrdAddPackage.Visibility = Visibility.Collapsed;
            BrdAddProduct.Visibility = Visibility.Collapsed;
            MainContent.Focusable = true;
        }
        private void Btn_Add_New_Product_Click(object sender, RoutedEventArgs e)
        {
            string name = TB_New_Name.Text;
            TB_New_Name.Clear();
            string legal = TB_New_Legal_Entity.Text;
            string brand = TB_New_Brand.Text;
            TB_New_Brand.Clear();
            string vendor = TB_New_Vendor_Code.Text;
            TB_New_Vendor_Code.Clear();
            int barcode = int.Parse(TB_New_Barcode.Text);
            TB_New_Barcode.Clear();
            string packageN = TB_NewProduct_Package_Name.Text;
            string packageS = TB_NewProduct_Package_Size.Text;
            int count = int.Parse(TB_NewProduct_Count.Text);
            TB_NewProduct_Count.Clear();
            Product new_product = new Product(name, legal, brand, vendor, barcode, count, 0, count, packageN, packageS);
            MyProducts.Add(new_product);
            BrdAddPackage.Visibility = Visibility.Collapsed;
            BrdAddProduct.Visibility = Visibility.Collapsed;
            MainContent.Focusable = true;
        }
    }
}
