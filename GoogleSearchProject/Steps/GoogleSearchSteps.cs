using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace GoogleSearchProject.Steps
{
    [Binding]
    public class GoogleSearchSteps :Program
    {
        Program objPgm = new Program();
        [Given(@"I open browser")]
        public void GivenIOpenBrowser()
        {
            InitializeDriver();
        }
        [When(@"I enter ""(.*)"" to search")]
        public void WhenIEnterToSearch(string p0)
        {
            SearchText(p0);
        }
        [Given(@"I go to Google homepage")]
        public void GivenIGoToGoogleHomepage()
        {
            OpenUrl("http://google.com");
        }

        
        [When(@"I hit the Enter button")]
        public void WhenIHitTheEnterButton()
        {
            //element.SearchKeyword(keyword);
            SearchButtonClick();
        }
        [When(@"I enter Aivva(.*) to search")]
        public void WhenIEnterAivvaToSearch(string p0)
        {
            SearchText(p0);
        }

        

        [Then(@"I should see links in first search page")]
        public void ThenIShouldSeeLinksInFirstSearchPage()
        {
            int count = GetLinksCount();
            int numberOfLinks = 6;
            Assert.AreEqual(numberOfLinks, count);
        }

        [When(@"I enter Aviva(.*) to search")]
        public void WhenIEnterAvivaToSearch(string p0)
        {
            Console.WriteLine(p0);
            SearchText(p0);
        }


        [Then(@"I print the link text of the (.*)th link")]
        public void ThenIPrintTheLinkTextOfTheThLink(int position)
        {
            position = 5;
            String linkText = GetLinkText(position);
            Console.WriteLine("The {0}th link text is : " + linkText, position);
        }
        
        [Then(@"I should not see previous links in first search page")]
        public void ThenIShouldNotSeePreviousLinksInFirstSearchPage()
        {
            int count = GetLinksCount();
            int numberOfLinks = 5;
            Console.WriteLine("Number of search links are : " + count);
            Assert.AreNotEqual(numberOfLinks, count);
        }
    }
}
