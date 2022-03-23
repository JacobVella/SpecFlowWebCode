using OpenQA.Selenium;
using SpecFlowWeb.Specs.Drivers;
using TechTalk.SpecFlow;

namespace SpecFlowWeb.Specs.Hooks
{
    [Binding]
    public sealed class HooksInitalization
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        private readonly ScenarioContext _scenariocontext;

        public HooksInitalization(ScenarioContext scenariocontext) => _scenariocontext = scenariocontext;

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            _scenariocontext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            SeleniumDriver driver = new SeleniumDriver(_scenariocontext);
            _scenariocontext.Set(driver, "SeleniumDriver");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("quit");
            _scenariocontext.Get<IWebDriver>("WebDriver").Quit();
        }
    }
}