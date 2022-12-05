using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    [Serializable]
    public class MyExceptionPackageAlreadyExists : Exception
    {
        public MyExceptionPackageAlreadyExists() { }
        public MyExceptionPackageAlreadyExists(string message) : base(message) { }
        public MyExceptionPackageAlreadyExists(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionPackageAlreadyExists(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyExceptionProductAlreadyExistAfterChangeWithThisName : Exception
    {
        public MyExceptionProductAlreadyExistAfterChangeWithThisName() { }
        public MyExceptionProductAlreadyExistAfterChangeWithThisName(string message) : base(message) { }
        public MyExceptionProductAlreadyExistAfterChangeWithThisName(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionProductAlreadyExistAfterChangeWithThisName(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyExceptionProductAlreadyExistAfterChangewithThisBarcode : Exception
    {
        public MyExceptionProductAlreadyExistAfterChangewithThisBarcode() { }
        public MyExceptionProductAlreadyExistAfterChangewithThisBarcode(string message) : base(message) { }
        public MyExceptionProductAlreadyExistAfterChangewithThisBarcode(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionProductAlreadyExistAfterChangewithThisBarcode(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyExceptionProductAlreadyExistAfterChangeWithThisVendorCode : Exception
    {
        public MyExceptionProductAlreadyExistAfterChangeWithThisVendorCode() { }
        public MyExceptionProductAlreadyExistAfterChangeWithThisVendorCode(string message) : base(message) { }
        public MyExceptionProductAlreadyExistAfterChangeWithThisVendorCode(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionProductAlreadyExistAfterChangeWithThisVendorCode(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyExceptionNotEnoughPackage : Exception
    {
        public MyExceptionNotEnoughPackage() { }
        public MyExceptionNotEnoughPackage(string message) : base(message) { }
        public MyExceptionNotEnoughPackage(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionNotEnoughPackage(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyExceptionDeletePackage : Exception
    {
        public MyExceptionDeletePackage() { }
        public MyExceptionDeletePackage(string message) : base(message) { }
        public MyExceptionDeletePackage(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionDeletePackage(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyExceptionNotEnoughUnPackadeProducts : Exception
    {
        public MyExceptionNotEnoughUnPackadeProducts() { }
        public MyExceptionNotEnoughUnPackadeProducts(string message) : base(message) { }
        public MyExceptionNotEnoughUnPackadeProducts(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionNotEnoughUnPackadeProducts(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    [Serializable]
    public class MyExceptionEmptyFieldBrak : Exception
    {
        public MyExceptionEmptyFieldBrak() { }
        public MyExceptionEmptyFieldBrak(string message) : base(message) { }
        public MyExceptionEmptyFieldBrak(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionEmptyFieldBrak(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyExceptionNotEnoughPackaging : Exception
    {
        public MyExceptionNotEnoughPackaging() { }
        public MyExceptionNotEnoughPackaging(string message) : base(message) { }
        public MyExceptionNotEnoughPackaging(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionNotEnoughPackaging(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    [Serializable]
    public class MyExceptionBrakIsDigit : Exception
    {
        public MyExceptionBrakIsDigit() { }
        public MyExceptionBrakIsDigit(string message) : base(message) { }
        public MyExceptionBrakIsDigit(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionBrakIsDigit(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyExceptionCountOfBrakLessZero : Exception
    {
        public MyExceptionCountOfBrakLessZero() { }
        public MyExceptionCountOfBrakLessZero(string message) : base(message) { }
        public MyExceptionCountOfBrakLessZero(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionCountOfBrakLessZero(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    [Serializable]
    public class MyExceptionCountOfProductsIsMoreThanWasNotPacked : Exception
    {
        public MyExceptionCountOfProductsIsMoreThanWasNotPacked() { }
        public MyExceptionCountOfProductsIsMoreThanWasNotPacked(string message) : base(message) { }
        public MyExceptionCountOfProductsIsMoreThanWasNotPacked(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionCountOfProductsIsMoreThanWasNotPacked(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
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
    public class MyExceptionCountTypeIsInt : Exception
    {
        public MyExceptionCountTypeIsInt() { }
        public MyExceptionCountTypeIsInt(string message) : base(message) { }
        public MyExceptionCountTypeIsInt(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionCountTypeIsInt(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    [Serializable]
    public class MyExceptionInvalidCount : Exception
    {
        public MyExceptionInvalidCount() { }
        public MyExceptionInvalidCount(string message) : base(message) { }
        public MyExceptionInvalidCount(string message, Exception inner) : base(message, inner) { }
        protected MyExceptionInvalidCount(
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
}
