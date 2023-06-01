using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SpecFlowProject1.Drivers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SpecFlowProject1.Pages
{
    
    public class ContactPage : BasePage
    {
        protected IWebDriver _driver = ChromeDriverWrap.Driver;

        private IWebElement ButtonSubmit => _driver.FindElement(By.XPath(".//button[text()='Submit']"));
        private IWebElement AcceptAll => _driver.FindElement(By.XPath(".//button[text()='Accept All']"));
        public ReadOnlyCollection<IWebElement> listOfElementWithRequired => _driver.FindElements(By.XPath(".//*[@class='text-field-ui validation-field']"));

        public void ClickOnButtonSubmit()
        {

            Actions actions = new Actions(_driver);
            actions.MoveToElement(ButtonSubmit);
            actions.Perform();
            clickAcceptIfDisplayed();
            ButtonSubmit.Submit();
        }

        public void ClickOnButtonAcceptAll()
        {
            AcceptAll.Submit();
        }

        internal void VerifyNumberOfReauiredFields(int numberOfReauiredFields)
        {
            Assert.AreEqual(numberOfReauiredFields, listOfElementWithRequired.Count());
        }

        public void clickAcceptIfDisplayed()
        {
            try
            {
                var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(7));
                wait.Until(ExpectedConditions.ElementToBeClickable(AcceptAll));
                AcceptAll.Click();
            }catch (Exception ex)
            {
                Console.WriteLine("No element AcceptAll");
            }
        }

    }
}
