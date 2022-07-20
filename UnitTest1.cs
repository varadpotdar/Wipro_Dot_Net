using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace SeleniumWebdriver
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           // IWebDriver driver = new ChromeDriver();
            IWebDriver driver = new InternetExplorerDriver();
            driver.Navigate().GoToUrl("http://localhost:62098/Login.aspx");
            driver.Close();
            driver.Quit();
        }
    }
}
