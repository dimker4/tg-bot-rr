using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace ConsoleApplication1
{
    class Parser
    {
        private const string url = "https://russiarunning.com/events?d=run";
        public string Pars()
        {
            var url = Parser.url;
            var web = new HtmlWeb();
            var doc = web.Load(url);

            //var node = doc.DocumentNode.SelectSingleNode("//head/title"); // Заголовок
            //var n = doc.DocumentNode.Descendants("a").Where();
            var list = n.ToList();

            //foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[contains(@class, 'ellipsis')]"))
            //{
            //    var a = link.OuterHtml;
            //}

            var node = doc.DocumentNode.SelectSingleNode("//body//main//div[@class='main-content']//div[@class='body-content']//div[@class=' container-fluid']"); // Заголовок

            return n.ToString();
        }
    }
}