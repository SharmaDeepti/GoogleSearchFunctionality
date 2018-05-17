using System;
using TechTalk.SpecFlow;

namespace GoogleSearchProject
{
    [Binding]
    public class SearchTextSteps
    {
        [Given(@": I start the Firefox web browser")]
        public void GivenIStartTheFirefoxWebBrowser()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I open the google homepage")]
        public void WhenIOpenTheGoogleHomepage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
