//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;
//using System.Xml.Linq;

//namespace PerExt
//{
//    class Lab
//    {

//        static void Main(string[] args)
//        {
//            string url = @"http://www.weather.go.kr/wid/queryDFSRSS.jsp?zone=4313033500";
//            XElement element = XElement.Load(url);

//            var xmlQuery = from item in element.Descendants("data") select item;
//            foreach (var item in xmlQuery)
//                Console.WriteLine(item);
//        }
//    }
//}
