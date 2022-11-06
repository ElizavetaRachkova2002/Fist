﻿using System;
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
    /// Логика взаимодействия для DeleteProduct_Window.xaml
    /// </summary>
    public partial class DeleteProduct_Window : Window
    {
        public DeleteProduct_Window()
        {
            InitializeComponent();
            GiveTBProduct();
        }
        public void GiveTBProduct()
        {

            Combo_product_add.Items.Clear();
            MyProducts_List.LoadProductList();
            for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
            {
                Combo_product_add.Items.Add(MyProducts_List.MyProducts[i].Name);
            }

        }
        private void Btn_Add_Existing_Product_Click(object sender, RoutedEventArgs e)
        {
            for (int i=0;i<MyProducts_List.MyProducts.Count();i++)
                if (MyProducts_List.MyProducts[i].Name==Combo_product_add.Text)
                {
                    MyProducts_List.MyProducts.RemoveAt(i);
                    break;
                }
            MyProducts_List.SaveProductList();
            this.Close();
        }
    }
}