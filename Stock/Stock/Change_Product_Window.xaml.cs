using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using Exceptions;
using System.IO;
using System.Windows.Input;
using ProductsAndPackages;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Configuration;

namespace Stock
{
    /// <summary>
    /// Логика взаимодействия для Change_Product_Window.xaml
    /// </summary>
    /// 

    public partial class Change_Product_Window : Window
    {
        string oldname = "";
        string oldLE = "";
        string oldBand = "";
        string oldBarcode="";
        string oldVendorCode = "";
        string oldPackage = "";
        string newPackage = "";

        

        bool flag_OK = false;
        public List<string> currentPackage_change = new List<string>();
        int current_product_number;
        AddLegalEnity_Window addLegalEnity_Window;
        Add_Brand_Window add_Brand_Window;
        ListOfPackages listOfPackages;
        public Change_Product_Window()
        {
            InitializeComponent();

            GiveTBProduct();
            GiveTBBrand();
            GiveTBLegalEnity();

            Btn_GivePackageList.Visibility = Visibility.Collapsed;
            TB_New_Barcode.IsReadOnly = true;
            TB_New_Brand.IsReadOnly = true;
            TB_New_Legal_Entity.IsReadOnly = true;
            TB_New_Name.IsReadOnly = true;
            TB_New_Vendor_Code.IsReadOnly = true;

        }

        private void Btn_Change_OK_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (String.IsNullOrEmpty(Combo_Current_Product.Text))
                {
                    throw new MyExceptionEmptyFieldNameOfProduct("Выберете товар");
                }
                
                
                TB_New_Brand.IsReadOnly = false;
                TB_New_Legal_Entity.IsReadOnly = false;
                TB_New_Name.IsReadOnly = false;
                TB_New_Vendor_Code.IsReadOnly = false;
                TB_New_Barcode.IsReadOnly=false;

                for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
                {
                    if (Combo_Current_Product.Text == MyProducts_List.MyProducts[i].Name)
                    {
                        TB_New_Name.Text = MyProducts_List.MyProducts[i].Name;
                        oldname = MyProducts_List.MyProducts[i].Name;
                        TB_New_Legal_Entity.Text = MyProducts_List.MyProducts[i].Legal_entity;
                        oldLE = MyProducts_List.MyProducts[i].Legal_entity;
                        TB_New_Brand.Text = MyProducts_List.MyProducts[i].Brand;
                        oldBand = MyProducts_List.MyProducts[i].Brand;
                        TB_New_Barcode.Text = MyProducts_List.MyProducts[i].Barcode.ToString();
                        oldBarcode= MyProducts_List.MyProducts[i].Barcode.ToString();
                        for (int j=0;j<MyProducts_List.MyProducts[i].PackageName.Count;j++)
                        {

                            if (j == 0)
                            {
                                TB_NewProduct_Package_Name.Text = MyProducts_List.MyProducts[i].PackageName[j];
                               
                            }
                            else
                            {
                                TB_NewProduct_Package_Name.Text = TB_NewProduct_Package_Name.Text+"; "+ MyProducts_List.MyProducts[i].PackageName[j];
                            }
                            currentPackage_change.Add(MyProducts_List.MyProducts[i].PackageName[j]);
                        }
                        oldPackage = TB_NewProduct_Package_Name.Text;
                        TB_New_Vendor_Code.Text = MyProducts_List.MyProducts[i].Vendor_code;
                        oldVendorCode = MyProducts_List.MyProducts[i].Vendor_code;
                        current_product_number = i;
                        Btn_GivePackageList.Visibility = Visibility.Visible;

                        break;
                    }
                }
                flag_OK = true;
            }
            catch (MyExceptionEmptyFieldNameOfProduct ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                StreamWriter log;
                if (!File.Exists("log.txt"))
                { log = new StreamWriter("log.txt"); }
                else { log = File.AppendText("log.txt"); }
                log.WriteLine("Data Time:" + DateTime.Now);
                log.WriteLine("Exception Name:" + ex.Message);
                log.Close();
                MessageBox.Show("Ошибка. Попробуйте повторить действие снова", "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
                this.Close();
            }
        }

        private void Btn_Change_Product_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                if (String.IsNullOrEmpty(TB_New_Name.Text))
                {
                    throw new MyExceptionEmptyFieldNameOfProduct("Введите название");
                }
                if (String.IsNullOrEmpty(TB_New_Legal_Entity.Text))
                {
                    throw new MyExceptionEmptyFieldLegalEntity("Введите юр. лицо");
                }
                if (String.IsNullOrEmpty(TB_New_Brand.Text))
                {
                    throw new MyExceptionEmptyFieldBrand("Введите бренд");
                }
                if (String.IsNullOrEmpty(TB_New_Vendor_Code.Text))
                {
                    throw new MyExceptionEmptyFieldVendorCode("Введите артикул");

                }
                if (String.IsNullOrEmpty(TB_New_Barcode.Text))
                {
                    throw new MyExceptionEmptyFieldBarcode("Введите штрихкод");
                }
                if (ulong.TryParse(TB_New_Barcode.Text, out ulong _barcode) != true && TB_New_Barcode.Text.Trim() != "")
                {
                    throw new MyExceptionBarcodeOfProductIsDigit("В штрихкоде допускаются только цифры");
                }

                if (String.IsNullOrEmpty(TB_NewProduct_Package_Name.Text))
                {
                    throw new MyExceptionEmptyFieldPackageName("Выберите упаковку");

                }

                
               
               
                ///проверка на повторение
                if (oldname == TB_New_Name.Text)
                { }
                else
                {
                    for (int i = 0;i<MyProducts_List.MyProducts.Count;i++)
                    {
                        if (TB_New_Name.Text == MyProducts_List.MyProducts[i].Name)
                        {
                          throw new MyExceptionProductAlreadyExistAfterChangeWithThisName("Товар с таким названием уже существует");
                           
                        }
                    }
                }
                if (oldVendorCode == TB_New_Vendor_Code.Text)
                { }
                else
                {
                    for(int i = 0; i < MyProducts_List.MyProducts.Count; i++)
                    {
                        if (TB_New_Vendor_Code.Text == MyProducts_List.MyProducts[i].Vendor_code)
                        {
                            throw new MyExceptionProductAlreadyExistAfterChangeWithThisVendorCode("Товар с таким артикулом уже существует");

                        }
                    }
                    
                }
                if (oldBarcode == TB_New_Barcode.Text)
                { }
                else
                {
                    for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
                    {
                        if ((TB_New_Barcode.Text) == MyProducts_List.MyProducts[i].Barcode)
                        {
                            throw new MyExceptionProductAlreadyExistAfterChangewithThisBarcode("Товар с таким штрихкодом уже существует");

                        }
                    }
                }

                if (flag_OK == true)
                {
                    DateTime time = DateTime.Now;
                    string operation = "Изменение товара: "+TB_New_Name.Text+" \n";
                    if(oldname!= TB_New_Name.Text)
                    {
                        operation = operation + "Название: " + oldname + " ----> " + TB_New_Name.Text + "\n";
                    }
                    if (oldLE!= TB_New_Legal_Entity.Text)
                    {
                        operation = operation + "Юр.лицо: " + oldLE + "---- > " + TB_New_Legal_Entity.Text + "\n";
                    }
                    if (oldBand!= TB_New_Brand.Text)
                    {
                        operation = operation + "Бренд: " + oldBand + " ----> " + TB_New_Brand.Text + "\n";
                    }
                    if (oldVendorCode != TB_New_Vendor_Code.Text)
                    {
                        operation = operation + "Артикул: " + oldVendorCode + " ----> " + TB_New_Vendor_Code.Text + "\n";
                    }
                    if (oldBarcode!= TB_New_Barcode.Text)
                    {
                        operation = operation + "Штрихкод: " + oldBarcode + " ----> " + TB_New_Barcode.Text + "\n";
                    }
                    if(oldPackage!=TB_NewProduct_Package_Name.Text)
                    {
                        operation=operation+ "Упаковка: " + oldPackage + "---- > "+ TB_NewProduct_Package_Name.Text + "\n";
                    }
                    History Now = new History(time, operation);
                    MyHistory_List.MyHistory.Insert(0, Now);
                    Serializer.SaveList<History>(MyHistory_List.MyHistory, ConfigurationManager.AppSettings.Get("Historylist"));
                    //MyHistory_List.SaveHistory();
                    
                    

                    MyProducts_List.MyProducts[current_product_number].Name = TB_New_Name.Text;
                    MyProducts_List.MyProducts[current_product_number].Legal_entity = TB_New_Legal_Entity.Text;
                    MyProducts_List.MyProducts[current_product_number].PackageName=currentPackage_change;
                    MyProducts_List.MyProducts[current_product_number].Vendor_code = TB_New_Vendor_Code.Text;
                    MyProducts_List.MyProducts[current_product_number].Barcode = TB_New_Barcode.Text;
                    MyProducts_List.MyProducts[current_product_number].Brand = TB_New_Brand.Text;

                    Serializer.SaveList<Product>(MyProducts_List.MyProducts, ConfigurationManager.AppSettings.Get("Productlist"));
                    //MyProducts_List.SaveProductList();

                    this.Close();

                }
                else MessageBox.Show("Введите товар, который хотите удалить", "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
          
                catch (MyExceptionProductAlreadyExistAfterChangeWithThisName ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (MyExceptionProductAlreadyExistAfterChangeWithThisVendorCode ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
            catch (MyExceptionProductAlreadyExistAfterChangewithThisBarcode ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
            catch (MyExceptionBarcodeOfProductIsDigit ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
          
            catch (MyExceptionBarcodeLessThanZero ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (MyExceptionEmptyFieldNameOfProduct ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (MyExceptionEmptyFieldLegalEntity ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);

            }

            catch (MyExceptionEmptyFieldBrand ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (MyExceptionEmptyFieldVendorCode ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (MyExceptionEmptyFieldBarcode ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (MyExceptionEmptyFieldPackageName ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
            catch (OverflowException )
            {
                MessageBox.Show("В штрихкоде допускаются только цифры", "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                StreamWriter log;
                if (!File.Exists("log.txt"))
                { log = new StreamWriter("log.txt"); }
                else { log = File.AppendText("log.txt"); }
                log.WriteLine("Data Time:" + DateTime.Now);

                log.WriteLine("Exception Name:" + ex.Message);
                log.Close();
                MessageBox.Show("Ошибка. Попробуйте повторить действие снова", "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
                this.Close();
            }
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

        private void Add_LegalEnity_Click(object sender, RoutedEventArgs e)
        {
            addLegalEnity_Window = new AddLegalEnity_Window();
            addLegalEnity_Window.Owner = this;
            addLegalEnity_Window.ShowDialog();
        }

        public void GiveTBLegalEnity()
        {

            TB_New_Legal_Entity.Items.Clear();
            MyLegalEnitys_List.MyLegalEnitys = Serializer.LoadList<string>(ConfigurationManager.AppSettings.Get("LegalEnitylist"));
            //MyLegalEnitys_List.LoadLegalEnityList();

            for (int i = 0; i < MyLegalEnitys_List.MyLegalEnitys.Count; i++)
            {
                TB_New_Legal_Entity.Items.Add(MyLegalEnitys_List.MyLegalEnitys[i]);
            }
        }

        public void GiveTBBrand()
        {

            TB_New_Brand.Items.Clear();
            Brand_List.MyBrand = Serializer.LoadList<string>(ConfigurationManager.AppSettings.Get("Brandlist"));
            //Brand_List.LoadBrandList();

            for (int i = 0; i < Brand_List.MyBrand.Count; i++)
            {
                TB_New_Brand.Items.Add(Brand_List.MyBrand[i]);
            }
        }

        public void GiveTBProduct()
        {

            Combo_Current_Product.Items.Clear();
            MyProducts_List.MyProducts = Serializer.LoadList<Product>(ConfigurationManager.AppSettings.Get("Productlist"));
            //MyProducts_List.LoadProductList();
            for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
            {
                Combo_Current_Product.Items.Add(MyProducts_List.MyProducts[i].Name);
            }

        }

        private void Add_Brand_Click(object sender, RoutedEventArgs e)
        {
            add_Brand_Window = new Add_Brand_Window();
            add_Brand_Window.Owner = this;
            add_Brand_Window.ShowDialog();
        }

        private void Btn_GivePackageList_Click(object sender, RoutedEventArgs e)
        {
            listOfPackages = new ListOfPackages();
            listOfPackages.Owner = this;
            
            
            listOfPackages.ShowDialog();
            
            if (listOfPackages.currentPackage.Count != 0)
            {
                TB_NewProduct_Package_Name.Clear();
                
                for (int i = 0; i < listOfPackages.currentPackage.Count; i++)
                {
                    if (i == 0)
                    {
                        TB_NewProduct_Package_Name.Text = listOfPackages.currentPackage[i];
                        newPackage = listOfPackages.currentPackage[i];
                    }
                    else
                    {
                        TB_NewProduct_Package_Name.Text = TB_NewProduct_Package_Name.Text + "; " + listOfPackages.currentPackage[i];
                        newPackage = newPackage + "; " + listOfPackages.currentPackage[i];
                    }
                }

                currentPackage_change = listOfPackages.currentPackage;
            }



        }
    }
}
