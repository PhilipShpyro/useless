using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DEV_5
{
    class Program
    {
        const string LOGIN1 = "vpupchick";
        const string PASSWORD1 = "AutomatedVasya247";
        const string LOGIN2 = "vpupchick";
        const string PASSWORD2 = "AutomatedVasya247";

        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\Philipp\source\repos\DEV_5\DEV_5\bin\Debug\netcoreapp2.1");
            MailRuVisitor visitor1 = new MailRuVisitor();
            visitor1.Driver = driver;

            visitor1.SignIn("vpupchick", "AutomatedVasya247");

            visitor1.WriteMessage();
        }
    }
}
