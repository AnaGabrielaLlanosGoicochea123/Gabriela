using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Pruebas.LinnkGlobal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.PruebasSeleniun
{
    [TestFixture]
    public class Home
    {
        ChromeDriver examen = new ChromeDriver();
        [Test]
        public void ClickTema()
        {
            examen.Url = Global.URL;
            examen.FindElementById("usernameId").SendKeys("admin");
            examen.FindElementById("passwordId").SendKeys("admin");
            examen.FindElementById("iniciarId").Click();

            examen.FindElementById("temaLink").Click();

            Assert.IsTrue(examen.Url.EndsWith("/Tema"));
            examen.Close();
        }
    }
}