using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ProductsAndPackages;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Stock
{
    /// <summary>
    /// Логика взаимодействия для ListOfPackages.xaml
    /// </summary>
    public partial class ListOfPackages : Window
    {
        public List<string> currentPackage= new List<string>();
        public ListOfPackages()
        {
            InitializeComponent();
            gridlistpackage.ItemsSource = MyPackages_List.MyPackages;
            
        }
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i <MyPackages_List.MyPackages.Count;i++)
            {
                MyPackages_List.MyPackages[i].IsSelected = false;

            }

            MyPackages_List.SavePackageList();
            gridlistpackage.Items.Refresh();

        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

            var chk = (CheckBox)sender;
            chk.IsChecked = true;

            for (int i = 0; i < MyPackages_List.MyPackages.Count; i++)
            {
               MyPackages_List.MyPackages[i].IsSelected = true;

            }
            gridlistpackage.Items.Refresh();
            MyPackages_List.SavePackageList();


        }
        private void Btn_part_brak_Click(object sender, RoutedEventArgs e)
        {


        }

        private void btn_add_packages_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                for (int i = 0; i < MyPackages_List.MyPackages.Count; i++)
                {
                    if (MyPackages_List.MyPackages[i].IsSelected == true)
                    {
                        string cur = MyPackages_List.MyPackages[i].Name_package + " " + MyPackages_List.MyPackages[i].Size;
                        currentPackage.Add(cur);

                    }
                    MyPackages_List.MyPackages[i].IsSelected = false;
                }
                this.Close();
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

            }
        }

        private void btn_without_Package_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                currentPackage.Add("Без упаковки");
                this.Close();
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

            }
        }
    }
}
