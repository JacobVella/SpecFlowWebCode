using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowWeb
{
    public static class IWebElementExtention
    {

        public static void EnterText(this IWebElement element, string text)
        {
            element.Clear();
            
            element.SendKeys(text);
            

        }

        public static void ClickOnSearchBar(this IWebElement element)
        {

        }

        public static void PressEnter(this IWebElement element)
        {
            element.Submit();//not sure but may change the page
        }
        
    }
}
