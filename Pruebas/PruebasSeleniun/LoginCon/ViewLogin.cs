using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Pruebas.LinnkGlobal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.PruebasSeleniun.LoginCon
{
    [TestFixture]
    public class ViewLogin
    {
        ChromeDriver examen = new ChromeDriver();
        [Test]
        public void LogeoIsOk()
        {
            examen.Url = Global.URL;
            examen.FindElementById("usernameId").SendKeys("admin");
            examen.FindElementById("passwordId").SendKeys("admin");
            examen.FindElementById("iniciarId").Click();
            Assert.IsTrue(examen.Url.EndsWith("/"));
            examen.Close();
        }
        [Test]
        public void LogeoIsNoOk()
        {
            examen.Url = Global.URL;
            examen.FindElementById("usernameId").SendKeys("Anadaaa");
            examen.FindElementById("passwordId").SendKeys("admin");
            examen.FindElementById("iniciarId").Click();
            Assert.IsTrue(examen.Url.EndsWith("/Usuario/Login"));
            examen.Close();
        }
    }
}
