using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;


namespace NTPVIZE
{
    class Program
    {
        static void Main(string[] args)
        {

            XmlDocument fotomac = new XmlDocument();
            XmlDocument xmlim = new XmlDocument();

            xmlim.Load("fotomac.xml");

            XElement root = XElement.Load("fotomac.xml");

            fotomac.Load("https://www.fotomac.com.tr/rss/anasayfa.xml");

            foreach (XmlNode item in fotomac.SelectNodes("rss/channel/item"))
            {
                Console.WriteLine(item["title"].InnerText);

                XElement haber = new XElement("haber");
                XElement baslik = new XElement("baslik");

                baslik.Value = item["title"].InnerText;

                haber.Add(baslik);
                root.Add(haber);

            }

            Console.ReadKey();


        }
    }
}
