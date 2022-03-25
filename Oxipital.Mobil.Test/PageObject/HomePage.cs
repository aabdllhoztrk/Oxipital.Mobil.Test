using Demo.SivitCare.Selenium.PageObject;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oxipital.Mobil.Test.PageObject
{
    public class HomePage : BasePage
    {
        public HomePage(AppiumDriver<AndroidElement> driver) : base(driver)
        {
        }

        public AndroidElement btn_HastaListesi => FindElementById("Hasta Listesi");
        public AndroidElement btn_Cikis => FindElementById("Çıkış");
        public AndroidElement btn_CikisEvet => FindElementById("Evet");

        public void CikisYap() 
        {
            btn_Cikis.Click();
            btn_CikisEvet.Click();
        }

        public HastaListesiPage HastaListesiSayfasinaGit() 
        {
            btn_HastaListesi.Click();
            return new HastaListesiPage(Driver);
        }
    }
}
