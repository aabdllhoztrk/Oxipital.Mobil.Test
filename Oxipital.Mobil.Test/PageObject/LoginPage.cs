using Demo.SivitCare.Selenium.PageObject;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oxipital.Mobil.Test.PageObject
{
    public class LoginPage : BasePage
    {
        public LoginPage(AppiumDriver<AndroidElement> appiumDriver) : base(appiumDriver)
        {
        }

        public AppiumWebElement btn_Giris => FindElementById("Giriş");

        public HomePage LoginOlma() 
        {
            btn_Giris.Click();
            return new HomePage(Driver);
        }
    }
}
