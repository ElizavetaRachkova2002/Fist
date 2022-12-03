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


        public static void LoadProductList()
        {
            if (File.Exists("Productlist.xml"))
            {
                List<Product> currentPr_list = new List<Product>();
                XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
                using (Stream reader = new FileStream("Productlist.xml", FileMode.Open))
                {
                    List<Product> tempList = (List<Product>)serializer.Deserialize(reader);
                    currentPr_list.Clear();
                    foreach (var item in tempList)
                        currentPr_list.Add(item);
                }
                MyProducts.Clear();
                Product[] cur = new Product[currentPr_list.Count];
                currentPr_list.CopyTo(cur);
                for (int i = 0; i < currentPr_list.Count; i++)

                    MyProducts.Add(cur[i]);
            }


        }

        public static void SaveProductList()
        {

            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            using (Stream writer = new FileStream("Productlist.xml", FileMode.Create))
            {
                serializer.Serialize(writer, MyProducts);
            }
        }
    }
    public static class MyPackages_List
    {
        public static List<Package> MyPackages = new List<Package>();

        public static void LoadPackageList()
        {
            if (File.Exists("Packagelist.xml"))
            {
                List<Package> currentPac_list = new List<Package>();
                XmlSerializer serializer = new XmlSerializer(typeof(List<Package>));
                using (Stream reader = new FileStream("Packagelist.xml", FileMode.Open))
                {
                    List<Package> tempList = (List<Package>)serializer.Deserialize(reader);
                    currentPac_list.Clear();
                    foreach (var item in tempList)
                        currentPac_list.Add(item);
                }
                MyPackages_List.MyPackages.Clear();
                MyPackages_List.MyPackages = currentPac_list;
            }
        }

        public static void SavePackageList()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Package>));
            using (Stream writer = new FileStream("Packagelist.xml", FileMode.Create))
            {
                serializer.Serialize(writer, MyPackages);
            }
        }
    }

    public static class MyLegalEnitys_List
    {
        public static List<string> MyLegalEnitys = new List<string>();
        public static string NewLE = "";
        public static bool AddNewLE = false;

        public static void LoadLegalEnityList()
        {
            List<string> currentLE_list = new List<string>();
            if (File.Exists("LegalEnitylist.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
                using (Stream reader = new FileStream("LegalEnitylist.xml", FileMode.Open))
                {
                    List<string> tempList = (List<string>)serializer.Deserialize(reader);
                    currentLE_list.Clear();
                    foreach (var item in tempList)
                        currentLE_list.Add(item);
                }
                MyLegalEnitys.Clear();
                MyLegalEnitys = currentLE_list;
            }

        }

        public static void SaveLegalEnityList()
        {
            List<string> currentLE_list = new List<string>();
            currentLE_list = MyLegalEnitys;
            XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
            using (Stream writer = new FileStream("LegalEnitylist.xml", FileMode.Create))
            {
                serializer.Serialize(writer, currentLE_list);
            }
        }

    }


    public class Brand_List
    {
        public static List<string> MyBrand = new List<string>();
        public static string NewBr = "";
        public static bool AddNewBr = false;

        public static void LoadBrandList()
        {
            List<string> currentLE_list = new List<string>();
            if (File.Exists("Brandlist.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
                using (Stream reader = new FileStream("Brandlist.xml", FileMode.Open))
                {
                    List<string> tempList = (List<string>)serializer.Deserialize(reader);
                    currentLE_list.Clear();
                    foreach (var item in tempList)
                        currentLE_list.Add(item);
                }
                MyBrand.Clear();
                MyBrand = currentLE_list;
            }

        }

        public static void SaveBrandList()
        {
            List<string> currentLE_list = new List<string>();
            currentLE_list = MyBrand;
            XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
            using (Stream writer = new FileStream("Brandlist.xml", FileMode.Create))
            {
                serializer.Serialize(writer, currentLE_list);
            }
        }
    }
}
