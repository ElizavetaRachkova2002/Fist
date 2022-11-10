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
using System.IO;
using System.Xml.Serialization;

namespace Stock
{
    /// <summary>
    /// Логика взаимодействия для List_Brak.xaml
    /// </summary>
    public partial class List_Brak : Window
    {
        public List_Brak()
        {
            InitializeComponent();

        }

        private void Btn_all_brak_Click(object sender, RoutedEventArgs e)
        {
            
            for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
            {
                if (MyProducts_List.MyProducts[i].Brak != 0)
                {
                    
                    DateTime time = DateTime.Now;
                    string operation = "Списан брак: " + MyProducts_List.MyProducts[i].Name + ", " + MyProducts_List.MyProducts[i].Brak.ToString() + " шт.";
                    History Now = new History(time, operation);
                    MyHistory_List.MyHistory.Insert(0, Now);
                    MyHistory_List.SaveHistory();
                    MyProducts_List.MyProducts[i].Brak = 0;
                }
            }
            MyProducts_List.SaveProductList();
            this.Close();
            
        }
        private void Btn_part_brak_Click(object sender, RoutedEventArgs e)
        {


            for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
            {
                if (MyProducts_List.MyProducts[i].IsSelected == true)
                {
                   
                    DateTime time = DateTime.Now;
                    string operation = "Списан брак: " + MyProducts_List.MyProducts[i].Name + ", " + MyProducts_List.MyProducts[i].Brak.ToString() + " шт.";
                    History Now = new History(time, operation);
                    MyHistory_List.MyHistory.Insert(0, Now);
                    MyHistory_List.SaveHistory();
                    MyProducts_List.MyProducts[i].Brak = 0;
                }
                MyProducts_List.MyProducts[i].IsSelected = false;
            }

            MyProducts_List.SaveProductList();
            
        }

        private void gridlistbrak_MouseEnter(object sender, MouseEventArgs e)
        {
            //gridlistbrak.ItemsSource = MyPackages_List.MyPackages;
            gridlistbrak.Items.Refresh();
        }
    }
}
