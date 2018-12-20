using Bogus;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RegisterTest_Automationpractice.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterTest_Automationpractice.Pages
{
    class ReigsterPage
    {
        [FindsBy]
        private IWebElement radio = null, customer_firstname = null, 
                customer_lastname=null, passwd =null, days = null, month = null, years = null,
                address1 = null, city = null, id_state = null, postcode = null, id_country = null,
                phone_mobile = null;
        [FindsBy(How = How.Id, Using = "submitAccount")]
        private IWebElement createAccountBtn = null;
        private IWebDriver driver;
        public ReigsterPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public string RadioButton { get { return radio.GetText();} private set { radio.SetText(value);} }

        //private int getRandomInteger(int min, int max)
        //{
        //    return nextInt(min, max + 1);
        //}

        //public Faker<ReigsterPage> Generator()
        //{
        //    var registerPage = new Faker<ReigsterPage>()
        //        .CustomInstantiator(f => new ReigsterPage(driver))
        //        .RuleSet("HappyPath",
        //         (set) =>
        //         {
        //             set.StrictMode(true);
        //             set.RuleFor(a => a.RadioButton, f => f.PickRandom);
        //         });
        //    return registerPage;
        //}

    }
}
