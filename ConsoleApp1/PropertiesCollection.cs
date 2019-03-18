using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ConsoleApp1
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        Classname
    }

    class PropertiesCollection
    {
        //Auto-implemented properties
        public static IWebDriver driver { get; set; }

    }
}
