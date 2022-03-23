using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using SpecFlowWeb.Specs.Drivers;
using NUnit.Framework;
using System.Configuration;


namespace SpecFlowWeb.Specs.StepDefinitions
{
    [Binding]
    public class WebBrowserStepDefinitions
    {

        IWebDriver driver;
        private readonly ScenarioContext _scenariocontext;
        private string keystring = "dog";
        //Console.WriteLine(ConfigurationManager.AppSettings["app"]);
        //public event System.Windows.Forms.KeyPressEventHandler KeyPress;

        public WebBrowserStepDefinitions(ScenarioContext scenariocontext)
        {
            _scenariocontext = scenariocontext;
        }

        [Given(@"Open Google Chrome Page")]
        public void GivenOpenGoogleChromePage()
        {

            driver = _scenariocontext.Get<SeleniumDriver>("SeleniumDriver").Setup();

            driver.Url = "https://www.google.com/";
        }

        [Given(@"the search bar is selected")]
        public void GivenTheSearchBarIsSelected()
        {
            //not sure here
        }

        [Given(@"the keyword is entered")]
        public void GivenTheKeywordIsEntered()
        {
            _scenariocontext["keyword"] = keystring;
            //search bar is clicked

        }

        [Given(@"enter is pressed")]
        public void GivenEnterIsPressed(object sender, EventArgs e)
        {
           //not allowing system.windows.forms using to allow automated key strokes

        }


        [When(@"(.*) is found on the page")]
        public void WhenKeywordIsFoundOnThePage(int tally)
        {
            
        }

        [Then(@"check if key word was found (.*) times")]
        public void ThenCheckIfKeyWordWasFoundTimes(int found)
        {

            var result = (bool)_scenariocontext["Result"];
            Assert.IsTrue(result);
        }

    }
}
