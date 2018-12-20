using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RegisterTest_Automationpractice.Helpers;
using RegisterTest_Automationpractice.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace RegisterTest_Automationpractice.FeaturesSteps
{
    [Binding]
    public class RegisterSteps
    {
        IWebDriver driver;
        WaitToLoadPage wait;
        string baseUrl;

        public RegisterSteps()
        {
            driver = new ChromeDriver();
            wait = new WaitToLoadPage();
            baseUrl = "http://automationpractice.com/index.php?controller=authentication&back=my-account";
        }

        [Given(@"I am on the SignIn webSite")]
        public void GivenIAmOnTheSignInWebsite()
        {
            driver.Navigate().GoToUrl(baseUrl + "/");
            driver.Manage().Window.Maximize();
        }

        [When(@"I complete all the fields")]
        public void WhenICompleteAllTheFields()
        {
            driver.FindElement(By.Id("email_create")).Click();
            var registerFormPage = new Register_SigInPage(driver);
            registerFormPage.Generator()
                .StrictMode(false)
                .Generate("HappyPath, Default");

            driver.FindElement(By.Id("SubmitCreate")).Click();
        }
        //ClassName page-heading -> 'Create an account'

        [Then(@"I can see the account name on the top")]
        public void ThenICanSeeTheAccountNameOnTheTop()
        {
            wait.WaitingPage(driver, By.ClassName("page-heading"));
            Assert.AreEqual("AUTHENTICATION", driver.FindElement(By.ClassName("page-heading")).Text);
        }
    }
}
