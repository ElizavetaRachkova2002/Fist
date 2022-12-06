using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ProductsAndPackages;
using System.Windows.Data;
using System.Windows.Documents;
using Exceptions;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using System.Configuration;

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
            MyPackages_List.MyPackages = Serializer.LoadList<Package>(ConfigurationManager.AppSettings.Get("Packagelist"));
            //MyPackages_List.LoadPackageList();
            
            for (int i = 0; i < MyPackages_List.MyPackages.Count; i++)
            {
                Combo_package.Items.Add(MyPackages_List.MyPackages[i].Name_package+" " + MyPackages_List.MyPackages[i].Size);
            }

        }
        private void Btn_Delete_Package_Click(object sender, RoutedEventArgs e)
        {
            try {
                if (string.IsNullOrEmpty(Combo_package.Text))
                {
                   throw new MyExceptionEmpyFieldNameOfPackage("Упаковка не выбранa");
                }
                else

                {
                    if (MessageBox.Show("Внимание! Упаковка " + Combo_package.Text + " будет удалена безвозвратно", "Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No) == MessageBoxResult.Yes)
                    {
                        for (int i = 0; i < MyPackages_List.MyPackages.Count(); i++)
                        {
                            int spaceBar = Combo_package.Text.LastIndexOf(" ");
                            string name = Combo_package.Text.Substring(0, spaceBar);
                            string size = Combo_package.Text.Substring(spaceBar + 1);

                            if (MyPackages_List.MyPackages[i].Name_package == name && MyPackages_List.MyPackages[i].Size == size)
                            {
                                string operation = "Удалена упаковка: " + Combo_package.Text;
                                MyPackages_List.MyPackages.RemoveAt(i);
                                DateTime time = DateTime.Now;

                                History Now = new History(time, operation);
                                MyHistory_List.MyHistory.Insert(0, Now);
                                Serializer.SaveList<History>(MyHistory_List.MyHistory, ConfigurationManager.AppSettings.Get("Historylist"));
                                //MyHistory_List.SaveHistory();
                                break;
                            }
                        }
                        Serializer.SaveList(MyPackages_List.MyPackages, ConfigurationManager.AppSettings.Get("Packagelist"));
                        //MyPackages_List.SavePackageList();

                        this.Close();
                    } }
            }
            catch (MyExceptionEmpyFieldNameOfPackage ex)
            {
                MessageBox.Show(ex.Message);
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
                this.Close();
            }
        }
    }
}
