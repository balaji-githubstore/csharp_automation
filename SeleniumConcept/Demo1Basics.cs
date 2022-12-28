using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace SeleniumConcept
{
    public class Demo1Basics
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://github.com/login"; //set //navigate to the url

            string title = driver.Title;  //get the current title
            Console.WriteLine(title);

            Console.WriteLine(driver.Url); //get  the current url
            //get the page source and print it
            Console.WriteLine(driver.PageSource);
        }
    }
}