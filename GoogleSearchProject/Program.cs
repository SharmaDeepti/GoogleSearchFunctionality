using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;

namespace GoogleSearchProject
{
    //[TestClass]
    public class Program
    {
        //Variable declaration
        public static IWebDriver driver;
        By searchTxtBox = By.Name("q");
        By linkText = By.CssSelector("div.rc > h3 > a");

        //Initalize the driver
        public static IWebDriver InitializeDriver(String browsername = "Chrome")
        {
            if (browsername == "Chrome")
            {
                driver = new ChromeDriver();
            }
            else if (browsername == "InternetExplorer")
            {
                driver = new InternetExplorerDriver();
            }
            else if (browsername == "Firefox")
            {
                driver = new FirefoxDriver();
            }
            return driver;
        }

        public static void OpenUrl(String url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

        }
        public static IWebDriver OpenApp(String browsername, String url)
        {
            InitializeDriver(browsername);
            OpenUrl(url);
            return driver;
        }

        public void SearchButtonClick()
        {
            System.Threading.Thread.Sleep(2000);
            Actions btnclick = new Actions(driver);
            btnclick.SendKeys(Keys.Enter).Build().Perform();
        }

        public int GetLinksCount()
        {
            IList<IWebElement> linkTextElements;
            try
            {
                linkTextElements = driver.FindElements(linkText);
                Console.WriteLine("Total number of links in first search page is: " + linkTextElements.Count);
                return linkTextElements.Count;
            }
            catch(Exception ex)
            { Console.WriteLine(ex.Message);
                return 0;
            }
            

        }
        public string GetLinkText(int position)
        {
            IList<IWebElement> linkTextElelemts = driver.FindElements(linkText);
            return linkTextElelemts[position - 1].Text;
        }

        public void SearchText(string p0)
        {
            try
            {
                //Console.WriteLine("seacrhing");
                IWebElement element = driver.FindElement(By.Name("q"));
                System.Threading.Thread.Sleep(2000);
                //Perform Ops
                element.SendKeys(p0);
                Console.WriteLine("Searching text in google");
                //Find the Element and enter the keyword to search
                // driver.FindElement(searchTxtBox).SendKeys("Aviva");
            }
            catch(Exception ex)
            { Console.WriteLine(ex.Message); }
        }

        [TestMethod]
        public void TestMethod1()
        {
            //Create the reference for our browser
            IWebDriver driver = new FirefoxDriver();
            try
            {
                //Navigate to google page
                driver.Navigate().GoToUrl("http:www.google.com");

                //Find the Search text box UI Element
                IWebElement element = driver.FindElement(By.Name("q"));
                System.Threading.Thread.Sleep(2000);
                //Perform Ops
                element.SendKeys("Aviva");
                element.SendKeys(Keys.Enter);
                Console.WriteLine("Searching 'Aviva' text in google");
                ICollection<IWebElement> lstCss = driver.FindElements(By.CssSelector("div.rc>h3>a"));
                Console.WriteLine("CssSelector :  " + lstCss.Count.ToString());

                //string txt = driver.FindElement(By.XPath("(//h3/a)[5]")).Text;
                //Console.WriteLine("5th Link : " + txt);

                //ICollection<IWebElement> lstXpathLinks = driver.FindElements(By.XPath("//h3/a"));
                //Console.WriteLine("Total Links :  " + lstXpathLinks.Count.ToString());

                //foreach (IWebElement link in lstXpathLinks)
                //{
                //    Console.WriteLine(link.Text);
                //}

                ICollection<IWebElement> lstLinks = driver.FindElements(By.TagName("a"));
                //Console.WriteLine("in try");
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(0, lstLinks.Count);
                Console.WriteLine("Search Result Count:  " + lstLinks.Count.ToString());
                Console.WriteLine("Link at 5th position : " + lstLinks.ElementAt(4).GetAttribute("href"));
                //driver.FindElement(By.TagName("a")).Click();
                System.Threading.Thread.Sleep(1000);
                driver.Close();
                driver.Quit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("in catch");
                Console.WriteLine(ex.Message);
            }
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
