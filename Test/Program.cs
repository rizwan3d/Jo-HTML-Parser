using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using JoHTMLParser;

namespace Test
{
    
    class Program
    {

        static void Main(string[] args)
        {
            HTML html = new HTML();
            Head head = new Head();
            head.title = "pakistan";
            Tag meta = new Tag();
            meta.Attributes.Add(new Attr("charset", "utf-8"));
            meta.EndingTag = false;
            Tag meta2 = new Tag();
            meta2.Attributes.Add(new Attr("name", "viewport"));
            meta2.Attributes.Add(new Attr("content", "width=device-width, initial-scale=1"));
            meta2.EndingTag = false;
            head.meta.Add(meta);
            head.meta.Add(meta2);

            Tag body = new Tag();
            body.Attributes.Add(new Attr("gbcolor", "#00ff00"));

            Tag div = new Tag();
            div.Name = "div";

            Content h = new Content();
            h.UpContent = "aaaa";
            Tag h1 = new Tag();
            h1.Content.UpContent = "asasas";
            h1.Name = "H1";
            h.tag =h1;

            div.Content = h;

            body.Content.tag = div;

            Console.WriteLine(html.ToString());
            Console.Read();
    


        }
    }
}
