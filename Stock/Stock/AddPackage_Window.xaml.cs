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
using Exceptions;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using ProductsAndPackages;
using System.IO;

namespace Stock
{
    /// <summary>
    /// Логика взаимодействия для AddPackage_Window.xaml
    /// </summary>
    /// 

    
    public partial class AddPackage_Window : Window
    {
        public AddPackage_Window()
        {
            InitializeComponent();
            Pack_Exist_Count.Clear();
            Combo_package_add.Items.Clear();
            for (int i = 0; i < MyPackages_List.MyPackages.Count; i++)
            {
                Combo_package_add.Items.Add(MyPackages_List.MyPackages[i].ToString());
            }
            BtnAddNewPackage.Background = new SolidColorBrush(Colors.LightGray);
            BtnExistingPackage.Background = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void BtnExistingPackage_Click(object sender, RoutedEventArgs e)
        {
            BrdAddNewPackage.Visibility = Visibility.Collapsed;
            BrdAddExistingPackage.Visibility = Visibility.Visible;
            BtnAddNewPackage.Background = new SolidColorBrush(Colors.LightGray);
            BtnExistingPackage.Background = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void BtnAddNewPackage_Click(object sender, RoutedEventArgs e)
        {
            BrdAddExistingPackage.Visibility = Visibility.Collapsed;
            BrdAddNewPackage.Visibility = Visibility.Visible;
            BtnAddNewPackage.Background = new SolidColorBrush(Colors.LightSkyBlue);
            BtnExistingPackage.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void Btn_Add_New_Package_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                if (String.IsNullOrEmpty(Pack_New_Name.Text))
                {
                    throw new MyExceptionEmpyFieldNameOfPackage("Укажите название");
                }
                if (String.IsNullOrEmpty(Pack_New_Size.Text))
                {
                    throw new MyExceptionEmpyFieldNameOfPackage("Укажите размер");
                }
                
                if (String.IsNullOrEmpty(Pack_New_Count.Text))
                {
                    throw new MyExceptionEmpyFieldCountOfPackage("Укажите количество");
                }

                bool contains_symbols_package_new = false;
                foreach (char ch in Pack_New_Count.Text.Trim())
                {
                    if (char.IsDigit(ch) != true)
                    {
                        contains_symbols_package_new = true;
                        break;
                    }
                }
                if ((Pack_New_Count.Text.Trim().Count()) > 9 && contains_symbols_package_new == false)
                {
                    throw new MyExceptionCountTypeIsInt("За один раз возможно добавить не более 999999999 единиц упаковки");
                }
                if (contains_symbols_package_new == true)
                {
                    contains_symbols_package_new = false;
                    throw new MyExceptionCountOfPackageIsDigit("В кол-ве допускаются только цифры");
                }
                if (int.Parse(Pack_New_Count.Text) < 0)
                {
                    throw new MyExceptionCountOfPackageLessZero("В кол-ве допускаются только цифры");
                }
                string name = Pack_New_Name.Text.Trim();
                Pack_New_Name.Clear();
                string size = Pack_New_Size.Text.Trim().Replace(" ","");
                Pack_New_Size.Clear();
                int count = int.Parse(Pack_New_Count.Text.Trim());
                Pack_New_Count.Clear();
                for (int h = 0; h < MyPackages_List.MyPackages.Count; h++)
                {
                    if (MyPackages_List.MyPackages[h].Name_package == name && MyPackages_List.MyPackages[h].Size == size)
                    {
                        throw new MyExceptionPackageAlreadyExists("Данная упаковка уже существует");
                    }
                }
                Package package = new Package(name, size, count);
                MyPackages_List.MyPackages.Add(package);
                Serializer.SaveList<Package>(MyPackages_List.MyPackages, "Packagelist.xml");
                //MyPackages_List.SavePackageList();
                DateTime time = DateTime.Now;
                string operation = "Добавлена новая упаковка: " + name + " " + size + ", " + count.ToString() + " шт.";
                History Now = new History(time, operation);
                MyHistory_List.MyHistory.Insert(0, Now);
                Serializer.SaveList<History>(MyHistory_List.MyHistory, "Historylist.xml");
                //MyHistory_List.SaveHistory();
                this.Close();
            }
            catch (MyExceptionCountTypeIsInt ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
            catch (MyExceptionEmpyFieldNameOfPackage ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (MyExceptionWrongSizeOfPackage ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (MyExceptionEmpyFieldCountOfPackage ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (MyExceptionEmptyFieldSizeOfPackage ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (MyExceptionCountOfPackageIsDigit ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (MyExceptionCountOfPackageLessZero ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (MyExceptionPackageAlreadyExists ex)
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

        private void Btn_Add_Existing_Package_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                string str = Combo_package_add.Text;
                string name;
                string size;
                int index ;
                index = str.LastIndexOf(" ");
                size = str.Substring(index + 1);
                name = str.Substring(0, index);
                

                if (String.IsNullOrEmpty(name))
                {
                    throw new MyExceptionEmpyFieldNameOfPackage("Укажите название");
                }
                if (String.IsNullOrEmpty(Pack_Exist_Count.Text))
                {
                    throw new MyExceptionEmpyFieldCountOfPackage("Укажите количество");
                }
                bool contains_symbols_package_exist = false;
                foreach (char ch in Pack_Exist_Count.Text.Trim())
                {
                    if (char.IsDigit(ch) != true)
                    {
                        contains_symbols_package_exist = true;
                        break;
                    }
                }
                if ((Pack_Exist_Count.Text.Trim().Count()) > 9 && contains_symbols_package_exist == false)
                {
                    throw new MyExceptionCountTypeIsInt("За один раз возможно добавить не более 999999999 единиц упаковки");
                }
                if (contains_symbols_package_exist == true)
                {
                    contains_symbols_package_exist = false;
                    throw new MyExceptionCountOfPackageIsDigit("В кол-ве допускаются только цифры");
                }
                if (int.Parse(Pack_Exist_Count.Text) < 0)
                {
                    throw new MyExceptionCountOfPackageLessZero("В кол-ве допускаются только цифры");
                }
                for (int i = 0; i < MyPackages_List.MyPackages.Count; i++)
                {
                    if (MyPackages_List.MyPackages[i].Name_package == name && MyPackages_List.MyPackages[i].Size == size)
                    {

                        if (MyPackages_List.MyPackages[i].Count_package + int.Parse(Pack_Exist_Count.Text) < 0 || MyPackages_List.MyPackages[i].Count_package + int.Parse(Pack_Exist_Count.Text) > 2000000000)
                        {
                            throw new MyExceptionInvalidCount("Кол-во данной упаковки превышает норму(не более 2 млрд )");
                        }
                        MyPackages_List.MyPackages[i].Count_package += int.Parse(Pack_Exist_Count.Text);

                        DateTime time = DateTime.Now;
                        string operation = "Добавлена упаковка: " + name + " " + size + ", " + Pack_Exist_Count.Text + " шт.";
                        History Now = new History(time, operation);
                        MyHistory_List.MyHistory.Insert(0, Now);
                        Serializer.SaveList<History>(MyHistory_List.MyHistory, "Historylist.xml");
                        //MyHistory_List.SaveHistory();
                    }
                }
                Pack_Exist_Count.Clear();
                Serializer.SaveList<Package>(MyPackages_List.MyPackages, "Packagelist.xml");
                //MyPackages_List.SavePackageList();
                this.Close();
            }
            catch (MyExceptionEmpyFieldNameOfPackage ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (MyExceptionInvalidCount ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (MyExceptionCountTypeIsInt ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
                

            catch (MyExceptionEmpyFieldCountOfPackage ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (MyExceptionCountOfPackageIsDigit ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (MyExceptionCountOfPackageLessZero ex)
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
    }
}
