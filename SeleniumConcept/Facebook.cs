using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept
{
    internal class Facebook
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(30);


            driver.Url = "https://www.facebook.com/";

            driver.FindElement(By.LinkText("Create New Account123")).Click();

            driver.FindElement(By.Name("firstname")).SendKeys("jack");

            //radio button 
            //will start at 5:15 PM IST
        }
    }
}
