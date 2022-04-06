using HomeWorkkk.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HomeWorkkk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FileStream
            //string filePath = Path.Combine(@"C:\Users\user\Desktop\Ap204Directory", "text.txt");
            ////Console.WriteLine(filePath);
            //string path = @"C:\Users\user\Desktop\Ap204Directory";
            //string anotherPath = Path.Combine(@"C:\Users\user\Desktop\Ap204Directory", "Fatima");

            //string anotherFilepath = Path.Combine(@"C:\Users\user\Desktop\Ap204Directory", "Tural", "datas.txt");
            //string dbPath = Path.Combine(@"C:\Users\user\Desktop\Ap204Directory", "Tural", "Db.txt");
            //string privateTural = Path.Combine(@"C:\Users\user\Desktop\Ap204Directory", "Tural", "shexsi.txt");
            //string galeryPath = Path.Combine(@"C:\Users\user\Desktop\Ap204Directory", "Fatima", "galary.txt");

            //StreamWriter streamWriter = new StreamWriter(anotherFilepath,true);
            //for (int i = 0; i < 3; i++)
            //{
            //    streamWriter.WriteLine("Product" + i);
            //}
            //streamWriter.Close();

            //streamWriter.Close();

            //StreamReader streamReader = new StreamReader(anotherFilepath);

            //string data = streamReader.ReadToEnd();
            //Console.WriteLine(data);


            //streamWriter.Close();
            //using (StreamWriter streamWriter = new StreamWriter(anotherFilepath, true))
            //{
            //    for (int i = 0; i < 3; i++)
            //    {
            //        streamWriter.WriteLine("Product" + i);
            //    }
            //}
            //using (StreamReader streamReader = new StreamReader(anotherFilepath))
            //{


            //    string data = streamReader.ReadToEnd();
            //    Console.WriteLine(data);
            //}
            //streamWriter.Flush();



            //Directory.CreateDirectory(anotherPath);
            //File.Create(filePath);
            //File.Create(anotherFilepath);
            //File.Create(dbPath);
            //File.Create(privateTural);
            //File.Create(galeryPath);
            ////Directory.Delete(path);
            ////File.Create(filePath);
            ////Directory.Delete(path, true);

            //foreach (var item in Directory.GetFiles(anotherPath))
            //{
            //    Console.WriteLine(item);
            //}


            //if (File.Exists(filePath))
            //{
            //    File.Delete(filePath);
            //}
            //else
            //{
            //    Console.WriteLine("Bele bir file yoxdur");
            //}
            //FileStream fileStream = new FileStream("path example", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            //string text = "This is exmple text";
            //byte[] byteArr = Encoding.UTF8.GetBytes(text);
            //foreach (var item in byteArr)
            //{
            //    Console.WriteLine(item);
            //}
            //fileStream.Write(byteArr, 0, byteArr.Length);
            #endregion

            #region Serialize && Deserialize
            //Computer computer = new Computer { Id = 1, Brand = "ASUS", Ram = "8GB", GraphicCard = "RTX2090", Price = 3000.20 };
            //Computer computer1 = new Computer { Id = 2, Brand = "ACER", Ram = "8GB", GraphicCard = "UHDGraphics", Price = 1500.20 };
            //Computer computer2 = new Computer { Id = 3, Brand = "MSI", Ram = "32", GraphicCard = "RTX3090", Price = 3000.20 };
            //Computer computer3 = new Computer { Id = 4, Brand = "Lenova", Ram = "8GB", GraphicCard = "AMD RYZEN 7", Price = 5000.20 };

            //OrderItem orderItem = new OrderItem { Id = 1, Computer = computer, Price = computer.Price };
            //OrderItem orderItem1 = new OrderItem { Id = 2, Computer = computer1, Price = computer1.Price };
            //OrderItem orderItem2 = new OrderItem { Id = 3, Computer = computer2, Price = computer2.Price };
            //OrderItem orderItem3 = new OrderItem { Id = 4, Computer = computer3, Price = computer3.Price };

            //Order order = new Order
            //{
            //    Id = 1,
            //    OrderItems = new List<OrderItem>()
            //    {
            //        orderItem,
            //        orderItem1,
            //        orderItem2,
            //        orderItem3
            //    },
            //    TotalPrice = 12500.50

            //};
            ////Console.WriteLine(order.OrderItems[1].Price);
            //var orderStr = JsonConvert.SerializeObject(order);
            //////Console.WriteLine(orderStr);
            ////using (StreamWriter sw = new StreamWriter(@"C: \Users\user\source\repos\HomeWorkkk\HomeWorkkk\Datas\Data.json,true"))
            ////{
            ////    sw.WriteLine(orderStr);
            ////}
            ////List<OrderItem> orderItems = new System.Collections.Generic.List<OrderItem>()
            ////{

            ////        orderItem,
            ////        orderItem1,
            ////        orderItem2,
            ////        orderItem3
            ////};
            ////{ }

            //using (StreamReader sr = new StreamReader(@"C:\Users\user\source\repos\HomeWorkkk\HomeWorkkk\Datas\Data.json"))
            //{
            //    string result = sr.ReadLine();
                
            //}
            //Console.WriteLine(result);

            //Order orderDes = JsonConvert.DeserializeObject<Order>(result);
            ////Console.WriteLine(orderDes.TotalPrice);
            //foreach (var item in orderDes.OrderItems)
            //{
            //    Console.WriteLine(item.Computer.Brand);
            //}
            #endregion
        }
    }
}