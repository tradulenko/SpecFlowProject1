using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProject1.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    public static class Hooks
    {
        private static WebDriver driver = ChromeDriverWrap.Driver;

        [BeforeFeature]
        public static void BeforeFeature()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.Manage().Window.Maximize();
        }


        [AfterFeature]
        public static void AfterFeature()
        {
            driver.Quit();
        }

    }
}
