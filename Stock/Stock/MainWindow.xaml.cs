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
using System.Xml.Serialization;
using System.IO;
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
        public List_Brak list_brak;
        public AddProduct_Window addProduct_Window;
        public AddPackage_Window addPackage_Window;
        public WarmUp_Window warmUp_Window;
        

        public MainWindow()
        {
            InitializeComponent();

            MyPackages_List.LoadPackageList();
            MyProducts_List.LoadProductList();
            MyLegalEnitys_List.LoadLegalEnityList();

            packageGrid.ItemsSource = MyPackages_List.MyPackages;
            MainContent.Visibility = Visibility.Visible;
            productGrid.ItemsSource = MyProducts_List.MyProducts;
           
        }

        private void AddPackage_Click(object sender, RoutedEventArgs e)
        {
            
            addPackage_Window = new AddPackage_Window();
            addPackage_Window.Visibility = Visibility.Visible;            
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
                addProduct_Window = new AddProduct_Window();
                addProduct_Window.Visibility = Visibility.Visible;          
        }

        private void grid_MouseUp_Package(object sender, MouseButtonEventArgs e)
        {
            Package package= packageGrid.SelectedItem as Package;
            MessageBox.Show(" Наименование: " + package.Name_package + "\n Размер: " + package.Size + "\n Количество: " + package.Count_package);
        }
        private void grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Product product = productGrid.SelectedItem as Product;
            MessageBox.Show(" Наименование: " + product.Name + "\n Юр. лицо: " + product.Legal_entity + "\n Бренд: " + product.Brand + "\n Артикул: " + product.Vendor_code + "\n Штрих-код: " + product.Barcode +
                 "\n Упаковка: " + product.PackageName + "\n Кол-во брака : " + product.Brak +  "\n Размер упаковки : " + product.PackageSize + "\n Количество : " + product.Count
                 + "\n Упаковано : " + product.Packed + "\n Не упаковано : " + product.Not_Packed);
        }


        private void Btn_WarmUp_Click(object sender, RoutedEventArgs e)
        {
            warmUp_Window = new WarmUp_Window();
            warmUp_Window.Visibility = Visibility.Visible;
        }

        private void Brak_list_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
            {
                MyProducts_List.MyProducts[i].IsSelected = false;
            }
            var New_List_With_Brak= new List<Product>();
            if (list_brak == null)
            {
                list_brak = new List_Brak();
               
                foreach(var item in MyProducts_List.MyProducts)
                {
                    if(item.Brak>0)
                    {
                        New_List_With_Brak.Add(item);
                    }
                }

                list_brak.gridlistbrak.ItemsSource = New_List_With_Brak;
                list_brak.Visibility = Visibility.Visible;
            }
            else
            { list_brak.Activate(); }
        }

        private void Btn_all_brak_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in MyProducts_List.MyProducts)
            {
                item.Brak = 0;
            }

        }



    }
}
