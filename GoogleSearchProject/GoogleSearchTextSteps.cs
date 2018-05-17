using System;
using TechTalk.SpecFlow;

namespace GoogleSearchProject
{
    [Binding]
    public class GoogleSearchTextSteps
    {
        [Given(@"I Open a google homepage ""(.*)"" in Firefox browser and")]
        public void GivenIOpenAGoogleHomepageInFirefoxBrowserAnd(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@": I start the Firefox browser")]
        public void GivenIStartTheFirefoxBrowser()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I Search for ""(.*)"" text in text box")]
        public void WhenISearchForTextInTextBox(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I am ablbe to open the google homepage")]
        public void WhenIAmAblbeToOpenTheGoogleHomepage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the search results displayed with links and Aviva related text")]
        public void ThenIShouldSeeTheSearchResultsDisplayedWithLinksAndAvivaRelatedText()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to see the google home page with title displayed correctly as ""(.*)""")]
        public void ThenIShouldBeAbleToSeeTheGoogleHomePageWithTitleDisplayedCorrectlyAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
