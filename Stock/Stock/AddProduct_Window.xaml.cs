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

            for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
            {
                Combo_product_add.Items.Add(MyProducts_List.MyProducts[i].Name);
            }

            MyLegalEnitys_List.LoadLegalEnityList();

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
            addLegalEnity_Window.Visibility = Visibility.Visible;
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
            Product new_product = new Product(name, legal, brand, vendor, barcode, count, 0, count, packageN, packageS, 0);
            MyProducts_List.MyProducts.Add(new_product);

            MyProducts_List.SaveProductList();

            this.Close();

        }
    }
}
