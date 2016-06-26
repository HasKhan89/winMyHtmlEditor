using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winMyHtmlEditor.Classes
{
    public class HtmlList : HtmlControlBase
    {
        public List<string> Items { get; set; }

        public HtmlList()
        {
            Items = new List<string>();
        }

        public override string GetHtmlString()
        {
            string html = string.Format("<{0}>", TagName);

            foreach (string item in Items)
            {
                html += "<li>" + item + "</li>";
            }

            html += string.Format("</{0}>", TagName);

            return html;
        }
    }
}
