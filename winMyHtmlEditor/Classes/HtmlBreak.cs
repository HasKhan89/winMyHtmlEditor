using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winMyHtmlEditor.Classes
{
    public class HtmlBreak : HtmlControlBase
    {
        public HtmlBreak()
        {
            TagName = "br";
        }

        public override string GetHtmlString()
        {
            return string.Format("<{0} />", TagName);
        }
    }
}
