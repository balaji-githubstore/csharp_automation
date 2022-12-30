using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Extensions;

namespace Maveric.SeleniumAdvance
{
    public class MultipleTabsCitiTest
    {
        [Test]
        public void ApplyCreditTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.online.citibank.co.in/";

            driver.FindElement(By.XPath("//a[@title='Close']")).Click();

            driver.FindElement(By.XPath("//span[normalize-space()='Login']")).Click();

            //switch to 2nd tab
            driver.SwitchTo().Window(driver.WindowHandles[1]);


            driver.FindElement(By.XPath("//div[contains(text(),'Forgot User')]")).Click();

            driver.FindElement(By.LinkText("select your product type")).Click();

            driver.FindElement(By.LinkText("Credit Card")).Click();

            driver.FindElement(By.Id("citiCard1")).SendKeys("2344");

            driver.FindElement(By.CssSelector("#citiCard2")).SendKeys("9898");

            driver.FindElement(By.CssSelector("input[name='citiCard3']")).SendKeys("7872");

            driver.FindElement(By.CssSelector("[name='citiCard4']")).SendKeys("7873");

            driver.FindElement(By.Id("cvvnumber")).SendKeys("787");

            //date field - approach 1 //not working in this page 
            //driver.FindElement(By.Id("bill-date-long")).SendKeys("14/04/2022");


            //date field - approac 2
            //click and try to automate calendar

            //driver.FindElement(By.Id("bill-date-long")).Click();
            //SelectElement selectMonth = new SelectElement(driver.FindElement(By.CssSelector("select[data-handler='selectMonth']")));
            //selectMonth.SelectByText("Apr");
            //SelectElement selectYear = new SelectElement(driver.FindElement(By.CssSelector("select[data-handler='selectYear']")));
            //selectYear.SelectByText("2000");
            //driver.FindElement(By.LinkText("14")).Click();


            //date field - approac 2 - use javascript to enter
            driver.ExecuteJavaScript("document.querySelector('#bill-date-long').value='14/04/2000'");
            driver.FindElement(By.CssSelector("[value='PROCEED']")).Click();

            string actualError=driver.FindElement(By.XPath("//li[contains(text(),'accept Terms')]")).Text;
            Console.WriteLine(actualError);

            driver.Quit();
        }
    }
}
