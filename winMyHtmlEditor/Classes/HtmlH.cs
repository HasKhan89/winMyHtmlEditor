using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winMyHtmlEditor.Interfaces;

namespace winMyHtmlEditor.Classes
{
    public class HtmlH : HtmlControlBase, IValue
    {
        public int HNo { get; set; }
        public string Value { get; set; }

        public HtmlH()
        {
            TagName = "h";
        }

        public override string GetHtmlString()
        {
            return string.Format(
                "<{0}{1}>{2}</{0}{1}>", TagName, HNo, Value);
        }
    }


    public class HtmlH1 : HtmlH
    {
        public HtmlH1()
        {
            HNo = 1;
        }
    }

    public class HtmlH2 : HtmlH
    {
        public HtmlH2()
        {
            HNo = 2;
        }
    }

    public class HtmlH3 : HtmlH
    {
        public HtmlH3()
        {
            HNo = 3;
        }
    }

    public class HtmlH4 : HtmlH
    {
        public HtmlH4()
        {
            HNo = 4;
        }
    }

    public class HtmlH5 : HtmlH
    {
        public HtmlH5()
        {
            HNo = 5;
        }
    }

    public class HtmlH6 : HtmlH
    {
        public HtmlH6()
        {
            HNo = 6;
        }
    }
}
