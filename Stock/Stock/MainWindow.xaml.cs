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
        public List<Product> MyProducts=new List<Product>();
     
       List<Package> MyPackages = new List<Package>();
        public MainWindow()
        {
            InitializeComponent();
            MyProducts.Add(new Product("тетрадь 1", "И.П. Коровушкина", "Коровушка", "Корова", 5667, 10, 8, 2, "Коробка", "40x40"));
            MyProducts.Add(new Product("тетрадь 2", "", "", "", 5667, 7, 4, 3, "Коробка", "40x40"));
            MyProducts.Add(new Product("тетрадь 3", "", "", "", 5667, 20, 18, 2, "Коробка", "40x40"));
            productGrid.ItemsSource = MyProducts;

            MyPackages.Add(new Package("box", "30*30", 5));
            MyPackages.Add(new Package("box", "130*30", 5));
            MyPackages.Add(new Package("box", "2000*200", 5));
           packageGrid.ItemsSource = MyPackages;
            MainContent.Visibility = Visibility.Visible;
            BrdAddProduct.Visibility = Visibility.Collapsed;
            BrdAddExistingProduct.Visibility = Visibility.Collapsed;
            BrdAddNewProduct.Visibility = Visibility.Collapsed;
            BrdAddPackage.Visibility = Visibility.Collapsed;
        }

        private void AddPackage_Click(object sender, RoutedEventArgs e)
        {
            Combo_package_add.Items.Clear();
            for (int i=0;i<MyPackages.Count;i++)
            {
                Combo_package_add.Items.Add(MyPackages[i].ToString());
            }

            MainContent.Focusable = false;
            BrdAddPackage.Visibility = Visibility.Visible;
            BrdAddPackage.Focusable = true;
            BrdAddExistingPackage.Visibility = Visibility.Visible;
            BrdAddNewPackage.Visibility = Visibility.Collapsed;
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            Combo_product_add.Items.Clear();

            for (int i=0;i<MyProducts.Count;i++)
            {
                Combo_product_add.Items.Add(MyProducts[i].Name);
            }

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
      
        private void Btn_Add_Existing_Product_Click(object sender, RoutedEventArgs e)
        {
            string name = Combo_product_add.Text;
            for (int i = 0; i < MyProducts.Count; i++)
            {

                if (MyProducts[i].Name == name)
                {
                    MyProducts[i].Count +=int.Parse( TB_Exist_Count.Text);
                    MyProducts[i].Not_Packed+=int.Parse(TB_Exist_Count.Text) ;
                }
            }
            TB_Exist_Count.Clear();
            BrdAddPackage.Visibility = Visibility.Collapsed;
            BrdAddProduct.Visibility = Visibility.Collapsed;
            MainContent.Focusable = true;
        }
        private void grid_MouseUp_Package(object sender, MouseButtonEventArgs e)
        {
            Package package= packageGrid.SelectedItem as Package;
            MessageBox.Show(" Name: " + package.Name_package + "\n Размер: " + package.Size + "\n Количество: " + package.Count_package);
        }
        private void grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Product product = productGrid.SelectedItem as Product;
            MessageBox.Show(" Name: " + product.Name + "\n Юр. лицо: " + product.Legal_entity + "\n Бренд: " + product.Brand + "\n Артикул: " + product.Vendor_code + "\n Штрих-код: " + product.Barcode +
                 "\n Упаковка: " + product.PackageName + "\n Размер упаковки : " + product.PackageSize + "\n Количество : " + product.Count
                 + "\n Упаковано : " + product.Packed + "\n Не упаковано : " + product.Not_Packed);
        }
        private void Btn_Add_Existing_Package_Click(object sender, RoutedEventArgs e)
        {
            var str = Combo_package_add.Text.Split(' ');
            for (int i=0;i<MyPackages.Count;i++)
            {
                if(MyPackages[i].Name_package == str[0] && MyPackages[i].Size==str[1])
                {
                    MyPackages[i].Count_package += int.Parse(Pack_Exist_Count.Text);
                }
            }

            Pack_Exist_Count.Clear();
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
