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

        private void Btn_Add_New_Package_Click(object sender, RoutedEventArgs e)
        {
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
            string operation = "Добавлена новая упаковка: " + name + " " + size+ ", " + count.ToString() + " шт.";
            History Now = new History(time, operation);
            MyHistory_List.MyHistory.Insert(0,Now);
            MyHistory_List.SaveHistory();

            this.Close();
        }

        private void Btn_Add_Existing_Package_Click(object sender, RoutedEventArgs e)
        {
            var str = Combo_package_add.Text.Split(' ');
            for (int i = 0; i < MyPackages_List.MyPackages.Count; i++)
            {
                if (MyPackages_List.MyPackages[i].Name_package == str[0] && MyPackages_List.MyPackages[i].Size == str[1])
                {
                    MyPackages_List.MyPackages[i].Count_package += int.Parse(Pack_Exist_Count.Text);

                    DateTime time = DateTime.Now;
                    string operation = "Добавлена упаковка: " + str[0] +" "+ str[1] +", "+ Pack_Exist_Count.Text + " шт.";
                    History Now = new History(time, operation);
                    MyHistory_List.MyHistory.Insert(0, Now);
                    MyHistory_List.SaveHistory();
                }
            }

            Pack_Exist_Count.Clear();
            MyPackages_List.SavePackageList();
            this.Close();
        }
    }
}
