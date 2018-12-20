using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RegisterTest_Automationpractice.Helpers;
using TechTalk.SpecFlow;

namespace RegisterTest_Automationpractice.FeaturesSteps
{
    [Binding]
    public class SignInSteps
    {
        IWebDriver driver;
        WaitToLoadPage wait;

        public SignInSteps()
        {
            driver = new ChromeDriver();
            wait = new WaitToLoadPage();
        }

        [Given(@"I am on the Sign in site")]
        public void GetIAmOnTheSignInSite()
        {
            string baseUrl = "http://automationpractice.com/index.php?controller=authentication&back=my-account";
            driver.Navigate().GoToUrl(baseUrl + "/");
            driver.Manage().Window.Maximize();
        }

        [When(@"I complete the fields")]
        public void WhenICompleteTheFields()
        {
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("pruebaTest@yopmail.com");
            driver.FindElement(By.Id("passwd")).Click();
            driver.FindElement(By.Id("passwd")).SendKeys("qwerty");
            driver.FindElement(By.Id("SubmitLogin")).Click();
            wait.WaitingPage(driver, By.ClassName("account"));
        }

        [Then(@"I can see the account section on the top")]
        public void ThenICanSeeTheAccountSectionOnTheTop()
        {
            //wait.WaitingPage(driver, By.ClassName("account"));
            Assert.AreEqual("Pedro Ojeda",driver.FindElement(By.ClassName("account")).Text);
            //driver.Quit();
        }
    }
}
