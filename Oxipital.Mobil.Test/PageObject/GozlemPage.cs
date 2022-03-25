using Demo.SivitCare.Selenium.PageObject;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Oxipital.Mobil.Test.PageObject
{
    public class GozlemPage : BasePage
    {
        public GozlemPage(AppiumDriver<AndroidElement> driver) : base(driver)
        {

        }

        public AndroidElement btn_GozlemEkle => FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.widget.Button");
        public AppiumWebElement frame => FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.widget.EditText[1]");
        public AndroidElement txt_Ates => FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.widget.ScrollView/android.widget.EditText[1]");
        public AndroidElement txt_Nabiz => FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.widget.ScrollView/android.widget.EditText[2]");
        public AndroidElement txt_Sistolik => FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.widget.ScrollView/android.widget.EditText[3]");
        public AndroidElement txt_Diastolik => FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.widget.ScrollView/android.widget.EditText[4]");
        public AndroidElement txt_KanSekeri => FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.widget.ScrollView/android.widget.EditText[5]");
        public AndroidElement txt_Spo2 => FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.widget.ScrollView/android.widget.EditText[6]");
        public AndroidElement txt_Peep => FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.widget.ScrollView/android.widget.EditText[7]");
        public AndroidElement txt_Solunum => FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.widget.ScrollView/android.widget.EditText[8]");
        public AndroidElement btn__Kaydet => FindElementByXPath("//android.widget.ImageView[@content-desc='Kaydet']");
        public AndroidElement validate_GozlemDegerleri => FindElementByXPath("//android.view.View[contains(@content-desc, '37.0 177.0 85.0 179 / 178 179.0')]");
        

        public void GozlemIslemleriEkle() 
        {
            btn_GozlemEkle.Click();
            Thread.Sleep(5000);
            frame.Click();          
            sendKeys(txt_Ates, "37");
            txt_Nabiz.Click();
            sendKeys(txt_Nabiz, "177");
            txt_Sistolik.Click();
            sendKeys(txt_Sistolik, "178");
            txt_Diastolik.Click();
            sendKeys(txt_Diastolik, "179");
            txt_KanSekeri.Click();
            sendKeys(txt_KanSekeri, "179");
            txt_Spo2.Click();
            sendKeys(txt_Spo2, "55");
            txt_Peep.Click();
            sendKeys(txt_Peep, "170");
            txt_Solunum.Click();
            sendKeys(txt_Solunum, "85");
            Driver.HideKeyboard();
            btn__Kaydet.Click();
            ValidateElementExist(validate_GozlemDegerleri, "37.0 177.0 85.0 179/178 179.0");
        }
    }
}
