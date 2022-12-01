using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
   

    [Serializable]
    public class MyExceptionEmptyFieldNameOfProduct : Exception
    {
        public MyExceptionEmptyFieldNameOfProduct() { }
        public MyExceptionEmptyFieldNameOfProduct(string message) : base(message) { }
        public MyExceptionEmptyFieldNameOfProduct(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionEmptyFieldNameOfProduct(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }


    [Serializable]
    public class MyExceptionEmptyFieldLegalEntity : Exception
    {
        public MyExceptionEmptyFieldLegalEntity() { }
        public MyExceptionEmptyFieldLegalEntity(string message) : base(message) { }
        public MyExceptionEmptyFieldLegalEntity(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionEmptyFieldLegalEntity(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    [Serializable]
    public class MyExceptionEmptyFieldBrand : Exception
    {
        public MyExceptionEmptyFieldBrand() { }
        public MyExceptionEmptyFieldBrand(string message) : base(message) { }
        public MyExceptionEmptyFieldBrand(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionEmptyFieldBrand(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyExceptionEmptyFieldVendorCode : Exception
    {
        public MyExceptionEmptyFieldVendorCode() { }
        public MyExceptionEmptyFieldVendorCode(string message) : base(message) { }
        public MyExceptionEmptyFieldVendorCode(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionEmptyFieldVendorCode(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyExceptionEmptyFieldPackageName : Exception
    {
        public MyExceptionEmptyFieldPackageName() { }
        public MyExceptionEmptyFieldPackageName(string message) : base(message) { }
        public MyExceptionEmptyFieldPackageName(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionEmptyFieldPackageName(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyExceptionEmptyFieldBarcode : Exception
    {
        public MyExceptionEmptyFieldBarcode() { }
        public MyExceptionEmptyFieldBarcode(string message) : base(message) { }
        public MyExceptionEmptyFieldBarcode(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionEmptyFieldBarcode(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyExceptionEmptyFieldCount : Exception
    {
        public MyExceptionEmptyFieldCount() { }
        public MyExceptionEmptyFieldCount(string message) : base(message) { }
        public MyExceptionEmptyFieldCount(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionEmptyFieldCount(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyExceptionCountLessThanZero : Exception
    {
        public MyExceptionCountLessThanZero() { }
        public MyExceptionCountLessThanZero(string message) : base(message) { }
        public MyExceptionCountLessThanZero(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionCountLessThanZero(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyExceptionBarcodeLessThanZero : Exception
    {
        public MyExceptionBarcodeLessThanZero() { }
        public MyExceptionBarcodeLessThanZero(string message) : base(message) { }
        public MyExceptionBarcodeLessThanZero(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionBarcodeLessThanZero(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyExceptionCountOfProductIsDigit : Exception
    {
        public MyExceptionCountOfProductIsDigit() { }
        public MyExceptionCountOfProductIsDigit(string message) : base(message) { }
        public MyExceptionCountOfProductIsDigit(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionCountOfProductIsDigit(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyExceptionBarcodeOfProductIsDigit : Exception
    {
        public MyExceptionBarcodeOfProductIsDigit() { }
        public MyExceptionBarcodeOfProductIsDigit(string message) : base(message) { }
        public MyExceptionBarcodeOfProductIsDigit(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionBarcodeOfProductIsDigit(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyExceptionCountOfProductLessThenCountOfProductForSend : Exception
    {
        public MyExceptionCountOfProductLessThenCountOfProductForSend() { }
        public MyExceptionCountOfProductLessThenCountOfProductForSend(string message) : base(message) { }
        public MyExceptionCountOfProductLessThenCountOfProductForSend(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionCountOfProductLessThenCountOfProductForSend(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class Product //: IDataErrorInfo
    {
    
        private string _name;
      
         string _legal_entity;
       
        string _brand;
     
        string _vendor_code;
       
        ulong _barcode; //штрих
  
       int _count;
        
         List<string> _packageName;

       
        public string Legal_entity {
            get { return _legal_entity; }
            set
            {
                _legal_entity = value;
                if (String.IsNullOrEmpty(value))
                {
                    throw new MyExceptionEmptyFieldLegalEntity("Введите юридическое лицо товара");
                }
            }
        }
        public string Brand
        {
            get { return _brand; }
            set
            {
                _brand = value;
                if (String.IsNullOrEmpty(value))
                {
                    throw new MyExceptionEmptyFieldBrand("Введите бренд товара");
                }
            }
        }
        public string Vendor_code {
            get { return _vendor_code; }
            set
            {
                _vendor_code = value;
                if (String.IsNullOrEmpty(value))
                {
                    throw new MyExceptionEmptyFieldVendorCode("Введите артикул товара");
                }
            }
        
        }
      
        public ulong Barcode {
            get { return _barcode; }
            set
            {
                _barcode = value;

                if (value.ToString() == "")
                {
                    throw new MyExceptionEmptyFieldBarcode("Введите штрихкод товара");
                }
                if (value < 0)
                {
                    throw new MyExceptionBarcodeLessThanZero("Штрихкод меньше нуля");
                }
                //if (value.ToString().All(char.IsDigit))
                //{
                //    throw new MyExceptionBarcodeOfProductIsDigit("Штрихкод товара это число");
                //}
            }
        } //штрих
        public int Count {
            get { return _count; }
            set
            {
                _count = value;
                if (String.IsNullOrEmpty(value.ToString()))
                {
                    throw new MyExceptionEmptyFieldCount("Введите количество товара");
                }
                if (value < 0)
                {
                    throw new MyExceptionCountLessThanZero("Количество меньше нуля");
                }
                //if (int.TryParse(Pack_Exist_Count.Text, out int count) != true)
                //{
                //    throw new MyExceptionCountOfPackageLessZero("кол-во товара это число");
                //}
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
                
                for (int i = 0; i < value.Count; i++)
                    if (String.IsNullOrEmpty(value[i]))
                    {
                        throw new MyExceptionEmptyFieldBrand("Введите упаковку для товара");
                    }
                _packageName = value;
            }
        }


        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                if (String.IsNullOrEmpty(value))
                {
                    throw new MyExceptionEmptyFieldNameOfProduct("Введите название товара");
                }
            }
        }

        public int Brak { get; set; }

        public Product() { }
        public Product(string name, string legal_enity, string brand, string vendor_code, ulong barcode, int count, int packed, int not_Packed, List<string> packageName, int brak)
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
