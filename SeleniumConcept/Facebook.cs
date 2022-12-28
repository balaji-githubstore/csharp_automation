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

            driver.FindElement(By.LinkText("Create New Account")).Click();

            driver.FindElement(By.Name("firstname")).SendKeys("jack");

            //radio button 
            //driver.FindElement(By.XPath("//input[@value='-1']")).Click();
            
            driver.FindElement(By.XPath("//label[text()='Custom']")).Click();
        }
    }
}
