using System.Collections.Generic;

namespace ProductsAndPackages
{
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
}
