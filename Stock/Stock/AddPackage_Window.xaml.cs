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
using System.Text.RegularExpressions;

namespace Stock
{
    /// <summary>
    /// Логика взаимодействия для AddPackage_Window.xaml
    /// </summary>
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
                Regex regex = new Regex(@"\d+\*\d+");
                bool flag = false;
                MatchCollection matches = regex.Matches(Pack_New_Size.Text);
                if (matches.Count > 0)
                {
                    flag = true;
                }
                if (String.IsNullOrEmpty(Pack_New_Name.Text))
                {
                    throw new MyExceptionEmpyFieldNameOfPackage("Укажите название упаковки");
                }
                if (String.IsNullOrEmpty(Pack_New_Size.Text))
                {
                    throw new MyExceptionEmpyFieldNameOfPackage("Укажите размер упаковки");
                }
                if(flag==false)
                {
                    throw new MyExceptionWrongSizeOfPackage("Неверный размер упаковки");
                }
                if (String.IsNullOrEmpty(Pack_New_Count.Text))
                {
                    throw new MyExceptionEmpyFieldCountOfPackage("Укажите количество упаковки");
                }
                if (int.TryParse(Pack_New_Count.Text, out int _count) != true)
                {
                    throw new MyExceptionCountOfPackageIsDigit("кол-во товара это число");
                }
                if (int.Parse(Pack_New_Count.Text) < 0)
                {
                    throw new MyExceptionCountOfPackageLessZero("Количество товара больше 0");
                }
                string name = Pack_New_Name.Text.Trim();
                Pack_New_Name.Clear();
                string size = Pack_New_Size.Text.Trim();
                Pack_New_Size.Clear();
                int count = int.Parse(Pack_New_Count.Text.Trim());
                Pack_New_Count.Clear();



                Package package = new Package(name, size, count);
                MyPackages_List.MyPackages.Add(package);
                MyPackages_List.SavePackageList();

                DateTime time = DateTime.Now;
                string operation = "Добавлена новая упаковка: " + name + " " + size + ", " + count.ToString() + " шт.";
                History Now = new History(time, operation);
                MyHistory_List.MyHistory.Insert(0, Now);
                MyHistory_List.SaveHistory();

                this.Close();
            }
            catch (MyExceptionEmpyFieldNameOfPackage ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (MyExceptionWrongSizeOfPackage ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (MyExceptionEmpyFieldCountOfPackage ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch ( MyExceptionEmptyFieldSizeOfPackage ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (MyExceptionCountOfPackageIsDigit ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (MyExceptionCountOfPackageLessZero ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Add_Existing_Package_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var str = Combo_package_add.Text.Split(' ');
                if (String.IsNullOrEmpty(str[0]))
                {
                    throw new MyExceptionEmpyFieldNameOfPackage("Укажите название упаковки");
                }
                if (String.IsNullOrEmpty(Pack_Exist_Count.Text))
                {
                    throw new MyExceptionEmpyFieldCountOfPackage("Укажите количество упаковки");
                }
                if (int.TryParse(Pack_Exist_Count.Text, out int count) != true)
                {
                    throw new MyExceptionCountOfPackageIsDigit("кол-во товара это число");
                }
                if (int.Parse(Pack_Exist_Count.Text) < 0)
                {
                    throw new MyExceptionCountOfPackageLessZero("Количество товара больше 0");
                }
                

                for (int i = 0; i < MyPackages_List.MyPackages.Count; i++)
                {
                    if (MyPackages_List.MyPackages[i].Name_package == str[0] && MyPackages_List.MyPackages[i].Size == str[1])
                    {
                        MyPackages_List.MyPackages[i].Count_package += int.Parse(Pack_Exist_Count.Text);

                        DateTime time = DateTime.Now;
                        string operation = "Добавлена упаковка: " + str[0] + " " + str[1] + ", " + Pack_Exist_Count.Text + " шт.";
                        History Now = new History(time, operation);
                        MyHistory_List.MyHistory.Insert(0, Now);
                        MyHistory_List.SaveHistory();
                    }
                }

                Pack_Exist_Count.Clear();
                MyPackages_List.SavePackageList();
                this.Close();
            }
          
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
