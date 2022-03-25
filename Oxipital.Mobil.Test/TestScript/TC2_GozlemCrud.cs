using NUnit.Framework;
using Oxipital.Mobil.Test.BaseClass;
using Oxipital.Mobil.Test.PageObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oxipital.Mobil.Test.TestScript
{
    public class TC2_GozlemCrud : BaseTest
    {
        [Test]
        public void GozlemCrudİslemleri()
        {
            var loginPage = new LoginPage(_driver);
            var homePage = loginPage.LoginOlma();
            var hastalistesiPage = homePage.HastaListesiSayfasinaGit();
            var hastaSayfasiPage = hastalistesiPage.HastaSayfasinaGit();
            var gozlemPage =  hastaSayfasiPage.GozlemSayfasinaGit();
            gozlemPage.GozlemIslemleriEkle();
        }
    }
}
