using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DEV_4
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\Philipp\source\repos\DEV_4\DEV_4\bin\Debug\netcoreapp2.1");
            driver.Navigate().GoToUrl("https://mail.ru");
            IWebElement loginField = driver.FindElement(By.Name("login"));
            loginField.SendKeys(LOGIN + Keys.Enter);

            IWebElement passwordField = driver.FindElement(By.Name("password"));
            loginField.SendKeys(PASSWORD + Keys.Enter);
            driver.Quit();
        }
    }
}
