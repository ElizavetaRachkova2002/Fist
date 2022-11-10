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
    /// Логика взаимодействия для History_Window.xaml
    /// </summary>
    public partial class History_Window : Window
    {
        public History_Window()
        {
            InitializeComponent();
            HistoryGrid.ItemsSource = MyHistory_List.MyHistory;
        }

        private void HistoryGrid_MouseEnter(object sender, MouseEventArgs e)
        {
            HistoryGrid.ItemsSource = MyHistory_List.MyHistory;
            HistoryGrid.Items.Refresh();

        }
    }
}