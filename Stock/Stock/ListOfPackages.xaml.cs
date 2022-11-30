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
    /// Логика взаимодействия для ListOfPackages.xaml
    /// </summary>
    public partial class ListOfPackages : Window
    {
        public List<string> currentPackage= new List<string>();
        public ListOfPackages()
        {
            InitializeComponent();
            gridlistbrak.ItemsSource = MyPackages_List.MyPackages;
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {



        }
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        { }
        private void Btn_part_brak_Click(object sender, RoutedEventArgs e)
        {


        }

        private void btn_add_packages_Click(object sender, RoutedEventArgs e)
        {
            for (int i=0;i<MyPackages_List.MyPackages.Count;i++)
            {
                if (MyPackages_List.MyPackages[i].IsSelected==true)
                {
                    string cur = MyPackages_List.MyPackages[i].Name_package+" "+ MyPackages_List.MyPackages[i].Size;
                    currentPackage.Add(cur);
                    
                }
                MyPackages_List.MyPackages[i].IsSelected = false;
            }
            this.Close();
        }

        private void btn_without_Package_Click(object sender, RoutedEventArgs e)
        {
            currentPackage.Add("Без упаковки");
            this.Close();
        }
    }
}
