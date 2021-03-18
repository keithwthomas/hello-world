using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace hello_project
{
    public class Tests
    {
        String test_url = "https://www.google.com";

        IWebDriver driver = new ChromeDriver(@"C:\Program Files (x86)\Google\Chrome\Application");

        [SetUp]
        public void start_Browser()
        {
            // Local Selenium WebDriver
           // driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void test_search()
        {
            driver.Url = test_url;

            System.Threading.Thread.Sleep(2000);

            IWebElement searchText = driver.FindElement(By.CssSelector("[name = 'q']"));

            searchText.SendKeys("LambdaTest");

            IWebElement searchButton = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[2]/div[1]/div[3]/center/input[1]"));

            searchButton.Click();

            System.Threading.Thread.Sleep(6000);

            Console.WriteLine("Test Passed");
        }

        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }
    }
}