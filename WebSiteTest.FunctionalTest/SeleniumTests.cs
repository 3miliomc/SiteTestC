using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSiteTest.FunctionalTest
{
    [TestClass]
    public class SeleniumTests
    {
        private string baseURL = "http://191.235.87.105/SiteTestC/";
        private RemoteWebDriver driver;
        private string browser;

        public TestContext Contexto { get; set; }

        [TestMethod]
        [TestCategory("Selenium")]
        [Priority(19)]
        [Owner("FireFox")] //Using Owner as Category trait is not supported by the DTA Task
        public void RemoteSelenium()
        {
            DesiredCapabilities capability = DesiredCapabilities.Firefox();
            Uri server = new Uri("http://<YourGridserver>:80/wd/hub");
            this.driver = new RemoteWebDriver(server, capability);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(this.baseURL);
            driver.FindElementById("search - box").Clear();
            driver.FindElementById("search - box").SendKeys("tire");
            //do other Selenium things here!
        }
    }
}
