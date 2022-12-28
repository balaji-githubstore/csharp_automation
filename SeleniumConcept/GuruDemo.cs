using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumConcept
{
    internal class GuruDemo
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://demo.guru99.com/test/newtours/register.php";

            driver.FindElement(By.Name("firstName")).SendKeys("jack");


            SelectElement selectCountry = new SelectElement(driver.FindElement(By.Name("country")));
            selectCountry.SelectByText("INDIA");

            driver.FindElement(By.Name("submit")).Click();
        }
    }
}
