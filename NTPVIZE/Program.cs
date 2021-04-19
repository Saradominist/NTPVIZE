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



            Console.ReadKey();


        }
    }
}
