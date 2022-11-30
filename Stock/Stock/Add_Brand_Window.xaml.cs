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
            Brand_List.LoadBrandList();

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
                    throw new MyExceptionEmptyFieldBrand("Укажите название бренда");
                }
                for (int i = 0; i < Brand_List.MyBrand.Count; i++)
                {
                    if (Brand_List.MyBrand[i] == TB_Delete_Br.Text)
                    {
                        Brand_List.MyBrand.RemoveAt(i);
                        string operation = "Удален бренд: " + TB_Delete_Br.Text;

                        DateTime time = DateTime.Now;

                        History Now = new History(time, operation);
                        MyHistory_List.MyHistory.Insert(0, Now);
                        MyHistory_List.SaveHistory();

                        break;

                    }

                }
                Brand_List.SaveBrandList();
                this.Close();
            }
            catch (MyExceptionEmptyFieldBrand ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("", "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private void Add_New_Brand_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(New_Brand.Text))
                {
                    throw new MyExceptionEmptyFieldBrand("Укажите название бренда");
                }
                string newName = New_Brand.Text;
                Brand_List.MyBrand.Add(newName);
                Brand_List.SaveBrandList();
                Brand_List.NewBr = newName;
                Brand_List.AddNewBr = true;
                string operation = "Добавлен новый бренд: " + New_Brand.Text;

                DateTime time = DateTime.Now;

                History Now = new History(time, operation);
                MyHistory_List.MyHistory.Insert(0, Now);
                MyHistory_List.SaveHistory();
                this.Close();
            }
            catch (MyExceptionEmptyFieldBrand ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("", "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);

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
