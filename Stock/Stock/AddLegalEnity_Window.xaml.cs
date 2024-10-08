﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Exceptions;
using System.IO;
using ProductsAndPackages;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Configuration;

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
                   throw new MyExceptionEmptyFieldLegalEntity("Введите юр. лицо");
                }
                MyLegalEnitys_List.MyLegalEnitys.Add(newName);
                Serializer.SaveList(MyLegalEnitys_List.MyLegalEnitys, ConfigurationManager.AppSettings.Get("LegalEnitylist"));
                MyLegalEnitys_List.NewLE = newName;
                MyLegalEnitys_List.AddNewLE = true;
                string operation = "Добавлено новое юр. лицо: " + New_LegalEnity.Text;

                DateTime time = DateTime.Now;

                History Now = new History(time, operation);
                MyHistory_List.MyHistory.Insert(0, Now);
                Serializer.SaveList<History>(MyHistory_List.MyHistory, ConfigurationManager.AppSettings.Get("Historylist"));
                this.Close();
            }
            catch (MyExceptionEmptyFieldLegalEntity ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButton.OK, MessageBoxImage.Error);
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

        public void GiveTBLegalEnity()
        {

            TB_Delete_LE.Items.Clear();
            MyLegalEnitys_List.MyLegalEnitys= Serializer.LoadList<string>(ConfigurationManager.AppSettings.Get("LegalEnitylist"));

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
                    throw new MyExceptionEmptyFieldLegalEntity("Введите юридическое лицо");

                }
                if (MessageBox.Show("Внмание! Юр. лицо " + TB_Delete_LE.Text + " будет удалено безвозвратно", "Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No) == MessageBoxResult.Yes)
                {
                    for (int i = 0; i < MyLegalEnitys_List.MyLegalEnitys.Count; i++)
                    {
                        if (MyLegalEnitys_List.MyLegalEnitys[i] == TB_Delete_LE.Text)
                        {
                            MyLegalEnitys_List.MyLegalEnitys.RemoveAt(i);
                            string operation = "Удалено юр. лицо: " + TB_Delete_LE.Text;

                            DateTime time = DateTime.Now;

                            History Now = new History(time, operation);
                            MyHistory_List.MyHistory.Insert(0, Now);
                            Serializer.SaveList<History>(MyHistory_List.MyHistory, ConfigurationManager.AppSettings.Get("Historylist"));

                            break;

                        }

                    }
                    Serializer.SaveList(MyLegalEnitys_List.MyLegalEnitys, ConfigurationManager.AppSettings.Get("LegalEnitylist"));
                    this.Close();
                }
            }
            catch (MyExceptionEmptyFieldLegalEntity ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButton.OK, MessageBoxImage.Error);
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
