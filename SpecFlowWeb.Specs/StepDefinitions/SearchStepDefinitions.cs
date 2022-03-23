using System;
using TechTalk.SpecFlow;
using SpecFlowWeb.Specs.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowWeb;

namespace SpecFlowWeb.Specs.StepDefinitions
{
    [Binding]
    public class SearchStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly string keyword = "dog";
        IWebElement element;

        public SearchStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;

        }

        [Given(@"Open Google Chrome Page")]
        public void GivenOpenGoogleChromePage()
        {
            SeleniumDriver webDriver = new SeleniumDriver(_scenarioContext);
            _scenarioContext.Set(webDriver, "SeleniumDriver");
            _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            
            
        }

        [When(@"Search for a keyword")]
        public void WhenSearchingAKeyword()
        {
            // trying to get an instance of both the webdriver and the IWebElement here, but having issue doing so
            //click search bar
            IWebElementExtention.EnterText(element,keyword);//enter word
            //element = webDriver.FindElement(By.Id("")).Click();//may not work here due to the search bar not having an id, find a work around
            //element.Click();
            //hit enter or search


        }

        [Then(@"Get (.*) results of the key word")]
        public void ThenGetResultsOfTheKeyWord(int p0)
        {
            //use find element and return the # in a for loop
        }
    }

}
