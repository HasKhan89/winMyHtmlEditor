using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winMyHtmlEditor.Classes
{
    public class HtmlControlBase
    {
        public string TagName { get; set; }

        public virtual string GetHtmlString()
        {
            string html = string.Empty;
            html = string.Format("<{0}><{0}/>", TagName);

            return html;
        }
    }
}
