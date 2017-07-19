using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace 带属性的Xml
{
    class Program
    {
        static void Main(string[] args)
        {
            //引入命名空间 创建XML文件
            XmlDocument doc = new XmlDocument();
            //添加第一行描述信息，并且添加到doc文档中 
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);

            doc.AppendChild(dec);
            XmlElement order = doc.CreateElement("Order");
            doc.AppendChild(order);

            //创建子节点
            XmlElement customerName = doc.CreateElement("CustomerName");
            order.InnerXml = "<p>我是一个P标签</p>";
            order.AppendChild(customerName);


            XmlElement customernumber = doc.CreateElement("CustomerNumber");
            customernumber.InnerText = "<p>我是一个P标签</p>";
            order.AppendChild(customernumber);

            XmlElement items = doc.CreateElement("Items");
            order.AppendChild(items);

            XmlElement orderitems = doc.CreateElement("OrderItems");
            orderitems.SetAttribute("Name","safdff");
            orderitems.SetAttribute("Price", "123");
            order.AppendChild(orderitems);

            XmlElement orderitems1 = doc.CreateElement("OrderItems1");
            orderitems1.SetAttribute("Name", "safdff");
            orderitems1.SetAttribute("Price", "123");
            order.AppendChild(orderitems1);


            XmlElement orderitems2 = doc.CreateElement("OrderItems2");
            orderitems2.SetAttribute("Name", "safdff");
            orderitems2.SetAttribute("Price", "123");
            order.AppendChild(orderitems2);

            XmlElement orderitems3 = doc.CreateElement("OrderItems3");
            orderitems3.SetAttribute("Name", "safdff");
            orderitems3.SetAttribute("Price", "123");
            order.AppendChild(orderitems3);

            doc.Save("BOOK");
            Console.WriteLine("添加成功");
            Console.ReadKey();

        }
    }
}
