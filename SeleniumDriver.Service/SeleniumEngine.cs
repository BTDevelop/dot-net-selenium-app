using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumDriver.Service
{
    public class SeleniumEngine
    {
        IWebDriver driver = new ChromeDriver(@"C:\\Users\\Burak Tahtacıoğlu\\source\\repos\\dot-net-selenium-app\\SeleniumDriver.Service\\bin\\Debug"); //change
        public readonly string navigateURL;

        public SeleniumEngine(string navigateURL)
        {
            this.navigateURL = navigateURL;
        }

        public void Navigate()
        {
            driver.Navigate().GoToUrl(this.navigateURL);
        }

        public string Search()
        {
            driver.FindElement(By.XPath("//*[@class='address-select-wrapper real-estate']/li[1]/a")).Click();
            string findValue = driver.FindElement(By.XPath("//*[@data-id='6']")).Text;

            driver.Close();
            return findValue;
        }
    }
}
