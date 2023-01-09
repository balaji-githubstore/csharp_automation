using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SeleniumAdvance
{
    public class FluentWaitConceptsDemo
    {
        [Test]
        public static void Demo()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Url = " http://demo.openemr.io/b/openemr/";


            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver); 
            //wait.PollingInterval=TimeSpan.FromSeconds(1);
            wait.Timeout=TimeSpan.FromSeconds(30);
            wait.IgnoreExceptionTypes(typeof(NoAlertPresentException),typeof(NoSuchElementException));

            //add a code to ignore all exceptions for 30sec and try to do the operation 

            wait.Until(x => x.FindElement(By.Id("authUser12367"))).SendKeys("hello");

           
        }

        [Test]
        public static void Demo2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = " http://demo.openemr.io/b/openemr/";


            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
            wait.Timeout = TimeSpan.FromSeconds(30);
            wait.IgnoreExceptionTypes(typeof(Exception));

            //add a code to ignore all exceptions for 30sec and try to do the operation 

            wait.Until(x => x.FindElement(By.Id("authUser12367"))).SendKeys("hello");

            wait.Until(x => x.FindElement(By.Id(""))).SendKeys("hel");

           string title= wait.Until(x => x.Title);

            wait.Until(x => x.FindElement(By.Id(""))).Click();

        }
    }
}