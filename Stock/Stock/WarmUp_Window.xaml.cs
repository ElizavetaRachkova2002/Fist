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
using System.IO;
using ProductsAndPackages;
using Exceptions;
using System.Windows.Shapes;

namespace Stock
{
    /// <summary>
    /// Логика взаимодействия для WarmUp_Window.xaml
    /// </summary>
    /// 
    public partial class WarmUp_Window : Window
    {
        public WarmUp_Window()
        {
            InitializeComponent();
            Combo_WarmUp_Name.Items.Clear();
            for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
            {
                Combo_WarmUp_Name.Items.Add(MyProducts_List.MyProducts[i].Name);

            }
        }

        private void Btn_WarmUp_Product_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(Combo_WarmUp_Name.Text))
                {
                    throw new MyExceptionEmptyFieldNameOfProduct("Укажите название");
                }
                
                string name = Combo_WarmUp_Name.Text;
                

                int z = 0;
                for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
                {
                    if (MyProducts_List.MyProducts[i].Name == name)
                    {
                        for (int k = 0; k < MyProducts_List.MyProducts[i].PackageName.Count; k++)
                        {
                            if (MyProducts_List.MyProducts[i].PackageName[k] == "Без упаковки")
                            { }
                            else {
                               for (int j = 0; j < MyPackages_List.MyPackages.Count(); j++)
                                    {
                                   
                                    if (MyProducts_List.MyProducts[i].PackageName[k]!=MyPackages_List.MyPackages[j].Name_package+" "+MyPackages_List.MyPackages[j].Size)
                                    {

                                        z++;
                                    }
                                    if (z == MyPackages_List.MyPackages.Count())
                                    {
                                        z = 0;
                                        throw new MyExceptionDeletePackage("Упаковка для данного товара отсутствует. Добавьте упаковку или измените параметры товара.");
                                    }
                                }
                              z = 0;

                                }
                           
                        }
                    }
                }
                //int count = int.Parse(WarmUp_Count.Text);
                //int brak = int.Parse(WarmUp_Brak.Text);
                if (String.IsNullOrEmpty(WarmUp_Count.Text))
                {
                    throw new MyExceptionEmptyFieldCount("Если нет подготовленного товара, введите 0");
                }
                //if (String.IsNullOrEmpty(WarmUp_Brak.Text))
                //{
                //    throw new MyExceptionEmptyFieldBrak("Если брак отсутствует введите 0");
                //}


                ///
                bool contains_symbols_WarmUp = false;
                foreach (char ch in WarmUp_Count.Text)
                {
                    if (char.IsDigit(ch) != true)
                    {
                        contains_symbols_WarmUp = true;
                        break;
                    }
                }
                if ((WarmUp_Count.Text.Count()) > 9 && contains_symbols_WarmUp == false)
                {
                    throw new MyExceptionCountTypeIsInt("За один раз возможно добавить не более 999999999 единиц товара");
                }
                ////
                if (int.TryParse(WarmUp_Count.Text, out int _count1) != true)
                {
                    throw new MyExceptionCountOfProductIsDigit("В поле 'подготовлено к продаже' допускаются только цифры");
                }
                if (int.Parse(WarmUp_Count.Text) < 0)
                {
                    throw new MyExceptionCountLessThanZero("В поле 'подготовлено к продаже' допускаются только цифры");
                }

                
                if (String.IsNullOrEmpty(WarmUp_Brak.Text))
                {
                    throw new MyExceptionEmptyFieldBrak("Если брак отсутствует введите 0");
                }

                //
                bool contains_symbols_Brak = false;
                foreach (char ch in WarmUp_Brak.Text)
                {
                    if (char.IsDigit(ch) != true)
                    {
                        contains_symbols_Brak = true;
                        break;
                    }
                }
                if ((WarmUp_Brak.Text.Count()) > 9 && contains_symbols_Brak == false)
                {
                    throw new MyExceptionCountTypeIsInt("За один раз можно заброковать не более 999999999 единиц товара");
                }
                //

                if (contains_symbols_Brak == true)
                {
                    contains_symbols_Brak= false;
                    throw new MyExceptionBrakIsDigit("В поле 'брак' допускаются только цифры");
                }
                if (int.Parse(WarmUp_Brak.Text) < 0)
                {
                    throw new MyExceptionCountOfBrakLessZero("В поле 'брак' допускаются только цифры");
                }
                int count = int.Parse(WarmUp_Count.Text);
                int brak = int.Parse(WarmUp_Brak.Text);

                for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
                {
                    if (MyProducts_List.MyProducts[i].Name == name)
                    {
                        if (int.Parse(WarmUp_Brak.Text) + int.Parse(WarmUp_Count.Text) > MyProducts_List.MyProducts[i].Not_Packed)
                        {
                            throw new MyExceptionNotEnoughUnPackadeProducts("Остатки товара меньше, чем Вы пытаетесь упаковать");
                        }
                        if (MyProducts_List.MyProducts[i].Not_Packed < count)
                        {
                            throw new MyExceptionCountOfProductsIsMoreThanWasNotPacked("Остатки товара меньше, чем Вы пытаетесь упаковать");
                        }
                    }
                }
                for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
                {
                    if (MyProducts_List.MyProducts[i].Name == name)
                    {
                        for (int k = 0; k < MyProducts_List.MyProducts[i].PackageName.Count; k++)
                        {
                            for (int j = 0; j < MyPackages_List.MyPackages.Count(); j++)
                            {
                               
                                if (MyProducts_List.MyProducts[i].PackageName[k]==MyPackages_List.MyPackages[j].Name_package+" "+MyPackages_List.MyPackages[j].Size)
                                {


                                    if (MyPackages_List.MyPackages[j].Count_package < count)
                                    {
                                        throw new MyExceptionNotEnoughPackage("Не хватает упаковки");

                                    }
                                }
                            }
                        }
                    }
                }
               
                

                    for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
                    {
                        if (MyProducts_List.MyProducts[i].Name == name)
                        {
                            MyProducts_List.MyProducts[i].Count -= brak;
                            MyProducts_List.MyProducts[i].Brak += brak;
                            MyProducts_List.MyProducts[i].Not_Packed -= brak;
                            MyProducts_List.MyProducts[i].Not_Packed -= count;
                            MyProducts_List.MyProducts[i].Packed += count;
                            for (int j = 0; j < MyProducts_List.MyProducts[i].PackageName.Count; j++)
                            {
                                if (MyProducts_List.MyProducts[i].PackageName[j] != "Без упаковки")
                                    for (int k = 0; k < MyPackages_List.MyPackages.Count(); k++)
                                    {
                                        if (MyProducts_List.MyProducts[i].PackageName[j] == MyPackages_List.MyPackages[k].ToString())
                                        {
                                            MyPackages_List.MyPackages[k].Count_package -= count;


                                        }
                                    }
                            }
                            WarmUp_Count.Clear();
                            WarmUp_Brak.Clear();
                            DateTime time = DateTime.Now;
                            string operation = name + ". Подготовлено к продаже: " + count.ToString() + " шт., Брак: " + brak + " шт.";
                            History Now = new History(time, operation);
                            MyHistory_List.MyHistory.Insert(0, Now);
                            MyHistory_List.SaveHistory();
                            break;

                        }
                    }
                    MyProducts_List.SaveProductList();
                    MyPackages_List.SavePackageList();
                    //App.Current.Shutdown();

                    this.Close();
                
            }
            catch (MyExceptionCountOfProductsIsMoreThanWasNotPacked ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (MyExceptionCountTypeIsInt ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
            catch (MyExceptionBrakIsDigit ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (MyExceptionDeletePackage ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
            
            catch (MyExceptionCountOfBrakLessZero ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (MyExceptionNotEnoughUnPackadeProducts ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (MyExceptionNotEnoughPackaging ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            catch (MyExceptionNotEnoughPackage ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (MyExceptionEmptyFieldCount ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (MyExceptionEmptyFieldBrak ex)
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
    }
}
