using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winMyHtmlEditor.Interfaces;

namespace winMyHtmlEditor.Classes
{
    public class HtmlBold : HtmlControlBase, IValue
    {
        public string Value { get; set; }

        public HtmlBold()
        {
            TagName = "b";
        }

        public override string GetHtmlString()
        {
            string html = string.Empty;

            html = string.Format("<{0}>{1}</{0}>", TagName, Value);

            return html;
        }
    }
}
