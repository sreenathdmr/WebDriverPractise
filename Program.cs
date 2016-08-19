using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Drawing;

namespace ToolsQA.Selenium_Basics
{
    class NUnitTest
    {
        public static Size Dimension { get; private set; }

        static void Main(string[] args)
        {

            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.gmail.com");
            IWebElement element = driver.FindElement(By.Id("Email"));

            element.SendKeys("sreenathdmr");

        }
    }
}

 