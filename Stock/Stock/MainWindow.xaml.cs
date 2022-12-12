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
using ProductsAndPackages;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;

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
        public DeleteProduct_Window deleteProduct_Window;
        public Delete_Package delete_package;
        public Send_Window send_Window;
        public Change_Product_Window change_Product_Window;
        public History_Window history_Window;

        public MainWindow()
        {
            InitializeComponent();
            MyPackages_List.MyPackages = Serializer.LoadList<Package>(ConfigurationManager.AppSettings.Get("Packagelist"));
            MyProducts_List.MyProducts = Serializer.LoadList<Product>(ConfigurationManager.AppSettings.Get("Productlist"));
            MyLegalEnitys_List.MyLegalEnitys = Serializer.LoadList<string>(ConfigurationManager.AppSettings.Get("LegalEnitylist"));
            Serializer.LoadHistoryList(ConfigurationManager.AppSettings.Get("Historylist"));
            var currentConfig = ConfigurationManager.AppSettings.Get("Historylist");
            Serializer.SaveList<History>(MyHistory_List.MyHistory, currentConfig);

            packageGrid.ItemsSource = MyPackages_List.MyPackages;
            MainContent.Visibility = Visibility.Visible;
            productGrid.ItemsSource = MyProducts_List.MyProducts;

    
        }

        private void AddPackage_Click(object sender, RoutedEventArgs e)
        {
            
            addPackage_Window = new AddPackage_Window();
            addPackage_Window.Owner = this;
            addPackage_Window.ShowDialog();            
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            addProduct_Window = new AddProduct_Window();
            addProduct_Window.Owner = this;
            addProduct_Window.ShowDialog();

        }

        private void grid_MouseUp_Package(object sender, MouseButtonEventArgs e)
        {
            Package package = packageGrid.SelectedItem as Package;
            if (package != null)
            {
                MessageBox.Show(" Наименование: " + package.Name_package + "\n Размер: " + package.Size + "\n Количество: " + package.Count_package);
                packageGrid.SelectedItem=null;
            }
            else { }
        }
        private void grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Product product = null;
             product = productGrid.SelectedItem as Product;
            if (product != null)
            {
                string pack = "";
                for (int i=0;i<product.PackageName.Count;i++)
                {
                    if (i == 0)
                        pack = product.PackageName[i];
                    else pack=pack+"; "+ product.PackageName[i];
                }
                MessageBox.Show(" Наименование: " + product.Name + "\n Юр. лицо: " + product.Legal_entity + "\n Бренд: " + product.Brand + "\n Артикул: " + product.Vendor_code + "\n Штрих-код: " + product.Barcode +
                   "\n Упаковка: " + pack + "\n Кол-во брака : " + product.Brak +   "\n Количество : " + product.Count
                   + "\n К продаже : " + product.Packed + "\n Не упаковано : " + product.Not_Packed);
                productGrid.SelectedItem = null;
            }
            else { }
        }


        private void Btn_WarmUp_Click(object sender, RoutedEventArgs e)
        {
            warmUp_Window = new WarmUp_Window();
            warmUp_Window.Owner = this;
            warmUp_Window.ShowDialog();
        }

        private void Brak_list_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
            {
                MyProducts_List.MyProducts[i].IsSelected = false;
            }
            var New_List_With_Brak= new List<Product>();
            
                list_brak = new List_Brak();
            list_brak.Owner = this;
               
                foreach(var item in MyProducts_List.MyProducts)
                {
                    if(item.Brak>0)
                    {
                        New_List_With_Brak.Add(item);
                    }
                }

                list_brak.gridlistbrak.ItemsSource = New_List_With_Brak;
            list_brak.ShowDialog();
            
        }

        private void Btn_all_brak_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in MyProducts_List.MyProducts)
            {
                item.Brak = 0;
            }

        }

        private void DeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            deleteProduct_Window = new DeleteProduct_Window();
            deleteProduct_Window.Owner = this;
            deleteProduct_Window.ShowDialog();
        }
        private void Delete_Package_Click(object sender, RoutedEventArgs e)
        {
            delete_package = new Delete_Package();
            delete_package.Owner = this;
            delete_package.ShowDialog();
        }
        private void ProductGrid_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Visibility = Visibility.Visible;
            productGrid.ItemsSource = MyProducts_List.MyProducts;
            productGrid.Items.Refresh();
            this.Visibility = Visibility.Visible;

        }

        private void PackageGrid_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Visibility = Visibility.Visible;
            packageGrid.ItemsSource = MyPackages_List.MyPackages;
            packageGrid.Items.Refresh();
            this.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            send_Window = new Send_Window();
            send_Window.Owner = this;
            send_Window.ShowDialog();
        }

        private void ChangeProduct_Click(object sender, RoutedEventArgs e)
        {
            change_Product_Window = new Change_Product_Window();
            change_Product_Window.Owner = this;
            change_Product_Window.ShowDialog();
        }

        private void History_button_Click(object sender, RoutedEventArgs e)
        {
            history_Window = new History_Window();
            history_Window.Owner = this;
            history_Window.ShowDialog();
        }

      


    }
}
