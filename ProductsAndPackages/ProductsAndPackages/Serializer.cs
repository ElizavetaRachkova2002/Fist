using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace ProductsAndPackages
{
    [Serializable]

    public static class Serializer
    {
        public static void SaveList<T>(List<T> MySerializeList, string fileName)
        {
            List<T> currentLE_list = new List<T>();
            currentLE_list = MySerializeList;
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (Stream writer = new FileStream(fileName, FileMode.Create))
            {
                serializer.Serialize(writer, currentLE_list);
            }
        }

        public static List<T> LoadList<T>( string fileName)
        {
            if (File.Exists(fileName))
            {
                List<T> tempList;
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                using (Stream reader = new FileStream(fileName, FileMode.Open))
                {
                    tempList = (List<T>)serializer.Deserialize(reader);
                    
                }
                return tempList;
            }
            List<T> NullList = new List<T>();
            return NullList;

        }

        public static void LoadHistoryList(string fileName)
        {
            List<History> currentH_list = new List<History>();
            if (File.Exists(fileName))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<History>));
                using (Stream reader = new FileStream(fileName, FileMode.Open))
                {
                    List<History> tempList = (List<History>)serializer.Deserialize(reader);
                    currentH_list.Clear();
                    DateTime time = DateTime.Now.AddMonths(-3);
                    foreach (var item in tempList)
                    {
                        if (item.Time > time)
                            currentH_list.Add(item);
                    }
                }
                MyHistory_List.MyHistory.Clear();
                MyHistory_List.MyHistory = currentH_list;
            }

        }

    }

   
}
