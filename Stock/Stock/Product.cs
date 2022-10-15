using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    public class Product
    {
        public string Name { get; set; }
        
        public string Legal_entity { get; set; }   
        public string Brand { get; set; }
        public string Vendor_code { get; set; }
        public int Barcode { get; set; }
        public int Count { get; set; }
        public int Packed { get; set; }

        public int Not_Packed { get; set; }
        public string PackageName { get; set; }
        public string PackageSize { get; set; }
        public Product() { }
        public Product(string name,  string legal_enity, string brand, string vendor_code, int barcode, int count, int packed, int not_Packed, string packageName, string packageSize )
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
            PackageSize = packageSize;
            
        }
      
    }
}
