using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    //public interface IDataErrorInfo
    //{
    //    string Error { get; }
    //    string this[string columnCount] { get; }
    //}
    public class Product //: IDataErrorInfo
    {
        public string Name { get; set; }
        
        public string Legal_entity { get; set; }   
        public string Brand { get; set; }
        public string Vendor_code { get; set; }
        public ulong Barcode { get; set; } //штрих
        public int Count { get; set; }
        public int Packed { get; set; }
        public bool IsSelected { get; set; }
        public int Not_Packed { get; set; }
        public string PackageName { get; set; }

       

        public int StudentName
        {
            get { return Count; }
            set
            {
                if (value <0)
                {
                  throw new ArgumentException("Name should be between range 6-50");
                }

                Count = value;
            }
        }

        public int Brak { get; set; }

        //public string Error => throw new NotImplementedException();

        //public string this[string columnCount]
        //{
        //    get
        //    {
        //        string error = String.Empty;
        //        switch (columnCount)
        //        {
        //            case "Count":
        //                if (Count < 0)
        //                {
        //                    error = "Количество должно быть больше 0";
        //                }
        //                break;
        //            //case "Name":
        //            //    //Обработка ошибок для свойства Name
        //            //    break;
        //            //case "Position":
        //            //    //Обработка ошибок для свойства Position
        //            //    break;
        //        }
        //        return error;
        //    }
        //}

        public Product() { }
        public Product(string name, string legal_enity, string brand, string vendor_code, ulong barcode, int count, int packed, int not_Packed, string packageName, int brak)
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
            //PackageSize = packageSize;
            Brak = brak;
            IsSelected = false;
        }
        

    }
}
