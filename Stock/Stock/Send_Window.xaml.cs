using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.IO;
using Exceptions;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using ProductsAndPackages;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Stock
{
    /// <summary>
    /// Логика взаимодействия для Send_Window.xaml
    /// </summary>
    public partial class Send_Window : Window
    {
        public int RowCount = 2;
        RowDefinition row;
        List<ComboBox> ComboName_List = new List<ComboBox>();
        List<TextBox> TBCount_List = new List<TextBox>();
        
        public Send_Window()
        {
            InitializeComponent();
            GiveTBProduct();
            ComboName_List.Add(Combo_product_send_1);
            TBCount_List.Add(TB_Send_Product_Count_1);
        }

        private void Btn_Add_Send_Product_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string operation = "";
                if (TB_Comment.Text != "")
                    operation = "Отправлен товар. " + TB_Comment.Text + ". \n";
                else operation = "Отправлен товар. \n";

                bool flag = false;
                for (int j = 0; j < ComboName_List.Count; j++)
                {
                    if (String.IsNullOrEmpty(ComboName_List[j].Text))
                    {
                        throw new MyExceptionEmptyFieldNameOfProduct(string.Format("Введите название товара в поле {0}", j+1));
                    }
                    if (String.IsNullOrEmpty(TBCount_List[j].Text))
                    {
                        throw new MyExceptionEmptyFieldCount(string.Format("Введите количество товара {0}", ComboName_List[j].Text));

                    }
                    if (int.TryParse(TBCount_List[j].Text, out int _count1) != true)
                    {
                        throw new MyExceptionCountOfProductIsDigit(string.Format("Количество товара является числом в {0}", ComboName_List[j].Text));
                    }
                    if (int.Parse(TBCount_List[j].Text)<0)
                    {
                        throw new MyExceptionCountLessThanZero(string.Format("Количество товара больше нуля {0}", ComboName_List[j].Text));
                    }
                    
                    string name = ComboName_List[j].Text;
                    int count = int.Parse(TBCount_List[j].Text);

                    for (int i = 0; i < MyProducts_List.MyProducts.Count(); i++)
                    {
                        if (MyProducts_List.MyProducts[i].Name == name)
                        {
                            if (MyProducts_List.MyProducts[i].Packed < count)
                            {
                                flag = true;
                            }
                        }
                    }

                    if (flag == false)
                    {

                        for (int i = 0; i < MyProducts_List.MyProducts.Count(); i++)
                            if (MyProducts_List.MyProducts[i].Name == name)
                            {
                                MyProducts_List.MyProducts[i].Count -= count;
                                MyProducts_List.MyProducts[i].Packed -= count;


                                operation = operation +"Название: "+ MyProducts_List.MyProducts[i].Name+", Aртикул: " + MyProducts_List.MyProducts[i].Vendor_code + ", Кол-во: " + count.ToString() + "; \n";

                                break;
                            }

                        
                        
                    }
                }
                DateTime time = DateTime.Now;
                History Now = new History(time, operation);
                MyHistory_List.MyHistory.Insert(0, Now);
                MyHistory_List.SaveHistory();
                MyProducts_List.SaveProductList();
               

                if (flag == true)
                {
                    throw new MyExceptionCountOfProductLessThenCountOfProductForSend("Кол-во упакованного товара меньше, чем Вы выбрали");
                    
                }
                this.Close();
            }
            catch (MyExceptionCountOfProductLessThenCountOfProductForSend ex)
                 {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (MyExceptionEmptyFieldCount ex)
                {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (MyExceptionCountLessThanZero ex)
             
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (MyExceptionCountOfProductIsDigit ex)
                {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (MyExceptionEmptyFieldNameOfProduct ex)
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

            }
        }

        public void GiveTBProduct()
        {

            Combo_product_send_1.Items.Clear();
            MyProducts_List.LoadProductList();

            for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
            {
                Combo_product_send_1.Items.Add(MyProducts_List.MyProducts[i].Name);
            }


        }

        private void Btn_Plus_Product_For_Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Name_countValue = "TB_Send_Product_Count";
                ComboBox NameValue = new ComboBox();
                RowCount++;
                if (RowCount < 5)
                    this.Height += 120;
                NewGrid.Height += 120;

                row = new RowDefinition();
                MyGrid.RowDefinitions.Add(row);
                Grid.SetRow(Canvas_Last, RowCount - 1);

                Canvas New = new Canvas();
                MyGrid.Children.Add(New);
                TextBlock Nametext = new TextBlock();
                Nametext.Text = "Название";
                New.Children.Add(Nametext);
                Canvas.SetTop(Nametext, 15);
                Canvas.SetLeft(Nametext, 30);
                Nametext.FontSize = 16;

                TextBlock Counttext = new TextBlock();
                Counttext.Text = "Кол-во";
                New.Children.Add(Counttext);
                Canvas.SetTop(Counttext, 60);
                Canvas.SetLeft(Counttext, 30);
                Counttext.FontSize = 16;
                New.Height = 120;
                New.Margin = new Thickness(0, 0, 0, 0);

                TextBox CountValue = new TextBox();
                New.Children.Add(CountValue);
                Canvas.SetTop(CountValue, 60);
                Canvas.SetLeft(CountValue, 150);
                CountValue.Width = 356;
                CountValue.Height = 24;
                CountValue.FontSize = 16;
                TBCount_List.Add(CountValue); 
                Name_countValue = Name_countValue + "_" + (RowCount - 1).ToString();
                CountValue.Name = Name_countValue;
                CountValue.FontSize = 12;
                

                Rectangle rec = new Rectangle();

                New.Children.Add(rec);
                Canvas.SetTop(rec, 92);
                rec.Width = 557;
                rec.Height = 3;
                rec.Fill = Brushes.LightSkyBlue;
                rec.Stroke = Brushes.LightSkyBlue;

                
                New.Children.Add(NameValue);
                Canvas.SetTop(NameValue, 15);
                Canvas.SetLeft(NameValue, 150);
                NameValue.Width = 356;
                NameValue.Height = 23;
                NameValue.FontSize = 16;

                Name_countValue = "Combo_product_send";
                Name_countValue = Name_countValue + "_" + (RowCount - 1).ToString();
                NameValue.Name = Name_countValue;
                ComboName_List.Add(NameValue); 
                NameValue.Items.Clear();
                NameValue.FontSize = 12;
                MyProducts_List.LoadProductList();
                for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
                {
                    NameValue.Items.Add(MyProducts_List.MyProducts[i].Name);
                }


                Grid.SetRow(New, RowCount - 2);
            }
            catch (MyExceptionEmptyFieldCount ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
            catch (MyExceptionEmptyFieldNameOfProduct ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка. Попробуйте повторить действие снова", "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        
    }
}
