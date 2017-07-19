using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML
{
    public delegate void WT();
    class Program
    {
        static void Main(string[] args)
        {

            //引入命名空间 创建XML文件
            XmlDocument doc = new XmlDocument();
            //添加第一行描述信息，并且添加到doc文档中 
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0","utf-8",null);

            doc.AppendChild(dec);
            //创建根节点
            XmlElement books = doc.CreateElement("Books");
            //将根节点添加到文档中去
            doc.AppendChild(books);

            //创建子节点
            XmlElement book1 = doc.CreateElement("Book");
            //将子节点添加到根节点添加到中去
            books.AppendChild(book1);


            XmlElement name = doc.CreateElement("Name");
            name.InnerText="金瓶梅";
            book1.AppendChild(name);

            XmlElement price = doc.CreateElement("Price");
            price.InnerText = "10.00";
            book1.AppendChild(price);

            XmlElement des = doc.CreateElement("Des");
            des.InnerText = "好看";
            book1.AppendChild(des);

            doc.Save("BOOK");
            Console.WriteLine("添加成功");
            Console.ReadKey();

        }
    }
}
