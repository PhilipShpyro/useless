using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DEV_7
{
    public class Invoker
    {
        CalkulyatorPage page;

        public string GetResult(string sequence)
        {
            string[] names = sequence.Split();

            foreach (string name in names)
            {
                page[name].Click();
            }
            return page.GetAnswer();
        }
        public void ChangeAgterDotLength(int n)
        {
            page.ChangeAfterDotLength(n);
        }
        public int GetAfterDotLength()
        {
            return page.GetAfterDotLength();
        }
        public void ClosePage()
        {
            page.Close();
        }
        public Invoker()
        {
            page = new CalkulyatorPage();
            page.GoOn();
        }
    }
}
