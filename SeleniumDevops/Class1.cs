using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDevops
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void FirstTest()
        {
            var option = new ChromeOptions();
            option.AddArguments("headless");
            IWebDriver driver = new ChromeDriver(option);
            driver.Navigate().GoToUrl("https://www.youtube.com/");

        }

    }
}
