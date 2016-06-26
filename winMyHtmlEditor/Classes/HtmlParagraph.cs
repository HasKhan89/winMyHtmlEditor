using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winMyHtmlEditor.Interfaces;

namespace winMyHtmlEditor.Classes
{
    public class HtmlParagraph : HtmlControlBase, IValue
    {
        // <p>asasasa as as a</p>

        public string Value { get; set; }


        public HtmlParagraph()
        {
            TagName = "p";
        }

        public override string GetHtmlString()
        {
            return string.Format("<{0}>{1}</{0}>", TagName, Value);
        }
    }
}
