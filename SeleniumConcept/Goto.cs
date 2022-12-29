using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using System.Xml.Linq;
using OpenQA.Selenium.Support.UI;

namespace SeleniumConcept
{
    internal class Goto
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://www.goto.com/meeting#"; //wait for the page load to complete
            
            driver.FindElement(By.Id("truste-consent-button")).Click();


            Actions actions = new Actions(driver);
            try
            {
                actions.ScrollToElement(driver.FindElement(By.LinkText("Try Free"))).Perform();
            }
            catch 
            {

            }

            driver.FindElement(By.LinkText("Try Free")).Click(); //new ElementClickInterceptedException()

            driver.FindElement(By.Id("first-name")).SendKeys("jack");
            driver.FindElement(By.Id("last-name")).SendKeys("g");
            driver.FindElement(By.Id("login__email")).SendKeys("jack@gmail.com");

            SelectElement selectSize = new SelectElement(driver.FindElement(By.Id("CompanySize")));
            selectSize.SelectByText("10 - 99");


            try
            {
                actions.ScrollToElement(driver.FindElement(By.LinkText("Terms of Service"))).Perform();
            }
            catch
            {

            }


            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[text()='Start My Trial']")).Click();

            string actualError= driver.FindElement(By.XPath("//div[@class='inputField__requirements']")).Text;
            Console.WriteLine(actualError);

           
        }
    }
}
