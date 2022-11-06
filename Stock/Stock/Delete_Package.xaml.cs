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
    /// Логика взаимодействия для Delete_Package.xaml
    /// </summary>
    public partial class Delete_Package : Window
    {
        public Delete_Package()
        {
            InitializeComponent();
            GiveTBProduct();
        }
        public void GiveTBProduct()
        {

            Combo_package.Items.Clear();
            MyPackages_List.LoadPackageList();
            
            for (int i = 0; i < MyPackages_List.MyPackages.Count; i++)
            {
                Combo_package.Items.Add(MyPackages_List.MyPackages[i].Name_package);
            }

        }
        private void Btn_Delete_Package_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < MyPackages_List.MyPackages.Count(); i++)
                if (MyPackages_List.MyPackages[i].Name_package == Combo_package.Text)
                {
                    MyPackages_List.MyPackages.RemoveAt(i);
                    break;
                }
            MyPackages_List.SavePackageList();
            this.Close();
        }
    }
}
