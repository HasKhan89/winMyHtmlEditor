using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winMyHtmlEditor.Interfaces;

namespace winMyHtmlEditor.Classes
{
    public class HtmlItalic : HtmlControlBase, IValue
    {
        public string Value { get; set; }

        public HtmlItalic()
        {
            TagName = "i";
        }

        public override string GetHtmlString()
        {
            return string.Format("<{0}>{1}</{0}>", TagName, Value);
        }
    }
}
