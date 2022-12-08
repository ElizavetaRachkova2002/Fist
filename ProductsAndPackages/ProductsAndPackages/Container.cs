using System;
using System.Collections.Generic;

namespace ProductsAndPackages
{
    [Serializable]
    public static class MyProducts_List
    {
        public static List<Product> MyProducts = new List<Product>();
    }
    public static class MyHistory_List
    {
        public static List<History> MyHistory = new List<History>();
    }
    public static class MyPackages_List
    {
        public static List<Package> MyPackages = new List<Package>();
    }

    public static class MyLegalEnitys_List
    {
        public static List<string> MyLegalEnitys = new List<string>();
        public static string NewLE = "";
        public static bool AddNewLE = false;
    }

    public static class Brand_List
    {
        public static List<string> MyBrand = new List<string>();
        public static string NewBr = "";
        public static bool AddNewBr = false;
    }
}
