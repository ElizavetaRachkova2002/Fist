using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Stock
{
    [Serializable]
    public static class MyProducts_List
    {
        public static List<Product> MyProducts = new List<Product>();


        public static void LoadProductList()
        {
            if (File.Exists("Productlist.xml"))
            {
                List<Product> currentPr_list = new List<Product>();
                XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
                using (Stream reader = new FileStream("Productlist.xml", FileMode.Open))
                {
                    List<Product> tempList = (List<Product>)serializer.Deserialize(reader);
                    currentPr_list.Clear();
                    foreach (var item in tempList)
                        currentPr_list.Add(item);
                }
                MyProducts.Clear();
                Product[] cur = new Product[currentPr_list.Count];
                currentPr_list.CopyTo(cur);
                for (int i=0;i<currentPr_list.Count;i++)

                MyProducts.Add(cur[i]);
            }
            
            
        }

        public static void SaveProductList()
        {
            
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            using (Stream writer = new FileStream("Productlist.xml", FileMode.Create))
            {
                serializer.Serialize(writer, MyProducts);
            }
        }
    }
}
