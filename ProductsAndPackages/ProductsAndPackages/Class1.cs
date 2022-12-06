using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ProductsAndPackages
{
    [Serializable]

    public static class Serializer
    {
        public static void SaveList<T>(List<T> MySerializeList, string fileName)
        {
            List<T> currentLE_list = new List<T>();
            currentLE_list = MySerializeList;
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (Stream writer = new FileStream(fileName, FileMode.Create))
            {
                serializer.Serialize(writer, currentLE_list);
            }
        }

        public static List<T> LoadList<T>( string fileName)
        {
            if (File.Exists(fileName))
            {
                List<T> tempList;
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                using (Stream reader = new FileStream(fileName, FileMode.Open))
                {
                    tempList = (List<T>)serializer.Deserialize(reader);
                    
                }
                return tempList;
            }
            List<T> NullList = new List<T>();
            return NullList;

        }

    }

    public class Product
    {

        private string _name;

        string _legal_entity;

        string _brand;

        string _vendor_code;

        string _barcode; //штрих

        int _count;

        List<string> _packageName;


        public string Legal_entity
        {
            get { return _legal_entity; }
            set
            {
                _legal_entity = value;
                
            }
        }
        public string Brand
        {
            get { return _brand; }
            set
            {
                _brand = value;
               
            }
        }
        public string Vendor_code
        {
            get { return _vendor_code; }
            set
            {
                _vendor_code = value;
               
            }

        }

        public string Barcode
        {
            get { return _barcode; }
            set
            {
                _barcode = value;

                
            }
        } //штрих
        public int Count
        {
            get { return _count; }
            set
            {
                _count = value;
                
            }
        }
        public int Packed { get; set; }
        public bool IsSelected { get; set; }
        public int Not_Packed { get; set; }

        public List<string> PackageName
        {
            get { return _packageName; }
            set
            {

             
                _packageName = value;
            }
        }


        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                
            }
        }

        public int Brak { get; set; }

        public Product() { }
        public Product(string name, string legal_enity, string brand, string vendor_code, string barcode, int count, int packed, int not_Packed, List<string> packageName, int brak)
        {
            Name = name;
            Legal_entity = legal_enity;
            Brand = brand;
            Vendor_code = vendor_code;
            Barcode = barcode;
            Count = count;
            Packed = packed;
            Not_Packed = not_Packed;
            PackageName = packageName;
            Brak = brak;
            IsSelected = false;
        }

    }

    public class Package
    {
        private string _name_package;
        public string Size { get; set; }
        public bool IsSelected { get; set; }
        private int _count_package;
        public string Name_package
        {
            get { return _name_package; }
            set
            {
                _name_package = value;
              
            }
        }
        public int Count_package
        {
            get { return _count_package; }
            set
            {
                _count_package = value;
               

            }
        }
        public Package() { }
        public Package(string name, string size, int count)
        {
            Name_package = name;
            Size = size;
            Count_package = count;
            IsSelected = false;
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", Name_package, Size);
        }
    }
    [Serializable]
    public static class MyProducts_List
    {
        public static List<Product> MyProducts = new List<Product>();


    }
    public class History
    {
        public DateTime Time { get; set; }
        public string Operation { get; set; }

        public History() { }

        public History(DateTime time, string operation)
        {
            Time = time;
            Operation = operation;
        }
    }
    public static class MyHistory_List
    {
        public static List<History> MyHistory = new List<History>();


        public static void LoadHistory()
        {
            List<History> currentH_list = new List<History>();
            if (File.Exists("Historylist.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<History>));
                using (Stream reader = new FileStream("Historylist.xml", FileMode.Open))
                {
                    List<History> tempList = (List<History>)serializer.Deserialize(reader);
                    currentH_list.Clear();
                    DateTime time = DateTime.Now.AddMonths(-3);
                    foreach (var item in tempList)
                    {
                        if (item.Time > time)
                            currentH_list.Add(item);
                    }
                }
                MyHistory.Clear();
                MyHistory = currentH_list;
            }

        }

    }
    public static class MyPackages_List
    {
        public static List<Package> MyPackages = new List<Package>();

        
    }

    public static class MyLegalEnitys_List
    {
        public static List<string> MyLegalEnitys = new List<string>();
        public static string NewLE = "";
        public static bool AddNewLE = false;

        

    }


    public class Brand_List
    {
        public static List<string> MyBrand = new List<string>();
        public static string NewBr = "";
        public static bool AddNewBr = false;

        
    }
}
