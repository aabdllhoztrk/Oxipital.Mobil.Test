using Demo.SivitCare.Selenium.PageObject;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Oxipital.Mobil.Test.PageObject
{
    public class HastaListesiPage : BasePage
    {
        public HastaListesiPage(AppiumDriver<AndroidElement> driver) : base(driver)
        {
        }

        public AndroidElement btn_Hasta => FindElementById("21 - \nLeda Howell\nUzm.Dr. SERDAR KARDUMAN\nYAKINMA VEYA BİLİNEN TEŞHİSİ OLMAYAN KİŞİLERİN GENEL MUAYENE VE İNCELEMESİ");

        public HastaSayfasiPage HastaSayfasinaGit() 
        {
            Thread.Sleep(2000);
            btn_Hasta.Click();
            return new HastaSayfasiPage(Driver);
        }

    }
}
