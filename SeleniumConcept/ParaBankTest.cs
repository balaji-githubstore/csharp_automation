using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept
{
    internal class ParaBankTest
    {

        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://parabank.parasoft.com/parabank/register.htm";

            driver.FindElement(By.Id("customer.username")).SendKeys("hello");

            driver.FindElement(By.XPath("//input[@value='Register']")).Click();
        }
    }
}
