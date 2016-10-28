using OpenQA.Selenium.Remote;
using System;
using Xunit;

namespace WebSite.Mvc.FunctionalTest
{
    public class SeleniumTest
    {
        private string baseURL = "http://191.235.87.105/SiteTestC/";
        private RemoteWebDriver driver;
        private string browser;

        //public TestContext Contexto { get; set; }

        //[TestMethod]
        //[TestCategory("Selenium")]
        //[Priority(19)]
        //[Owner("FireFox")] //Using Owner as Category trait is not supported by the DTA Task
        [Fact]
        public void ClickEnContacto()
        {
            DesiredCapabilities capability = DesiredCapabilities.Firefox();
            Uri server = new Uri("http://13.88.14.110:4444/wd/hub");
            this.driver = new RemoteWebDriver(server, capability);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(this.baseURL);
            //driver.FindElementById("search - box").Clear();
            driver.FindElementById("link-contact").Click();
            //do other Selenium things here!
        }

        [Fact]
        public void ClickEnAcerca()
        {
            DesiredCapabilities capability = DesiredCapabilities.Firefox();
            Uri server = new Uri("http://13.88.14.110:4444/wd/hub");
            this.driver = new RemoteWebDriver(server, capability);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(this.baseURL);
            //driver.FindElementById("search - box").Clear();
            driver.FindElementById("link-acerca").Click();
            //do other Selenium things here!
        }

        [Fact]
        public void ClickEnInicio()
        {
            DesiredCapabilities capability = DesiredCapabilities.Firefox();
            Uri server = new Uri("http://13.88.14.110:4444/wd/hub");
            this.driver = new RemoteWebDriver(server, capability);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(this.baseURL);
            //driver.FindElementById("search - box").Clear();
            driver.FindElementById("link-inicio").Click();
            //do other Selenium things here!
        }
    }
}
