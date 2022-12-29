using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maveric.SeleniumAdvance
{
    public class MultipleTabsTest
    {
        [Test]
        public void Demo1PhpMyAdminTabTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);

            driver.Url = "https://www.db4free.net/";

            //click on phpMyAdmin
            driver.FindElement(By.PartialLinkText("phpMyAdmin")).Click();

            ReadOnlyCollection<string> windows= driver.WindowHandles;

            Console.WriteLine(windows[0]);
            Console.WriteLine(windows[1]);
            Console.WriteLine(driver.WindowHandles[1]);
        }


        [Test]
        public void Demo2PhpMyAdminTabTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.db4free.net/";

            //click on phpMyAdmin
            driver.FindElement(By.PartialLinkText("phpMyAdmin")).Click();

            
            //switch to second tab
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.Id("input_username")).SendKeys("john");
            //enter password as admin
            //click on login

            driver.Close(); //check what is happening 

            driver.SwitchTo().Window(driver.WindowHandles[0]);

            Console.WriteLine(driver.Title);

            driver.Quit();
        }
    }
}
