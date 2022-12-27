using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace SeleniumConcept
{
    public class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://github.com/login";

            //By usernameLocator = By.Id("login_field");
            //IWebElement element = driver.FindElement(usernameLocator);
            //element.SendKeys("hello@gmail.com");


            driver.FindElement(By.Id("login_field")).SendKeys("jacl@gmail.com");
            driver.FindElement(By.Id("password")).SendKeys("hello");

            driver.FindElement(By.Name("commit")).Click();
        }
    }
}