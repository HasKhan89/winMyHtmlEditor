using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winMyHtmlEditor.Interfaces;

namespace winMyHtmlEditor.Classes
{
    public class HtmlLink : HtmlControlBase,IValue
    {
        public string Value { get; set; }
        public string Title { get; set; }
        public string Href { get; set; }

        // <a href="www.." title="Google'a git..">google</a>

        public HtmlLink()
        {
            TagName = "a";
            Href = "#";
        }

        public override string GetHtmlString()
        {
            return string.Format("<{0} href='{1}' title='{2}'>{3}</{0}>", 
                TagName, Href, Title, Value);
        }
        
    }
}
