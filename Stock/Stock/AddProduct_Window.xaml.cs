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
using System.Windows.Shapes;

namespace Stock
{
    /// <summary>
    /// Логика взаимодействия для AddProduct_Window.xaml
    /// </summary>
    public partial class AddProduct_Window : Window
    {
        public AddLegalEnity_Window addLegalEnity_Window;
        
        
        public AddProduct_Window()
        {
            InitializeComponent();

            Combo_product_add.Items.Clear();
            BrdAddExistingProduct.Visibility = Visibility.Visible;
            BrdAddNewProduct.Visibility = Visibility.Collapsed;
            GiveTBProduct();            
            GiveTBLegalEnity();
            GiveTBPackage();
        }

        private void Btn_Add_Existing_Product_Click(object sender, RoutedEventArgs e)
        {
            string name = Combo_product_add.Text;
            for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
            {

                if (MyProducts_List.MyProducts[i].Name == name)
                {
                    MyProducts_List.MyProducts[i].Count += int.Parse(TB_Exist_Count.Text);
                    MyProducts_List.MyProducts[i].Not_Packed += int.Parse(TB_Exist_Count.Text);

                    DateTime time = DateTime.Now;
                    string operation = "Добавлен товар: " + name + ", " + TB_Exist_Count.Text+" шт.";
                    History Now = new History(time, operation);
                    MyHistory_List.MyHistory.Insert(0, Now);
                    MyHistory_List.SaveHistory();
                }
            }
            TB_Exist_Count.Clear();
            
            
            MyProducts_List.SaveProductList ();
            this.Close();
        }

        private void BtnAddNewProduct_Click(object sender, RoutedEventArgs e)
        {
            BrdAddExistingProduct.Visibility = Visibility.Collapsed;
            BrdAddNewProduct.Visibility = Visibility.Visible;
            TB_New_Legal_Entity.Items.Clear();

            MyLegalEnitys_List.LoadLegalEnityList();
            for (int i = 0; i < MyLegalEnitys_List.MyLegalEnitys.Count; i++)
            {
                TB_New_Legal_Entity.Items.Add(MyLegalEnitys_List.MyLegalEnitys[i]);
            }

            MyProducts_List.SaveProductList();
        }

        private void BtnExistingProduct_Click(object sender, RoutedEventArgs e)
        {
            BrdAddNewProduct.Visibility = Visibility.Collapsed;
            BrdAddExistingProduct.Visibility = Visibility.Visible;
            
        }

        private void Add_LegalEnity_Click(object sender, RoutedEventArgs e)
        {
            addLegalEnity_Window = new AddLegalEnity_Window();
            addLegalEnity_Window.Owner = this;
            addLegalEnity_Window.Visibility = Visibility.Visible;
            

        }

        public void AddNewLE(string name)
        {
            TB_New_Legal_Entity.Items.Add(name);
        }

        public void GiveTBLegalEnity()
        {

            TB_New_Legal_Entity.Items.Clear();
             MyLegalEnitys_List.LoadLegalEnityList();

            for (int i = 0; i < MyLegalEnitys_List.MyLegalEnitys.Count; i++)
            {
                TB_New_Legal_Entity.Items.Add(MyLegalEnitys_List.MyLegalEnitys[i]);
            }
        }

        public void GiveTBPackage()
        {
            int now = TB_NewProduct_Package_Name.SelectedIndex;
            TB_NewProduct_Package_Name.Items.Clear();
            MyPackages_List.LoadPackageList();
            for (int i = 0; i < MyPackages_List.MyPackages.Count; i++)
            {
                TB_NewProduct_Package_Name.Items.Add(MyPackages_List.MyPackages[i].ToString());
            }
            TB_NewProduct_Package_Name.Items.Add("Без упаковки");
            TB_NewProduct_Package_Name.SelectedIndex = now;



        }

        public void GiveTBProduct()
        {

            Combo_product_add.Items.Clear();
            MyProducts_List.LoadProductList();
            for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
            {
                Combo_product_add.Items.Add(MyProducts_List.MyProducts[i].Name);
            }

        }


        private void Btn_Add_New_Product_Click(object sender, RoutedEventArgs e)
        {
            string name = TB_New_Name.Text.Trim();
            TB_New_Name.Clear();
            string legal = TB_New_Legal_Entity.Text.Trim();
            string brand = TB_New_Brand.Text.Trim();
            TB_New_Brand.Clear();
            string vendor = TB_New_Vendor_Code.Text.Trim();
            TB_New_Vendor_Code.Clear();
            ulong barcode = ulong.Parse(TB_New_Barcode.Text.Trim());
            TB_New_Barcode.Clear();
            string packageN = TB_NewProduct_Package_Name.Text.Trim();
            //string packageS = TB_NewProduct_Package_Size.Text;
            int count = int.Parse(TB_NewProduct_Count.Text.Trim());
            TB_NewProduct_Count.Clear();
            Product new_product = new Product(name, legal, brand, vendor, barcode, count, 0, count, packageN, 0);
            MyProducts_List.MyProducts.Add(new_product);

            MyProducts_List.SaveProductList();

            DateTime time = DateTime.Now;
            string operation = "Добавлен новый товар: "+name+", "+count.ToString()+" шт.";
            History Now = new History(time, operation);
            MyHistory_List.MyHistory.Insert(0, Now);
            MyHistory_List.SaveHistory();

            this.Close();

        }

        private void TB_New_Legal_Entity_MouseDown(object sender, MouseEventArgs e)
        {
            if (MyLegalEnitys_List.AddNewLE == true)
            {
                //AddNewLE(MyLegalEnitys_List.NewLE);
                GiveTBLegalEnity();
                MyLegalEnitys_List.AddNewLE = false;
            }
        }

        private void TB_NewProduct_Package_Name_MouseEnter(object sender, MouseEventArgs e)
        {
            GiveTBPackage();
        }
    }
}
