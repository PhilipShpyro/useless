using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DEV_5
{
    class MailRuVisitor
    {
        public IWebDriver Driver { get; set; }
        public void SignIn(string login, string password)
        {
            Driver.Navigate().GoToUrl("https://www.mail.ru");
            IWebElement loginField = Driver.FindElement(By.Id("mailbox:login"));
            loginField.SendKeys(login);
            IWebElement button = Driver.FindElement(By.CssSelector("input[value='Ввести пароль']"));
            button.Click();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            IWebElement passswordField = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("mailbox:password")));
            passswordField.SendKeys(password);
            button.Click();
        }
        public void WriteMessage()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            IWebElement writeButton = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("ico ico_16-compose ico_size_s")));
            writeButton.Click();
        }
    }
}
