using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DEV_7
{
    class Program
    {
        static void Main(string[] args)
        {
            CalkulyatorPage page = new CalkulyatorPage();
            page.GoOn();
            Console.WriteLine(page.GetAfterDotLength());
            page.ChangeAfterDotLength(5);
            Console.WriteLine(page.GetAfterDotLength());
        }
    }
}
