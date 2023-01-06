using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.Extensions;
using NUnit.Framework;

namespace SeleniumAdvance
{
    public class SeleniumAdvanceConcepts
    {
        [Test]
        public void Demo1JSConcept()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.citibank.co.in/ssjsps/forgetuseridmidssi.jsp";

            driver.FindElement(By.LinkText("select your product type")).Click();
            driver.FindElement(By.LinkText("Credit Card")).Click();

            driver.ExecuteJavaScript("document.querySelector(\"#bill-date-long\").value='15/01/2022'");
        }

        [Test]
        public void Demo2JSConcept()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.citibank.co.in/ssjsps/forgetuseridmidssi.jsp";

            driver.FindElement(By.LinkText("select your product type")).Click();
            driver.FindElement(By.LinkText("Credit Card")).Click();


            IWebElement ele = driver.FindElement(By.XPath("//input[@id='bill-date-long']"));
            driver.ExecuteJavaScript("arguments[0].value='15/01/2022'", ele);
        }

        [Test]
        public void Demo3JSConcept()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://nasscom.in/about-us/contact-us";

            IWebElement ele = driver.FindElement(By.XPath("//a[text()='Members Listing']"));

            driver.ExecuteJavaScript("arguments[0].click();", ele);
        }


        [Test]
        public void Demo4Irctc()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications");


            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.irctc.co.in/nget/train-search";

        }

        [Test]
        public void Demo5Irctc()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications");
            options.AddArguments("--headless");


            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.irctc.co.in/nget/train-search";

            Console.WriteLine(driver.Title);
            driver.Quit();
        }

        [Test]
        public void Demo6Irctc()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications");
            options.AddUserProfilePreference("download.default_directory", "C:\\mine");

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.selenium.dev/downloads/";

            driver.FindElement(By.PartialLinkText("32")).Click();

            Screenshot s1= driver.TakeScreenshot();
            s1.SaveAsFile("error.png");

            string fileName = "sc_" + DateTime.Now.ToString().Replace(":", "-").Replace("/", "-") + ".png";
            s1.SaveAsFile(fileName);

        }

        [Test]
        public void Demo7CSharpConcept()
        {

            List<string> list = new List<string>();
            list.Add("red");
            list.Add("green");
            list.Add("white");

            list.Remove("green");

            Console.WriteLine(list[1]);

        }

        [Test]
        public void Demo8CSharpConcept()
        {

            List<int> list = new List<int>();
            list.Add(898989989);
            list.Add(89898993);
            list.Add(89898893);

            list.RemoveAt(1);

            Console.WriteLine(list[1]);

        }

        [Test]
        public void Demo9CSharpConcept()
        {

            Dictionary<int,string> employees=new Dictionary<int,string>();

            employees.Add(101, "john");
            employees.Add(102, "peter");


            Console.WriteLine(employees[102]);

        }

        [Test]
        public void Demo10CSharpConcept()
        {

            Dictionary<string, string> employees = new Dictionary<string, string>();

            employees.Add("n1", "john");
            employees.Add("n2", "peter");


            Console.WriteLine(employees["n2"]);

            string fileName = "sc_" + DateTime.Now.ToString().Replace(":", "-").Replace("/", "-")+".png";
            Console.WriteLine(fileName);
        }
    }

}
