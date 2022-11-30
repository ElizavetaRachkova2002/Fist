using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{

    [Serializable]
    public class MyExceptionEmpyFieldNameOfPackage : Exception
    {
        public MyExceptionEmpyFieldNameOfPackage() { }
        public MyExceptionEmpyFieldNameOfPackage(string message) : base(message) { }
        public MyExceptionEmpyFieldNameOfPackage(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionEmpyFieldNameOfPackage(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyExceptionEmpyFieldCountOfPackage : Exception
    {
        public MyExceptionEmpyFieldCountOfPackage() { }
        public MyExceptionEmpyFieldCountOfPackage(string message) : base(message) { }
        public MyExceptionEmpyFieldCountOfPackage(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionEmpyFieldCountOfPackage(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyExceptionCountOfPackageLessZero : Exception
    {
        public MyExceptionCountOfPackageLessZero() { }
        public MyExceptionCountOfPackageLessZero(string message) : base(message) { }
        public MyExceptionCountOfPackageLessZero(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionCountOfPackageLessZero(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyExceptionCountOfPackageIsDigit : Exception
    {
        public MyExceptionCountOfPackageIsDigit() { }
        public MyExceptionCountOfPackageIsDigit(string message) : base(message) { }
        public MyExceptionCountOfPackageIsDigit(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionCountOfPackageIsDigit(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyExceptionWrongSizeOfPackage : Exception
    {
        public MyExceptionWrongSizeOfPackage() { }
        public MyExceptionWrongSizeOfPackage(string message) : base(message) { }
        public MyExceptionWrongSizeOfPackage(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionWrongSizeOfPackage(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    public class MyExceptionEmptyFieldSizeOfPackage : Exception
    {
        public MyExceptionEmptyFieldSizeOfPackage() { }
        public MyExceptionEmptyFieldSizeOfPackage(string message) : base(message) { }
        public MyExceptionEmptyFieldSizeOfPackage(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionEmptyFieldSizeOfPackage(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    public class Package
     {
        public string _name_package; 
        public string Size { get; set; }
        public bool IsSelected { get; set; }
        public int _count_package;
        public string Name_package
        {
            get { return _name_package; }
            set
            {
                _name_package = value;
                if (String.IsNullOrEmpty(value))
                {
                    throw new MyExceptionEmpyFieldNameOfPackage("Введите название упаковки");
                }
            }
        }
        public int Count_package
        {
            get { return _count_package; }
            set
            {
                _count_package = value;
                if (String.IsNullOrEmpty(value.ToString()))
                {
                    throw new MyExceptionEmpyFieldCountOfPackage("Введите количество упаковки");
                }
                if (value<0)
                {
                    throw new MyExceptionCountOfPackageLessZero("Введите количество упаковки должно быть больше 0");
                }
               
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
}
