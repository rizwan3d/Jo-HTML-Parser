using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoHTMLParser
{
    public class HTML
    {
        public string DocType ;
        public Head Head ;
        public Tag Body ;

        public HTML(){
            DocType = "";
            Head = new Head();
            Body = new Tag();
        }

        public override string ToString()
        {
            string ToReturn = DocType + Environment.NewLine + "<html>" + Environment.NewLine;
            ToReturn += Head.ToString();
            ToReturn += Body.ToString();
            ToReturn += Environment.NewLine + "</html>";
            return ToReturn;
        }
    }
    public class Head

    {
        public List<Tag> meta ;
        public string title ;
        public List<Tag> Link ;
        public Tag Style ;
        public List<Tag> Script ;

        public Head()
        {
            meta = new List<Tag>();
            title = string.Empty;
            Link = new List<Tag>();
            Style = new Tag();
            Script = new List<Tag>();
        }
        public override string ToString()
        {
            string ToReturn = string.Empty;
            foreach (Tag _ in meta)
            {
                ToReturn += _.ToString() + Environment.NewLine;
            }
            ToReturn += "<title>" + Environment.NewLine + "\t" + title + Environment.NewLine + "</title>" + Environment.NewLine;
            foreach (Tag _ in Link)
            {
                ToReturn += _.ToString() + Environment.NewLine;
            }
            ToReturn += Style.ToString();
            foreach (Tag _ in Script)
            {
                ToReturn += _.ToString() + Environment.NewLine;
            }
            return ToReturn;
        }
    }
    public class Content
    {
        public string UpContent ;
        public Tag tag { get; set; }

        public string DownContent ;

        public Content()
        {
            UpContent = string.Empty;
            DownContent = string.Empty;
            tag = new Tag();
        }

        public override string ToString()
        {
            string ToReturn = UpContent;
            if(tag != null)
                ToReturn += tag.ToString();
            ToReturn += DownContent;
            return ToReturn;
        }
    }

    public class Tag
    {
        public string Name;
        //public Dictionary<string, string> Attributes { get; set; }
        public List<Attr> Attributes ;
        public Content Content ;
        public bool EndingTag ;
        public Tag()
        {
            Name = string.Empty;
            Attributes = new List<Attr>();
            Content = new Content();
            EndingTag = true;
        }

        public override string ToString()
        {
            string ToReturn = string.Empty;
            ToReturn += "<" + this.Name;
            foreach(Attr _ in Attributes)
            {
                ToReturn += _.Name + "=\"" + _.Value + "\"";
            }
            if(!EndingTag)
                ToReturn += " />" + Environment.NewLine;
            else
            ToReturn += ">" + Environment.NewLine;
            if (Content != null)
                ToReturn += Content.ToString();

            if (EndingTag)
                ToReturn += "</" + this.Name + ">" + Environment.NewLine;
            return ToReturn;
        }
    }
    public class Attr
    {
        public string Name ;
        public string Value ;
        public Attr(string Name,string Value)
        {
            this.Name = Name;
            this.Value = Value;
        }
    }
   
}
