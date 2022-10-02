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
        public int Barcode { get; set; }
        public int Count { get; set; }

        public int Packed { get; set; }
        public int Not_packed { get; set; }
    }
}
