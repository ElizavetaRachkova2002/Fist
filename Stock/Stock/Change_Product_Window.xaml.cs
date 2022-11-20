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
    /// Логика взаимодействия для Change_Product_Window.xaml
    /// </summary>
    public partial class Change_Product_Window : Window
    {
        bool flag_OK = false;
        int current_product_number;
        AddLegalEnity_Window addLegalEnity_Window;
        Add_Brand_Window add_Brand_Window;
        public Change_Product_Window()
        {
            InitializeComponent();

            GiveTBProduct();
            GiveTBBrand();
            GiveTBLegalEnity();
            GiveTBPackage();

            TB_NewProduct_Package_Name.IsReadOnly = true;
            TB_New_Barcode.IsReadOnly = true;
            TB_New_Brand.IsReadOnly = true;
            TB_New_Legal_Entity.IsReadOnly = true;
            TB_New_Name.IsReadOnly = true;
            TB_New_Vendor_Code.IsReadOnly = true;

        }

        private void Btn_Change_OK_Click(object sender, RoutedEventArgs e)
        {
            TB_NewProduct_Package_Name.IsReadOnly = false;
            TB_New_Barcode.IsReadOnly = false;
            TB_New_Brand.IsReadOnly = false;
            TB_New_Legal_Entity.IsReadOnly = false;
            TB_New_Name.IsReadOnly = false;
            TB_New_Vendor_Code.IsReadOnly = false;

            for (int i=0; i<MyProducts_List.MyProducts.Count;i++)
            {
                if (Combo_Current_Product.Text==MyProducts_List.MyProducts[i].Name)
                {
                    TB_New_Name.Text = MyProducts_List.MyProducts[i].Name;
                    TB_New_Legal_Entity.Text = MyProducts_List.MyProducts[i].Legal_entity;
                    TB_New_Brand.Text = MyProducts_List.MyProducts[i].Brand;
                    TB_New_Barcode.Text = MyProducts_List.MyProducts[i].Barcode.ToString();
                    TB_NewProduct_Package_Name.Text = MyProducts_List.MyProducts[i].PackageName;
                    TB_New_Vendor_Code.Text = MyProducts_List.MyProducts[i].Vendor_code;
                    current_product_number = i;
                    break;
                }
            }
            flag_OK = true;

        }

        private void Btn_Change_Product_Click(object sender, RoutedEventArgs e)
        {
            if (flag_OK == true)
            {
                MyProducts_List.MyProducts[current_product_number].Name = TB_New_Name.Text;
                MyProducts_List.MyProducts[current_product_number].Legal_entity = TB_New_Legal_Entity.Text;
                MyProducts_List.MyProducts[current_product_number].PackageName = TB_NewProduct_Package_Name.Text;
                MyProducts_List.MyProducts[current_product_number].Vendor_code = TB_New_Vendor_Code.Text;
                MyProducts_List.MyProducts[current_product_number].Barcode = ulong.Parse(TB_New_Barcode.Text);
                MyProducts_List.MyProducts[current_product_number].Brand = TB_New_Brand.Text;

                MyProducts_List.SaveProductList();

                this.Close();

            }
            else MessageBox.Show("Введите наименование товара для изменения");
        }

        

        private void TB_New_Brand_MouseDown(object sender, MouseEventArgs e)
        {
            if (Brand_List.AddNewBr == true)
            {
                GiveTBBrand();
                Brand_List.AddNewBr = false;
            }
        }

        private void TB_New_Legal_Entity_MouseDown(object sender, MouseEventArgs e)
        {
            if (MyLegalEnitys_List.AddNewLE == true)
            {
                GiveTBLegalEnity();
                MyLegalEnitys_List.AddNewLE = false;
            }
        }

        private void TB_New_Package_MouseDown(object sender, MouseEventArgs e)
        {

            GiveTBPackage();

        }

        private void Add_LegalEnity_Click(object sender, RoutedEventArgs e)
        {
            addLegalEnity_Window = new AddLegalEnity_Window();
            addLegalEnity_Window.Owner = this;
            addLegalEnity_Window.Visibility = Visibility.Visible;
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

        public void GiveTBBrand()
        {

            TB_New_Brand.Items.Clear();
            Brand_List.LoadBrandList();

            for (int i = 0; i < Brand_List.MyBrand.Count; i++)
            {
                TB_New_Brand.Items.Add(Brand_List.MyBrand[i]);
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
            TB_NewProduct_Package_Name.SelectedIndex=now;

        }

        public void GiveTBProduct()
        {

            Combo_Current_Product.Items.Clear();
            MyProducts_List.LoadProductList();
            for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
            {
                Combo_Current_Product.Items.Add(MyProducts_List.MyProducts[i].Name);
            }

        }

        private void Add_Brand_Click(object sender, RoutedEventArgs e)
        {
            add_Brand_Window = new Add_Brand_Window();
            add_Brand_Window.Owner = this;
            add_Brand_Window.Visibility = Visibility.Visible;
        }
    }
}
