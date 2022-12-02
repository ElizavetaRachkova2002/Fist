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
using System.Windows.Shapes;

namespace Stock
{

    [Serializable]
    public class MyExceptionNotEnoughPackage : Exception
    {
        public MyExceptionNotEnoughPackage() { }
        public MyExceptionNotEnoughPackage(string message) : base(message) { }
        public MyExceptionNotEnoughPackage(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionNotEnoughPackage(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyExceptionDeletePackage : Exception
    {
        public MyExceptionDeletePackage() { }
        public MyExceptionDeletePackage(string message) : base(message) { }
        public MyExceptionDeletePackage(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionDeletePackage(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyExceptionNotEnoughUnPackadeProducts : Exception
    {
        public MyExceptionNotEnoughUnPackadeProducts() { }
        public MyExceptionNotEnoughUnPackadeProducts(string message) : base(message) { }
        public MyExceptionNotEnoughUnPackadeProducts(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionNotEnoughUnPackadeProducts(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    [Serializable]
    public class MyExceptionEmptyFieldBrak : Exception
    {
        public MyExceptionEmptyFieldBrak() { }
        public MyExceptionEmptyFieldBrak(string message) : base(message) { }
        public MyExceptionEmptyFieldBrak(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionEmptyFieldBrak(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyExceptionNotEnoughPackaging : Exception
    {
        public MyExceptionNotEnoughPackaging() { }
        public MyExceptionNotEnoughPackaging(string message) : base(message) { }
        public MyExceptionNotEnoughPackaging(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionNotEnoughPackaging(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    [Serializable]
    public class MyExceptionBrakIsDigit : Exception
    {
        public MyExceptionBrakIsDigit() { }
        public MyExceptionBrakIsDigit(string message) : base(message) { }
        public MyExceptionBrakIsDigit(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionBrakIsDigit(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyExceptionCountOfBrakLessZero : Exception
    {
        public MyExceptionCountOfBrakLessZero() { }
        public MyExceptionCountOfBrakLessZero(string message) : base(message) { }
        public MyExceptionCountOfBrakLessZero(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionCountOfBrakLessZero(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyExceptionCountOfProductsIsMoreThanWasNotPacked : Exception
    {
        public MyExceptionCountOfProductsIsMoreThanWasNotPacked() { }
        public MyExceptionCountOfProductsIsMoreThanWasNotPacked(string message) : base(message) { }
        public MyExceptionCountOfProductsIsMoreThanWasNotPacked(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionCountOfProductsIsMoreThanWasNotPacked(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
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
                    throw new MyExceptionEmptyFieldNameOfProduct("Укажите название товара");
                }
                if (String.IsNullOrEmpty(WarmUp_Count.Text))
                {
                    throw new MyExceptionEmptyFieldCount("Укажите количество подготовленного к продаже товара");
                }
                if (String.IsNullOrEmpty(WarmUp_Brak.Text))
                {
                    throw new MyExceptionEmptyFieldBrak("Укажите количество брака товара");
                }
                if (int.TryParse(WarmUp_Count.Text, out int _count1) != true)
                {
                    throw new MyExceptionCountOfProductIsDigit("Количество товара является числом");
                }
                if (int.Parse(WarmUp_Count.Text) < 0)
                {
                    throw new MyExceptionCountLessThanZero("Количество товара больше 0");
                }

                if (int.TryParse(WarmUp_Brak.Text, out int _brak) != true)
                {
                    throw new MyExceptionBrakIsDigit("Количество брака является числом");
                }
                if (int.Parse(WarmUp_Brak.Text) < 0)
                {
                    throw new MyExceptionCountOfBrakLessZero("Количество брака больше 0");
                }


                string name = Combo_WarmUp_Name.Text;
                int count = int.Parse(WarmUp_Count.Text);
                int brak = int.Parse(WarmUp_Brak.Text);
                bool flag_count = false;
                bool flag_package = false;


                /////////////////////////Упаковка не существует

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
                                   // if (MyProducts_List.MyProducts[i].PackageName[k].Split(' ')[0] != MyPackages_List.MyPackages[j].Name_package && MyProducts_List.MyProducts[i].PackageName[k].Split(' ')[1] != MyPackages_List.MyPackages[j].Size)
                                    if (MyProducts_List.MyProducts[i].PackageName[k]!=MyPackages_List.MyPackages[j].Name_package+" "+MyPackages_List.MyPackages[j].Size)
                                    {

                                        z++;
                                    }
                                    if (z == MyPackages_List.MyPackages.Count())
                                    {
                                        z = 0;
                                        throw new MyExceptionDeletePackage("Упаковка для данного товара отсутствует. Измените параметры товара или добавьте новую упаковку.");
                                    }
                                }
                              z = 0;

                                }
                           
                        }
                    }
                }
                

                //////////

                for (int i = 0; i < MyProducts_List.MyProducts.Count; i++)
                {
                    if (MyProducts_List.MyProducts[i].Name == name)
                    {
                        if (int.Parse(WarmUp_Brak.Text) + int.Parse(WarmUp_Count.Text) > MyProducts_List.MyProducts[i].Not_Packed)
                        {
                            throw new MyExceptionNotEnoughUnPackadeProducts("Количество брака и подготовленого товара к продаже больше чем неупакованного товара");
                        }
                        if (MyProducts_List.MyProducts[i].Not_Packed < count)
                        {
                            flag_count = true;
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
                                if (MyProducts_List.MyProducts[i].PackageName[k].Split(' ')[0] == MyPackages_List.MyPackages[j].Name_package && MyProducts_List.MyProducts[i].PackageName[k].Split(' ')[1] == MyPackages_List.MyPackages[j].Size)
                                {


                                    if (MyPackages_List.MyPackages[j].Count_package < count)
                                    {
                                        flag_package = true;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                if (flag_count == true)
                {
                    throw new MyExceptionCountOfProductsIsMoreThanWasNotPacked("Кол-во товара больше, чем было не упаковано");


                }
                else if (flag_package == true)
                {
                    throw new MyExceptionNotEnoughPackage("Не хватает упаковки");

                }
                else
                {

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
            }
            catch (MyExceptionCountOfProductsIsMoreThanWasNotPacked ex)
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
