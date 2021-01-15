using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {

        public static void Main()
        {
            String link = "https://eee.ieu.edu.tr/tr/syllabus/type/read/id/SE+307";
            HtmlNode node;
            var html = @link;
            HtmlWeb web = new HtmlWeb();
            web.OverrideEncoding = Encoding.UTF8;

            var doc = web.Load(html);
            node = doc.DocumentNode.SelectSingleNode("//div[contains(@class, 'col-xs-12 col-sm-12 col-md-8 col-lg-9 text-primary-color-content')]");

            Console.WriteLine(node.OuterHtml);
            writeHTML(node);

        }


        public static void writeHTML(HtmlNode node)
        {
            string path = @"D:\BELGELER/my.txt"; 
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(node.OuterHtml);

                }
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

        }



    }
}
