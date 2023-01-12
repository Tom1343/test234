using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;
using System.Diagnostics;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace CGI_OUTBOUND_Android_Scenarios.Utilities
{
    [Binding]
    public class WaitMethods
    {
        public IWebDriver Driver;
        public static int DefaultTimeOut = Convert.ToInt32(ConfigurationManager.AppSettings.Get("DefaultTimeOut"));
        public WaitMethods(IWebDriver driver) => Driver = driver;

        public WaitMethods WaitForPageToBeReady(By xpathBy)
        {
            bool hasElementDisappeared = false;
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(100);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (!hasElementDisappeared && stopwatch.Elapsed.TotalSeconds < 20)
            {
                try
                {
                    Driver.FindElement(xpathBy);
                    hasElementDisappeared = false;
                }
                catch (Exception)
                {
                    hasElementDisappeared = true;
                }
            }

            return this;
        }

        public WaitMethods WaitForElementToBePresent(By elementBy)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(40));
            IWebElement myDynamicElement = wait.Until(d => d.FindElement(elementBy));

            return this;
        }

        public WaitMethods WaitUntilElementIDIsDisplayed(string element)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            int overrideWaitTime;
            int waitTime = 0;
            bool hasElementAppeared = false;
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
            overrideWaitTime = waitTime.Equals(0) ? 25 : waitTime;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (!hasElementAppeared && stopwatch.Elapsed.TotalSeconds < overrideWaitTime)
            {
                try
                {
                    wait.Until(c => c.FindElement(By.Id(element)).Displayed);
                    hasElementAppeared = true;
                }
                catch (Exception)
                {
                    hasElementAppeared = false;
                }
            }

            return this;
        }

        public WaitMethods WaitForElementToDisappear(string element)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            bool hasElementAppeared = false;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (!hasElementAppeared && stopwatch.Elapsed.TotalSeconds < 45)
            {
                try
                {
                    Assert.True(wait.Until(c => c.FindElements(By.XPath(element)).Count == 0));
                    hasElementAppeared = true;
                }
                catch (Exception)
                {
                    hasElementAppeared = false;
                }
            }

            return this;
        }
        public WaitMethods WaitForElementToBeGone(By elementBy, int waitTime=0)
        {
            int overrideWaitTime;
            bool hasElementDisappeared = false;
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(100);
            overrideWaitTime = waitTime.Equals(0) ? DefaultTimeOut : waitTime;
            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            
            while(!hasElementDisappeared&&stopwatch.Elapsed.TotalSeconds < overrideWaitTime)
            {
                try
                {
                    Driver.FindElement(elementBy);
                    hasElementDisappeared = false;
                }
                catch(Exception)
                {
                    hasElementDisappeared = true;
                }
            }


            return this;
        }


        public WaitMethods AssertAbsenceOfElement(string element, int number = 0)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            Assert.True(wait.Until(c => c.FindElements(By.XPath(element)).Count == number));

            return this;
        }

        public WaitMethods WaitElementToBeDisplayed(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));

            wait.Until(c =>
            {
                try
                {
                    IWebElement element = c.FindElement(locator);

                    return element.Displayed;
                }
                catch (Exception e)
                {
                    if (e is NoSuchElementException)
                        return false;
                    throw;
                }
            });

            return this;
        }
    }
}
