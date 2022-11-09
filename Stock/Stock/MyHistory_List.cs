using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Stock
{
    public static class MyHistory_List
    {
        public static List<History> MyHistory = new List<History>();
        

        public static void LoadHistory()
        {
            List<History> currentH_list = new List<History>();
            if (File.Exists("Historylist.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<History>));
                using (Stream reader = new FileStream("Historylist.xml", FileMode.Open))
                {
                    List<History> tempList = (List<History>)serializer.Deserialize(reader);
                    currentH_list.Clear();
                    foreach (var item in tempList)
                        currentH_list.Add(item);
                }
                MyHistory.Clear();
                MyHistory = currentH_list;
            }

        }

        public static void SaveHistory()
        {
            List<History> currentH_list = new List<History>();
            currentH_list = MyHistory;
            XmlSerializer serializer = new XmlSerializer(typeof(List<History>));
            using (Stream writer = new FileStream("Historylist.xml", FileMode.Create))
            {
                serializer.Serialize(writer, currentH_list);
            }
        }
    }
}
