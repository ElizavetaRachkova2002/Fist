using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using ProductsAndPackages;
using Exceptions;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using System.Configuration;

namespace Stock
{
    /// <summary>
    /// Логика взаимодействия для Add_Brand_Window.xaml
    /// </summary>
    public partial class Add_Brand_Window : Window
    {
        public Add_Brand_Window()
        {
            InitializeComponent();
            Canvas_Add.Visibility = Visibility.Visible;
            Canvas_Delete.Visibility = Visibility.Collapsed;
            Btn_New_Br.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Btn_Delete_Br.Background = new SolidColorBrush(Colors.LightGray);
            GiveTBBrand();
        }

        public void GiveTBBrand()
        {

            TB_Delete_Br.Items.Clear();
            
            Brand_List.MyBrand=Serializer.LoadList<string>(ConfigurationManager.AppSettings.Get("Brandlist"));

            for (int i = 0; i < Brand_List.MyBrand.Count; i++)
            {
                TB_Delete_Br.Items.Add(Brand_List.MyBrand[i]);
            }
        }

        private void Delete_Brand_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TB_Delete_Br.Text))
                {
                    throw new MyExceptionEmptyFieldBrand("Укажите название");
                }
                if (MessageBox.Show("Внмание! Бренд " + TB_Delete_Br.Text + " будет удалён безвозвратно", "Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No) == MessageBoxResult.Yes)
                {
                    for (int i = 0; i < Brand_List.MyBrand.Count; i++)
                    {
                        if (Brand_List.MyBrand[i] == TB_Delete_Br.Text)
                        {
                            Brand_List.MyBrand.RemoveAt(i);
                            string operation = "Удален бренд: " + TB_Delete_Br.Text;
                            DateTime time = DateTime.Now;
                            History Now = new History(time, operation);
                            MyHistory_List.MyHistory.Insert(0, Now);
                            Serializer.SaveList<History>(MyHistory_List.MyHistory, ConfigurationManager.AppSettings.Get("Historylist"));
                            break;
                        }
                    }
                    var currentConfig = ConfigurationManager.AppSettings.Get("Brandlist");
                    Serializer.SaveList<string>(Brand_List.MyBrand, currentConfig);
                    //Brand_List.SaveBrandList();
                    this.Close();
                }  
            }
            catch (MyExceptionEmptyFieldBrand ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex )
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

        private void Add_New_Brand_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(New_Brand.Text))
                {
                    throw new MyExceptionEmptyFieldBrand("Укажите название");
                }
                string newName = New_Brand.Text;
                Brand_List.MyBrand.Add(newName);
                var currentConfig = ConfigurationManager.AppSettings.Get("Brandlist");
                Serializer.SaveList<string>(Brand_List.MyBrand, currentConfig);
                //Serializer.SaveList<string>(Brand_List.MyBrand, ConfigurationManager.AppSettings.Get("Brandlist"));
                //Brand_List.SaveBrandList();
                Brand_List.NewBr = newName;
                Brand_List.AddNewBr = true;
                string operation = "Добавлен новый бренд: " + New_Brand.Text;
                DateTime time = DateTime.Now;
                History Now = new History(time, operation);
                MyHistory_List.MyHistory.Insert(0, Now);
                Serializer.SaveList<History>(MyHistory_List.MyHistory, ConfigurationManager.AppSettings.Get("Historylist"));
                //MyHistory_List.SaveHistory();
                this.Close();
            }
            catch (MyExceptionEmptyFieldBrand ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
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
        private void Btn_Br_Click(object sender, RoutedEventArgs e)
        {
            Canvas_Add.Visibility = Visibility.Visible;
            Canvas_Delete.Visibility = Visibility.Collapsed;
            Btn_New_Br.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Btn_Delete_Br.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void Btn_Delete_Br_Click(object sender, RoutedEventArgs e)
        {
            Canvas_Delete.Visibility = Visibility.Visible;
            Canvas_Add.Visibility = Visibility.Collapsed;
            Btn_New_Br.Background = new SolidColorBrush(Colors.LightGray);
            Btn_Delete_Br.Background = new SolidColorBrush(Colors.LightSkyBlue);
        }
    }
}
