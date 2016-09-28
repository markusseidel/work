using CefSharp.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChromiumTest
{
    public class WebBrowser : ChromiumWebBrowser
    {

        public WebBrowser()
        {
            this.Address = "www.google.de";
        }
    }
}
