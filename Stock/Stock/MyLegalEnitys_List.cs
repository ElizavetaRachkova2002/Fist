using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Stock
{
    public static class MyLegalEnitys_List
    {
        public static List<string> MyLegalEnitys= new List<string>();

        public static void LoadLegalEnityList()
        {
            List<string> currentLE_list = new List<string>();
            if (File.Exists("LegalEnitylist.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
                using (Stream reader = new FileStream("LegalEnitylist.xml", FileMode.Open))
                {
                    List<string> tempList = (List<string>)serializer.Deserialize(reader);
                   currentLE_list.Clear();
                    foreach (var item in tempList)
                       currentLE_list.Add(item);
                }
                MyLegalEnitys.Clear();
                MyLegalEnitys = currentLE_list;
            }
            
        }

        public static void SaveLegalEnityList()
        {
            List<string> currentLE_list = new List<string>();
            currentLE_list = MyLegalEnitys;
            XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
            using (Stream writer = new FileStream("LegalEnitylist.xml", FileMode.Create))
            {
                serializer.Serialize(writer, currentLE_list);
            }
        }

    }
}
