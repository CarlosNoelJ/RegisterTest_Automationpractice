using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterTest_Automationpractice.Helpers
{
    public class WaitToLoadPage
    {
        public  IWebElement WaitingPage(IWebDriver driver, By elementLoader, int timeout=10)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));

            return wait.Until(ExpectedConditions.ElementExists(elementLoader));
        }
    }
}
