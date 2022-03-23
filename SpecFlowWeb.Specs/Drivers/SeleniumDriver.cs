using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace SpecFlowWeb.Specs.Drivers
{
    public class SeleniumDriver
    {
        private ChromeDriver driver;
        private readonly ScenarioContext _scenariocontext;

        public SeleniumDriver(ScenarioContext scenarioContext) => _scenariocontext = scenarioContext;

        public IWebDriver Setup()
        {

            driver = new ChromeDriver(@"C:\Users\QBXW78\source\repos\seleniumConnectionTest\seleniumConnectionTest\Driver\");

            _scenariocontext.Set(driver, "WebDriver");

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.google.com/");
            return driver;
        }
    }
}
