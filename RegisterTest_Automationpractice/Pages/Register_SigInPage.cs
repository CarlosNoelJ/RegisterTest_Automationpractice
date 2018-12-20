using Bogus;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RegisterTest_Automationpractice.Helpers;

namespace RegisterTest_Automationpractice.Pages
{
    class Register_SigInPage
    {
        [FindsBy]
        private IWebElement email_create = null;
        [FindsBy(How = How.Id, Using = "email_create")]
        private IWebElement createAccountBtn = null;
        private IWebDriver driver;
        public Register_SigInPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public string RegisterEmail { get { return email_create.GetText(); } private set { email_create.SetText(value); } }
        
        public Faker<Register_SigInPage> Generator()
        {
            var registerSigInPage = new Faker<Register_SigInPage>()
                .CustomInstantiator(f => new Register_SigInPage(driver))
                .RuleSet("HappyPath",
                 (set) =>
                 {
                     set.StrictMode(true);
                     set.RuleFor(a => a.RegisterEmail, f => f.Person.Email);
                 });
            return registerSigInPage;
        }

        public void CreateAccount() { createAccountBtn.Click(); }
    }
}
