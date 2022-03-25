using Demo.SivitCare.Selenium.PageObject;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using Oxipital.Mobil.Test.BaseClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oxipital.Mobil.Test.PageObject
{
    public class HastaSayfasiPage : BasePage
    {
        public HastaSayfasiPage(AppiumDriver<AndroidElement> driver) : base(driver)
        {
        }

        public AndroidElement btn_Gozlem => FindElementById("Gözlem");


        public GozlemPage GozlemSayfasinaGit() 
        {
            btn_Gozlem.Click();
            return new GozlemPage(Driver);
        }

    }
}
