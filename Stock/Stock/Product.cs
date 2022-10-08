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
        public int Not_packed { get; set; }
        public Product(string name, int count, int packed, int not_packed)
        {
            Name = name;
            Count = count;
            Packed = packed;
            Not_packed = not_packed;
        }
      
    }
}
