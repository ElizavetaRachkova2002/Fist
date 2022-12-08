using System;

namespace ProductsAndPackages
{
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
}
