using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace Maveric.SeleniumAdvance
{
    public class ActionsDemo
    {

        [Test]
        public void NasscomTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://nasscom.in/about-us/contact-us";

            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(By.XPath("//a[text()='Membership']"))).Build().Perform();

            driver.FindElement(By.XPath("//a[text()='Members Listing']")).Click();
        }

        [Test]
        public void Nasscom2Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://nasscom.in/about-us/contact-us";

            Actions actions = new Actions(driver);

            actions.MoveToElement(driver.FindElement(By.XPath("//a[text()='Membership']"))).Perform();

            actions.MoveToElement(driver.FindElement(By.XPath("//a[text()='Become a Member']"))).Perform();

            driver.FindElement(By.XPath("//a[text()='Membership Benefits']")).Click();
        }

        [Test]
        public void Nasscom3Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://nasscom.in/about-us/contact-us";

            Actions actions = new Actions(driver);

            actions.MoveToElement(driver.FindElement(By.XPath("//a[text()='Membership']")))
                .MoveToElement(driver.FindElement(By.XPath("//a[text()='Become a Member']"))).Build().Perform();

            driver.FindElement(By.XPath("//a[text()='Membership Benefits']")).Click();
        }

        [Test]
        public void KeyBoardDemoTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://google.com";

            Actions actions = new Actions(driver);

            actions.KeyDown(Keys.Shift).SendKeys("hello world").KeyUp(Keys.Shift).Pause(TimeSpan.FromSeconds(1))
                .SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).Pause(TimeSpan.FromSeconds(1))
                .SendKeys(Keys.Enter).Build().Perform();
        }


    }
}
