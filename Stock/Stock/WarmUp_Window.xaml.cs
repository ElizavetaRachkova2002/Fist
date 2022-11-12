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
    /// Логика взаимодействия для WarmUp_Window.xaml
    /// </summary>
    public partial class WarmUp_Window : Window
    {
        public WarmUp_Window()
        {
            InitializeComponent();
            Combo_WarmUp_Name.Items.Clear();
            for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
            {
                Combo_WarmUp_Name.Items.Add(MyProducts_List.MyProducts[i].Name);

            }
        }

        private void Btn_WarmUp_Product_Click(object sender, RoutedEventArgs e)
        {
            string name = Combo_WarmUp_Name.Text;
            int count = int.Parse(WarmUp_Count.Text);
            int brak = int.Parse(WarmUp_Brak.Text);
            bool flag_count = false;
            bool flag_package = false;
            for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
            {
                if (MyProducts_List.MyProducts[i].Name == name)
                {
                    if (MyProducts_List.MyProducts[i].Not_Packed < count)
                    {
                        flag_count = true;
                    }
                }
            }
            for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
            {
                if (MyProducts_List.MyProducts[i].Name == name)
                {
                    for (int j = 0; j < MyPackages_List.MyPackages.Count(); j++)
                    {
                        if (MyProducts_List.MyProducts[i].PackageName == MyPackages_List.MyPackages[j].ToString())
                        {
                            if (MyPackages_List.MyPackages[j].Count_package < count)
                            { flag_package = true; }

                        }
                    }
                }
            }

            if (flag_count == true)
            {
                MessageBox.Show("Кол-во товара больше, чем было не упаковано");

            }
            else if(flag_package == true)
            {
                MessageBox.Show("Не хватает упаковки");
            }
            else
            {

                for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
                {
                    if (MyProducts_List.MyProducts[i].Name == name)
                    {
                        MyProducts_List.MyProducts[i].Count -= brak;
                        MyProducts_List.MyProducts[i].Brak += brak;
                        MyProducts_List.MyProducts[i].Not_Packed -= brak;
                        MyProducts_List.MyProducts[i].Not_Packed -= count;
                        MyProducts_List.MyProducts[i].Packed += count;
                        if (MyProducts_List.MyProducts[i].PackageName != "Без упаковки")
                            for (int j = 0; j < MyPackages_List.MyPackages.Count(); j++)
                            {
                                if (MyProducts_List.MyProducts[i].PackageName == MyPackages_List.MyPackages[j].ToString())
                                {
                                    MyPackages_List.MyPackages[j].Count_package -= count;
                                    break;

                                }
                            }
                        WarmUp_Count.Clear();
                        WarmUp_Brak.Clear();
                        DateTime time = DateTime.Now;
                        string operation = name + ". Подготовлено к продаже: " + count.ToString() + " шт., Брак: " + brak + " шт.";
                        History Now = new History(time, operation);
                        MyHistory_List.MyHistory.Insert(0, Now);
                        MyHistory_List.SaveHistory();
                        break;

                    }
                }
                MyProducts_List.SaveProductList();
                MyPackages_List.SavePackageList();
              //App.Current.Shutdown();
              
                this.Close();
            }
        }
    }
}
