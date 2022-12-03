using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Stock
{
    //class Brand_List
    //{
    //    public static List<string> MyBrand = new List<string>();
    //    public static string NewBr = "";
    //    public static bool AddNewBr = false;

    //    public static void LoadBrandList()
    //    {
    //        List<string> currentLE_list = new List<string>();
    //        if (File.Exists("Brandlist.xml"))
    //        {
    //            XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
    //            using (Stream reader = new FileStream("Brandlist.xml", FileMode.Open))
    //            {
    //                List<string> tempList = (List<string>)serializer.Deserialize(reader);
    //                currentLE_list.Clear();
    //                foreach (var item in tempList)
    //                    currentLE_list.Add(item);
    //            }
    //            MyBrand.Clear();
    //            MyBrand = currentLE_list;
    //        }

    //    }

    //    public static void SaveBrandList()
    //    {
    //        List<string> currentLE_list = new List<string>();
    //        currentLE_list = MyBrand;
    //        XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
    //        using (Stream writer = new FileStream("Brandlist.xml", FileMode.Create))
    //        {
    //            serializer.Serialize(writer, currentLE_list);
    //        }
    //    }
    //}
}
