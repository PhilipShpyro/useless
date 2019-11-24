using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace DEV_4
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.mail.ru";
            driver.Quit();
        }
    }
}
