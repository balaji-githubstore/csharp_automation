using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maveric.SeleniumAdvance
{
    public class FrameTest
    {
        [Test]
        public void Demo1Frame()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@name='login_page']")));

            //enter userid as kevin123
            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("kevin123");
            //click on continue
            driver.FindElement(By.LinkText("CONTINUE")).Click();


            //Switch back to main html
            driver.SwitchTo().DefaultContent();


        }

        [Test]
        public void Demo2Alert()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";

            //click on go 
            driver.FindElement(By.XPath("//img[@alt='Go']")).Click();


            //wait for alert present - 

            string alertText=driver.SwitchTo().Alert().Text;
            Console.WriteLine(alertText);

            driver.SwitchTo().Alert().Accept();
        }

    }   
}
