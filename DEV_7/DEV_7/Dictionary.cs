using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DEV_7
{
    class Dictionary
    {
        const string AC = "//div[@id='nmr_18']//table";
        const string ZERO = "//div[@id='nmr_25']//table";
        const string ONE = "//div[@id='nmr_19']//table";
        const string TWO = "//div[@id='nmr_20']//table";
        const string THREE = "//div[@id='nmr_21']//table";
        const string FOUR = "//div[@id='nmr_13']//table";
        const string FIVE = "//div[@id='nmr_14']//table";
        const string SIX = "//div[@id='nmr_15']//table";
        const string SEVEN = "//div[@id='nmr_7']//table";
        const string EIGHT = "//div[@id='nmr_8']//table";
        const string NINE = "//div[@id='nmr_9']//table";
        const string PLUS = "//div[@id='nmr_22']//table";
        const string MINUS = "//div[@id='nmr_17']//table";
        const string MULTIPLY = "//div[@id='nmr_16']//table";
        const string DIV = "//div[@id='nmr_10']//table";
        const string EQUALS = "//div[@id='nmr_23']//table";
        const string DOT = "//div[@id='nmr_27']//table";
        
        public string GetPath(string buttonName)
        {
            switch (buttonName)
            {
                case "AC":
                    return AC;
                case "1":
                    return ONE;
                case "2":
                    return TWO;
                case "3":
                    return THREE;
                case "4":
                    return FOUR;
                case "5":
                    return FIVE;
                case "6":
                    return SIX;
                case "7":
                    return SEVEN;
                case "8":
                    return EIGHT;
                case "9":
                    return NINE;
                case "0":
                    return ZERO;
                case "+":
                    return PLUS;
                case "-":
                    return MINUS;
                case "*":
                    return MULTIPLY;
                case "/":
                    return DIV;
                case "=":
                    return EQUALS;
                case ".":
                    return DOT;
                default:
                    return null;
            }
        }
    }
}
