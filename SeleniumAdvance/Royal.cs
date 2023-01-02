using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Support.Extensions;

namespace Maveric.SeleniumAdvance
{
    //need to complete
    public class Royal
    {

        [Test]
        public void SignUpTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.royalcaribbean.com/";

            driver.FindElement(By.XPath("//div[@class='notification-banner__close']")).Click();

            driver.FindElement(By.XPath("//span[text()='Sign In']")).Click();

            Thread.Sleep(5000);

            //driver.FindElement(By.PartialLinkText("Create an account")).Click();
            driver.ExecuteJavaScript("document.querySelector(\"a[class~='login__create-account']\").click()");

            driver.FindElement(By.XPath("//input[@data-placeholder='First name/Given name']")).SendKeys("john");

            driver.FindElement(By.XPath("//input[@data-placeholder='Last name/Surname']")).SendKeys("wick");


            driver.FindElement(By.XPath("//span[text()='Month']")).Click();
            driver.FindElement(By.XPath("//span[normalize-space()='April']")).Click();


            //select day as 4

            //year as 1990

            //country as india 
        }

        [Test]
        public void SignUp2Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.royalcaribbean.com/account/create";

            driver.FindElement(By.XPath("//input[@data-placeholder='First name/Given name']")).SendKeys("john");

            driver.FindElement(By.XPath("//input[@data-placeholder='Last name/Surname']")).SendKeys("wick");


            driver.FindElement(By.XPath("//span[text()='Month']")).Click();
            driver.FindElement(By.XPath("//span[normalize-space()='April']")).Click();


            //select day as 4
            driver.FindElement(By.XPath("//span[text()='Day']")).Click();
            driver.FindElement(By.XPath("//span[normalize-space()='27']")).Click();


            //year as 1990
            driver.FindElement(By.XPath("//input[@data-placeholder='Year']")).SendKeys("2000");

            //country as india 
            driver.FindElement(By.XPath("//span[text()='Country/Region of residence']")).Click();
            driver.FindElement(By.XPath("//span[normalize-space()='India']")).Click();
        }
    }
}
