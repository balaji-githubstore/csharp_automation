using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maveric.SeleniumAdvance
{
    //need to complete
    public class OpenEMRDemo
    {

        [Test]
        public static void Demo()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = " http://demo.openemr.io/b/openemr/";

            driver.FindElement(By.Id("authUser")).SendKeys("admin");
            driver.FindElement(By.Id("clearPass")).SendKeys("pass");
            SelectElement select = new SelectElement(driver.FindElement(By.XPath("//select[@class='form-control']")));
            select.SelectByText("English (Indian)");
            driver.FindElement(By.Id("login-button")).Click();

            driver.FindElement(By.XPath("//div[text()='Patient']")).Click();
            driver.FindElement(By.XPath("//div[text()='New/Search']")).Click();

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@name='pat']")));
            driver.FindElement(By.Id("form_fname")).SendKeys("jack");
            driver.FindElement(By.Id("form_lname")).SendKeys("scic");
            driver.FindElement(By.Id("form_DOB")).SendKeys("2023-01-02");
            SelectElement select1 = new SelectElement(driver.FindElement(By.Id("form_sex")));
            select1.SelectByText("Male");
            SelectElement select2 = new SelectElement(driver.FindElement(By.Id("form_gender_identity")));
            select2.SelectByText("Identifies as Male");
            driver.FindElement(By.Id("create")).Click();
            driver.SwitchTo().DefaultContent();

            Thread.Sleep(5000);

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@id='modalframe']")));
            driver.FindElement(By.XPath("//input[@value='Confirm Create New Patient']")).Click();
            driver.SwitchTo().DefaultContent();

            Thread.Sleep(30000);
            string alerttext = driver.SwitchTo().Alert().Text;
            Console.WriteLine(alerttext);
            driver.SwitchTo().Alert().Accept();
    
            // driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@name='pat']")));
            driver.FindElement(By.XPath("//div[@data-dismiss='modal']")).Click();

            string patientname = driver.FindElement(By.XPath("//span[@data-bind='text: pname()']")).Text;
            Console.WriteLine(patientname);


        }
    }
}
