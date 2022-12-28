using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumConcept
{
    internal class SalesforceApp
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/"; //wait for the page load to complete

            driver.FindElement(By.Name("UserFirstName12345")).SendKeys("jack"); //FindElement checks for presence of element in 0.5s 
            driver.FindElement(By.Name("UserLastName")).SendKeys("wick");

            driver.FindElement(By.XPath("//input[contains(@id,'UserEma')]")).SendKeys("jack@gm.com");

            SelectElement selectTitle = new SelectElement(driver.FindElement(By.Name("UserTitle")));
            selectTitle.SelectByText("IT Manager");

            SelectElement selectEmployee = new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));
            selectEmployee.SelectByText("101 - 500 employees");

            //company name as maveric
            driver.FindElement(By.Name("CompanyName")).SendKeys("maveric");

            // Select country as “United Kingdom”
            SelectElement selectCont = new SelectElement(driver.FindElement(By.Name("CompanyCountry")));
            selectCont.SelectByText("United Kingdom");

          

            //click on terms and condition checkbox
        }
    }
}
