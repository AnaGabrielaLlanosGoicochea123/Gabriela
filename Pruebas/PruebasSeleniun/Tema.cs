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
    public class Tema
    {
        ChromeDriver examen = new ChromeDriver();
        [Test]
        public void ClickTema()
        {

            String criterio = "Primera";

            examen.Url = Global.URL;
            examen.FindElementById("usernameId").SendKeys("admin");
            examen.FindElementById("passwordId").SendKeys("admin");
            examen.FindElementById("iniciarId").Click();

            examen.FindElementById("temaLink").Click();
            examen.FindElementById("buscarNombre").SendKeys(criterio);
            examen.FindElementById("buscar").Click();
            Assert.IsTrue(examen.Url.EndsWith("tema/index?criterio="+criterio));
            examen.Close();
        }
        [Test]
        public void ClickTemaCrear()
        {

            examen.Url = Global.URL;
            examen.FindElementById("usernameId").SendKeys("admin");
            examen.FindElementById("passwordId").SendKeys("admin");
            examen.FindElementById("iniciarId").Click();

            examen.FindElementById("temaLink").Click();

            examen.FindElementById("creartemaLink").Click();

            Assert.IsTrue(examen.Url.EndsWith("/Tema/Crear"));
            examen.Close();
        }
        [Test]
        public void ClickTemaCrearAgregar()
        {

            examen.Url = Global.URL;
            examen.FindElementById("usernameId").SendKeys("admin");
            examen.FindElementById("passwordId").SendKeys("admin");
            examen.FindElementById("iniciarId").Click();

            examen.FindElementById("temaLink").Click();

            examen.FindElementById("creartemaLink").Click();


            examen.FindElementById("Nombre").SendKeys("Ana");
            examen.FindElementById("listacategoria").SendKeys("Historia");
            examen.FindElementById("Descripcion").SendKeys("Historia del mundo");

            examen.FindElementById("btnguardartema").Click();

            Assert.IsTrue(examen.Url.EndsWith("/Tema"));
            examen.Close();
        }
    }
}
