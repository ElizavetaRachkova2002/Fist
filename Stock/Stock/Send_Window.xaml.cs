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
    /// Логика взаимодействия для Send_Window.xaml
    /// </summary>
    public partial class Send_Window : Window
    {
        public Send_Window()
        {
            InitializeComponent();
            GiveTBProduct();
        }

        private void Btn_Add_Send_Product_Click(object sender, RoutedEventArgs e)
        {
            string name = Combo_product_send.Text;
            int count = int.Parse(TB_Send_Product_Count.Text);
            for (int i = 0; i < MyProducts_List.MyProducts.Count(); i++)
                if (MyProducts_List.MyProducts[i].Name == name)
                {
                    MyProducts_List.MyProducts[i].Count -= count;
                    MyProducts_List.MyProducts[i].Packed -= count;
                    break;
                }
            MyProducts_List.SaveProductList();
            this.Close();
           
        }

        public void GiveTBProduct()
        {

            Combo_product_send.Items.Clear();
            MyProducts_List.LoadProductList();
            for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
            {
                Combo_product_send.Items.Add(MyProducts_List.MyProducts[i].Name);
            }

        }
    }
}
