using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

using SpecFlowProject1.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Pages
{
    public class HomePage : BasePage
    {

        public IWebElement ButtonLanguage => _driver.FindElement(By.XPath(".//div[@class='location-selector-ui location-selector-ui-23 header__control']//*[@class='location-selector__button-language']"));
        private IWebElement ButtonContactUs => _driver.FindElement(By.XPath(".//div[@class='header__content']/a//span[@class='cta-button__text']"));

        protected IWebDriver _driver = ChromeDriverWrap.Driver;

        public void OpenPage()
        {
            _driver.Navigate().GoToUrl(baseUrl);
            Console.WriteLine("Home Page was opened");
        }

        public void ClickOnButtonLanguage()
        {
            ButtonLanguage.Click();
            Console.WriteLine("Button language was clicked");
        }

        public void ClickOnLanguage(string language) { 
            _driver.FindElement(By.XPath(".//li[not(@class='mobile-location-selector__item')]//*[contains(text(),'"+language+"')]")).Click();
            Console.WriteLine(language + "was clicked");
        }

        public void verifyTextInButtonSubscribe(string text)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(7));
            string _text = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//a[@class='top-navigation__item-link' and @href='/company']"))).Text;
            Assert.AreEqual(text, _text);

        }

        public void clickOnContactUs()
        {
            ButtonContactUs.Click();
        }

    }
}
