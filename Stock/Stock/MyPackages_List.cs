using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ProductsAndPackages;

namespace Stock
{
    //public static class MyPackages_List
    //{
    //    public static List<Package> MyPackages = new List<Package>();

    //    public static void LoadPackageList()
    //    {
    //        if (File.Exists("Packagelist.xml"))
    //        {
    //            List<Package> currentPac_list = new List<Package>();
    //            XmlSerializer serializer = new XmlSerializer(typeof(List<Package>));
    //            using (Stream reader = new FileStream("Packagelist.xml", FileMode.Open))
    //            {
    //                List<Package> tempList = (List<Package>)serializer.Deserialize(reader);
    //                currentPac_list.Clear();
    //                foreach (var item in tempList)
    //                    currentPac_list.Add(item);
    //            }
    //            MyPackages_List.MyPackages.Clear();
    //            MyPackages_List.MyPackages = currentPac_list;
    //        }
    //    }

    //    public static void SavePackageList()
    //    {
    //        XmlSerializer serializer = new XmlSerializer(typeof(List<Package>));
    //        using (Stream writer = new FileStream("Packagelist.xml", FileMode.Create))
    //        {
    //            serializer.Serialize(writer, MyPackages);
    //        }
    //    }
    //}


}
