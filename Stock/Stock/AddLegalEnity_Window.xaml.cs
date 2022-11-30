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
            Canvas_Add.Visibility = Visibility.Visible;
            Canvas_Delete.Visibility = Visibility.Collapsed;
            Btn_New_LE.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Btn_Delete_LE.Background = new SolidColorBrush(Colors.LightGray);
            GiveTBLegalEnity();

        }

        private void Add_New_LegalEnity_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string newName = New_LegalEnity.Text;
                if (String.IsNullOrEmpty(newName))
                {
                    throw new MyExceptionEmptyFieldLegalEntity("Введите название юридического лица");
                }
                MyLegalEnitys_List.MyLegalEnitys.Add(newName);
                MyLegalEnitys_List.SaveLegalEnityList();
                MyLegalEnitys_List.NewLE = newName;
                MyLegalEnitys_List.AddNewLE = true;
                string operation = "Добавлено новое юр. лицо: " + New_LegalEnity.Text;

                DateTime time = DateTime.Now;

                History Now = new History(time, operation);
                MyHistory_List.MyHistory.Insert(0, Now);
                MyHistory_List.SaveHistory();
                this.Close();
            }
            catch (MyExceptionEmptyFieldLegalEntity ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void GiveTBLegalEnity()
        {

            TB_Delete_LE.Items.Clear();
            MyLegalEnitys_List.LoadLegalEnityList();

            for (int i = 0; i < MyLegalEnitys_List.MyLegalEnitys.Count; i++)
            {
                TB_Delete_LE.Items.Add(MyLegalEnitys_List.MyLegalEnitys[i]);
            }
        }

        private void Delete_LegalEnity_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(TB_Delete_LE.Text))
                {
                    throw new MyExceptionEmptyFieldLegalEntity("Введите юридическое лицо для удаления");

                }
                for (int i = 0; i < MyLegalEnitys_List.MyLegalEnitys.Count; i++)
                {
                    if (MyLegalEnitys_List.MyLegalEnitys[i] == TB_Delete_LE.Text)
                    {
                        MyLegalEnitys_List.MyLegalEnitys.RemoveAt(i);
                        string operation = "Удалено юр. лицо: " + TB_Delete_LE.Text;

                        DateTime time = DateTime.Now;

                        History Now = new History(time, operation);
                        MyHistory_List.MyHistory.Insert(0, Now);
                        MyHistory_List.SaveHistory();

                        break;

                    }

                }
                MyLegalEnitys_List.SaveLegalEnityList();
                this.Close();
            }
            catch (MyExceptionEmptyFieldLegalEntity ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void Btn_New_LE_Click(object sender, RoutedEventArgs e)
        {
            Canvas_Add.Visibility = Visibility.Visible;
            Canvas_Delete.Visibility = Visibility.Collapsed;
            Btn_New_LE.Background = new SolidColorBrush(Colors.LightSkyBlue);
            Btn_Delete_LE.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void Btn_Delete_LE_Click(object sender, RoutedEventArgs e)
        {
            Canvas_Delete.Visibility = Visibility.Visible;
            Canvas_Add.Visibility = Visibility.Collapsed;
            Btn_New_LE.Background = new SolidColorBrush(Colors.LightGray);
            Btn_Delete_LE.Background = new SolidColorBrush(Colors.LightSkyBlue);
        }
    }
}
