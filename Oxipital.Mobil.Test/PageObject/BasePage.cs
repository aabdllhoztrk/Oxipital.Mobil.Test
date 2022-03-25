using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.SivitCare.Selenium.PageObject
{
    public abstract class BasePage
    {
        // private IWebDriver _driver;
        private AppiumDriver<AndroidElement> _driver;      
        protected AppiumDriver<AndroidElement> Driver => _driver;

        public BasePage(AppiumDriver<AndroidElement> driver)
        {
            this._driver =driver;
        }

        

        public AndroidElement FindElementByXPath(string element)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                return (AndroidElement)wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(element)));                
            }
            catch (OpenQA.Selenium.NoSuchElementException e)
            {
                Console.WriteLine(element + " sayfa kaynagında bulunamadi.");
                throw e;
            }
            catch (OpenQA.Selenium.WebDriverTimeoutException ex)
            {
                Console.WriteLine(element + " belirtilen sürede bulunamadı.");
                throw ex;
            }
            catch (Exception ea)
            {
                Console.WriteLine("Bilinmeyen Hata olustu" + ea);
                throw ea;
            }

        }

        public AndroidElement FindElementById(string element)
        {
            try
            {
               // var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
                var myElement = Driver.FindElementByAccessibilityId(element);
                
               // new WebDriverWait(Driver, TimeSpan.FromMinutes(1)).Until(d => myElement.Displayed);
                return myElement;
            }
            catch (OpenQA.Selenium.NoSuchElementException e)
            {
                Console.WriteLine(element + " sayfa kaynagında bulunamadi.");
                throw e;
            }
            catch (OpenQA.Selenium.WebDriverTimeoutException ex)
            {
                Console.WriteLine(element + " belirtilen sürede bulunamadı.");
                throw ex;
            }
            catch (Exception ea)
            {
                Console.WriteLine("Bilinmeyen Hata olustu" + ea);
                throw ea;
            }

        }
        public AndroidElement FindElementByName(string element)
        {
            var myElement = Driver.FindElementByAccessibilityId(element);
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            new WebDriverWait(Driver, TimeSpan.FromSeconds(30)).Until(d => myElement.Displayed);
            return myElement;
        }

        public AndroidElement FindElementCssSelector(string element)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            return (AndroidElement)wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(element)));
        }
        public AndroidElement FindElementByLinkText(string element)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            return (AndroidElement)wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(element)));
        }

        public void goToUrl(string url)
        {
            Driver.Url = url;
        }

        public void switchtoFrame(string frameName)

        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.FrameToBeAvailableAndSwitchToIt(frameName));
        }

        public void sendKeys(AndroidElement element, string value)
        {
            element.Clear();
            element.SendKeys(value);
        }

        public void ValidateElementExist(IWebElement actualLabel, string expectedLabel)
        {
            string expected = expectedLabel;

            try

            {
                Thread.Sleep(100);
                Assert.IsTrue(actualLabel.Text.Equals(expected));
                //Assert.IsTrue(actualLabel.Displayed);
            }
            catch (Exception e)
            {

                Console.WriteLine("Beklenen label sayfa kaynagında bulunamadi !!!" + "  Label: " + expected);

            }
        }
        public void ValidateElementNotExist(string elementName, string elementxpath)
        {
            Thread.Sleep(1000);
            int count = Driver.FindElements(By.XPath(elementxpath)).Count();
            if (count > 0)
            {
                Assert.Fail(elementName + " Silinmedi.");
            }
        }

        public void ValidateScoreResults(IWebElement actualLabel, string expectedLabel)
        {
            string expected = expectedLabel;

            try
            {
                Assert.IsTrue(actualLabel.Text.Contains(expected));

            }
            catch (Exception e)
            {
                Console.WriteLine("Beklenen skor sayfa kaynagında doğru görüntülenemedi !!!" + " Beklenen Skor: " + expected);

            }
        }

        public void ScrollDown()
        {
            IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,950);");
        }
        public void ScrollDownforVitalPage()
        {
            IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,250);");
        }

        public IWebElement btn_Sil => FindElementByXPath("(//MAT-ICON[@role='img'][text()='delete'])[1]");
        public IWebElement DefaultYes => FindElementByXPath("//span[contains(text(),'Yes')]");
        public void Sil()
        {
            Thread.Sleep(500);
            btn_Sil.Click();
            DefaultYes.Click();
        }



        /*
        public static void SelectByText(IWebElement element, string text)
        {
            SelectElement selectElement = new SelectElement(element);
            selectElement.SelectByValue(text);
        }
        */

    }
}
