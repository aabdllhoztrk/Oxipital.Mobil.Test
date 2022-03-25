using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Oxipital.Mobil.Test.BaseClass
{
    public class BaseTest
    {
        public AppiumDriver<AndroidElement> _driver;

        [SetUp]
        public void Setup()
        {
           
             
            var appPath = @"D:\Projeler\Oxipital\oxipital.flutter\build\app\outputs\apk\debug\app-debug.apk";

            //Platform,Deviecs,Application
            var driverOption = new AppiumOptions();
            driverOption.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            driverOption.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Android 28");
            driverOption.AddAdditionalCapability(MobileCapabilityType.App, appPath);

            


            // driverOption.AddAdditionalCapability("chromedriverExecutable",);
            _driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), driverOption);
            



            Thread.Sleep(3000);
            //var a = _driver.FindElementByXPath("//android.widget.Button[@content-desc='Login']");
        }
    }
}