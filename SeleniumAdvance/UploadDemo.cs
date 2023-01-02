using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvance
{
    public class UploadDemo
    {

        [Test]
        public void PdfToWordConvertTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.ilovepdf.com/pdf_to_word";

            driver.FindElement(By.XPath("//input[@type='file']")).SendKeys(@"C:\Mine\Balaji-Profile_2022.pdf");
        }

        [Test]
        public void PdfToWordConvert2Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.sodapdf.com/pdf-to-word/";

            driver.FindElement(By.XPath("//input[@type='file']")).SendKeys(@"C:\Mine\Balaji-Profile_2022.pdf");
        }
    }
}
