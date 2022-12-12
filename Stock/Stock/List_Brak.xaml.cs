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
using ProductsAndPackages;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using System.Xml.Serialization;
using System.Data;
using System.Configuration;

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

        
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
            {
                MyProducts_List.MyProducts[i].IsSelected = false;

            }
            Serializer.SaveList<Product>(MyProducts_List.MyProducts, ConfigurationManager.AppSettings.Get("Productlist"));
            gridlistbrak.Items.Refresh();

        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
           
            var chk = (CheckBox)sender;
            chk.IsChecked = true;
           
            for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
            {
                MyProducts_List.MyProducts[i].IsSelected = true;
              
            }
            gridlistbrak.Items.Refresh();
            Serializer.SaveList<Product>(MyProducts_List.MyProducts, ConfigurationManager.AppSettings.Get("Productlist"));
           

        }
       
        private void Btn_part_brak_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
                {
                    if (MyProducts_List.MyProducts[i].IsSelected == true)
                    {

                        DateTime time = DateTime.Now;
                        string operation = "Списан брак: " + MyProducts_List.MyProducts[i].Name + ", " + MyProducts_List.MyProducts[i].Brak.ToString() + " шт.";
                        History Now = new History(time, operation);
                        MyHistory_List.MyHistory.Insert(0, Now);
                        Serializer.SaveList<History>(MyHistory_List.MyHistory, ConfigurationManager.AppSettings.Get("Historylist"));
                        MyProducts_List.MyProducts[i].Brak = 0;
                    }
                    MyProducts_List.MyProducts[i].IsSelected = false;
                }
                Serializer.SaveList<Product>(MyProducts_List.MyProducts, ConfigurationManager.AppSettings.Get("Productlist"));

                
                chkHeader.IsChecked = false;                
                gridlistbrak.Items.Refresh();

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
