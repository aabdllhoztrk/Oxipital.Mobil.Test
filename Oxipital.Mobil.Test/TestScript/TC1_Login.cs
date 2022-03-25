using NUnit.Framework;
using Oxipital.Mobil.Test.BaseClass;
using Oxipital.Mobil.Test.PageObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oxipital.Mobil.Test.TestScript
{
    public class TC1_Login : BaseTest
    {
        [Test]
        public void LoginOlma() 
        {
            var loginPage = new LoginPage(_driver);
            var  homePage = loginPage.LoginOlma();
            homePage.CikisYap();                   
        }
    }
}
