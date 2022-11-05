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
    /// Логика взаимодействия для AddLegalEnity_Window.xaml
    /// </summary>
    public partial class AddLegalEnity_Window : Window
    {
        public AddLegalEnity_Window()
        {
            InitializeComponent();
        }

        private void Add_New_LegalEnity_Click(object sender, RoutedEventArgs e)
        {
            string newName = New_LegalEnity.Text;
            MyLegalEnitys_List.MyLegalEnitys.Add(newName);
            this.Close();
            //TB_New_Legal_Entity.Items.Add(newName);
           MyLegalEnitys_List.SaveLegalEnityList();
            
        }
    }
}
