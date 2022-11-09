using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    public class History
    {
        public DateTime Time { get; set; }
        public string Operation { get; set; }

        public History() { }

        public History( DateTime time, string operation)
        {
            Time = time;
            Operation = operation;
        }
    }
}
