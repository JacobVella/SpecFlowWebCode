using System;
using TechTalk.SpecFlow;
using SpecFlowWeb.Specs.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowWeb;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework;

namespace SpecFlowWeb.Specs.StepDefinitions
{
    [Binding]
    public class SearchStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private string keyword = "dog";
        IWebDriver driver;

        public SearchStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;

        }

        [Given(@"Open Google Chrome Page")]
        public void GivenOpenGoogleChromePage()
        {
            driver = new ChromeDriver(@"C:\Users\QBXW78\source\repos\seleniumConnectionTest\seleniumConnectionTest\Driver\");

            _scenarioContext.Set(driver, "WebDriver");

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://www.google.com/");
            Thread.Sleep(2000);


        }

        [When(@"Search for a keyword")]
        public void WhenSearchingAKeyword()
        {
            IWebElement e = driver.FindElement(By.Name("q"));
            e.SendKeys(keyword);
            e.Submit();
        }

        [Then(@"Get (.*) results of the key word")]
        public void ThenGetResultsOfTheKeyWord(int numOfResults)
        {
            numOfResults = 0;
            WebDriverWait wait = new WebDriverWait(driver, (TimeSpan.FromSeconds(20)));
            while (numOfResults < 10)
            {
               
                if(driver.PageSource.Contains(keyword))
                {
                    numOfResults++;
                }
            }

            Assert.AreEqual(10, numOfResults);
        }
    }

}
