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

            for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
            {
                if (MyProducts_List.MyProducts[i].Name == name)
                {
                    MyProducts_List.MyProducts[i].Count -= brak;
                    MyProducts_List.MyProducts[i].Brak += brak;
                    MyProducts_List.MyProducts[i].Not_Packed -= brak;
                    MyProducts_List.MyProducts[i].Not_Packed -= count;
                    MyProducts_List.MyProducts[i].Packed += count;
                    WarmUp_Count.Clear();
                    WarmUp_Brak.Clear();
                    break;

                }
            }
            MyProducts_List.SaveProductList();
        }
    }
}
