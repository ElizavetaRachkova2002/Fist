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
        public List<Product> MyProducts=new List<Product>();
     
        public List<Package> MyPackages = new List<Package>();

        public List<string> MyLegalEnity = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            //for (int i=0;i<40;i++)
            //MyProducts.Add(new Product("тетрадь 1", "И.П. Коровушкина", "Коровушка", "Корова", 5667, 10, 8, 2, "Коробка", "40x40"));
            //MyProducts.Add(new Product("тетрадь 2", "", "", "", 5667, 7, 4, 3, "Коробка", "40x40"));
            //MyProducts.Add(new Product("тетрадь 3", "", "", "", 5667, 20, 18, 2, "Коробка", "40x40"));

            //MyPackages.Add(new Package("box", "30*30", 5));
            //MyPackages.Add(new Package("box", "130*30", 5));
            //MyPackages.Add(new Package("box", "2000*200", 5));


            productGrid.ItemsSource = MyProducts;
            Brd_Add_LegalEnity.Visibility = Visibility.Collapsed;
            LoadPackageList();
            LoadProductList();
            LoadLegalEnityList();

            for (int i = 0; i < MyLegalEnity.Count; i++)
            {
                TB_New_Legal_Entity.Items.Add(MyLegalEnity[i]);
            }

            packageGrid.ItemsSource = MyPackages;
            MainContent.Visibility = Visibility.Visible;
            BrdAddProduct.Visibility = Visibility.Collapsed;
            BrdAddExistingProduct.Visibility = Visibility.Collapsed;
            BrdAddNewProduct.Visibility = Visibility.Collapsed;
            BrdAddPackage.Visibility = Visibility.Collapsed;
            Brd_WarmUp.Visibility = Visibility.Collapsed;

        }

        private void AddPackage_Click(object sender, RoutedEventArgs e)
        {
            Pack_Exist_Count.Clear();
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

            SaveProductList();
        }

        private void BtnExistingProduct_Click(object sender, RoutedEventArgs e)
        {
            BrdAddNewProduct.Visibility = Visibility.Collapsed;
            BrdAddExistingProduct.Visibility = Visibility.Visible;
            SaveProductList();
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
            Brd_WarmUp.Visibility = Visibility.Collapsed;
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
            SaveProductList();
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
            SavePackageList();
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
            SavePackageList();
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
            ulong barcode = ulong.Parse(TB_New_Barcode.Text);
            TB_New_Barcode.Clear();
            string packageN = TB_NewProduct_Package_Name.Text;
            string packageS = TB_NewProduct_Package_Size.Text;
            int count = int.Parse(TB_NewProduct_Count.Text);
            TB_NewProduct_Count.Clear();
            Product new_product = new Product(name, legal, brand, vendor, barcode, count, 0, count, packageN, packageS,0);
            MyProducts.Add(new_product);
            BrdAddPackage.Visibility = Visibility.Collapsed;
            BrdAddProduct.Visibility = Visibility.Collapsed;
            MainContent.Focusable = true;
            SaveProductList();
        }

        private void LoadProductList()
        {
            if (File.Exists("Productlist.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
                using (Stream reader = new FileStream("Productlist.xml", FileMode.Open))
                {
                    List<Product> tempList = (List<Product>)serializer.Deserialize(reader);
                    this.MyProducts.Clear();
                    foreach (var item in tempList)
                        this.MyProducts.Add(item);
                }
            }
        }

        private void SaveProductList()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            using (Stream writer = new FileStream("Productlist.xml", FileMode.Create))
            {
                serializer.Serialize(writer, MyProducts);
            }
        }


        private void LoadPackageList()
        {
            if (File.Exists("Packagelist.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Package>));
                using (Stream reader = new FileStream("Packagelist.xml", FileMode.Open))
                {
                    List<Package> tempList = (List<Package>)serializer.Deserialize(reader);
                    this.MyProducts.Clear();
                    foreach (var item in tempList)
                        this.MyPackages.Add(item);
                }
            }
        }

        private void SavePackageList()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Package>));
            using (Stream writer = new FileStream("Packacgelist.xml", FileMode.Create))
            {
                serializer.Serialize(writer, this.MyPackages);
            }
        }


        private void LoadLegalEnityList()
        {
            if (File.Exists("LegalEnitylist.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
                using (Stream reader = new FileStream("LegalEnitylist.xml", FileMode.Open))
                {
                    List<string> tempList = (List<string>)serializer.Deserialize(reader);
                    this.MyLegalEnity.Clear();
                    foreach (var item in tempList)
                        this.MyLegalEnity.Add(item);
                }
            }
        }

        private void SaveLegalEnityList()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
            using (Stream writer = new FileStream("LegalEnitylist.xml", FileMode.Create))
            {
                serializer.Serialize(writer, this.MyLegalEnity);
            }
        }



        private void WarmUp(int count)
        {

        }

        private void Btn_WarmUp_Click(object sender, RoutedEventArgs e)
        {
            Brd_WarmUp.Visibility = Visibility.Visible;
            Brd_WarmUp.Focusable = true;
            Combo_WarmUp_Name.Items.Clear();
            for (int i = 0; i < MyProducts.Count; i++)
            {
                Combo_WarmUp_Name.Items.Add(MyProducts[i].Name);
            }


        }

        private void Btn_WarmUp_Product_Click(object sender, RoutedEventArgs e)
        {
            string name = Combo_WarmUp_Name.Text;
            int count = int.Parse(WarmUp_Count.Text);
            int brak = int.Parse(WarmUp_Brak.Text);

            for (int i = 0; i < MyProducts.Count; i++)
            {
                if (MyProducts[i].Name == name)
                {
                    MyProducts[i].Count -= brak;
                    MyProducts[i].Brak += brak;
                    MyProducts[i].Not_Packed -= brak;
                    MyProducts[i].Not_Packed -= count;
                    MyProducts[i].Packed += count;
                    WarmUp_Count.Clear();
                    WarmUp_Brak.Clear();
                    break;

                }
            }
            Brd_WarmUp.Visibility = Visibility.Collapsed;
            SaveProductList();


        }

        private void Add_LegalEnity_Click(object sender, RoutedEventArgs e)
        {
            Brd_Add_LegalEnity.Visibility = Visibility.Visible;
            Brd_Add_LegalEnity.Focusable = true;
        }

        private void Add_New_LegalEnity_Click(object sender, RoutedEventArgs e)
        {
            string newName = New_LegalEnity.Text;
            MyLegalEnity.Add(newName);
            TB_New_Legal_Entity.Items.Add(newName);
            SaveLegalEnityList();
            Brd_Add_LegalEnity.Visibility = Visibility.Collapsed;
            Brd_Add_LegalEnity.Focusable = false;

        }

        private void Cancel_Add_New_LegalEnity_Click(object sender, RoutedEventArgs e)
        {
            Brd_Add_LegalEnity.Visibility = Visibility.Collapsed;
            Brd_Add_LegalEnity.Focusable = false;
        }
    }
}
