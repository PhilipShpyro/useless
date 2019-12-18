using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DEV_7
{
    class CalkulyatorPage
    {
        private IWebDriver driver;
        WebDriverWait wait;

        public CalkulyatorPage()
        {
            driver = new ChromeDriver(@"C:\Users\HP\source\repos\DEV_7\DEV_7\bin\Debug\netcoreapp2.1");
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
        }
        public string GetAnswer()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//table[@class='korpus']/tbody[1]/tr[2]/td[2]/div[1]"))).Text;
        }
        public void GoOn()
        {
            driver.Navigate().GoToUrl("http://calkulyator.ru/");
        }
        public IWebElement this [string buttonName]
        {
            get
            {
                string path = new Dictionary().GetPath(buttonName);
                return wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(path)));
            }
        }
        public void ChangeAfterDotLength(int length)
        {
            if (length > 12 || length < 0)
            {
                throw new Exception();
            }
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//table[@class='korpus']/tbody[1]/tr[5]/td[2]/a[1]")));
            element.Click();
            element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//table[@class='korpus']/tbody[1]/tr[5]/td[2]/select[1]")));
            element.Click();
            element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("select[onchange='otvIzm(this.value);']")));
            element.Click();
            element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("option[value='" + length.ToString() + "']")));
            element.Click();
        }
        public int GetAfterDotLength()
        {
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//table[@class='korpus']/tbody[1]/tr[5]/td[2]/b[1]")));
            return Convert.ToInt32(element.Text.ToString());
        }
        public void Close()
        {
            driver.Close();
        }
    }
}
