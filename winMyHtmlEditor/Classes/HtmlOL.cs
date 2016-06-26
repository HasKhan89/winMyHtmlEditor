using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winMyHtmlEditor.Classes
{
    public class HtmlOL : HtmlList
    {
        /*
         * numaralı madde imi..
         * 
         <ol>
            <li>asasasa</li>
            <li>asasasa</li>
            <li>asasasa</li>
         </ol>
         
         */

        public HtmlOL()
        {
            TagName = "ol";
        }

    }
}
