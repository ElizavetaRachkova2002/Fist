using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
     class Package
    {
        public string Name_package { get; set; }
        public string Size { get; set; }
        public int Count_package { get; set; }
        public Package(string name, string size, int count)
        {
            Name_package = name;
            Size = size;
            Count_package = count;
        }
    }
}
