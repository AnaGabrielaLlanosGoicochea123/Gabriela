using Moq;
using NUnit.Framework;
using SimuladorExamenUPN.Controllers;
using SimuladorExamenUPN.Interface;
using SimuladorExamenUPN.Models;
using SimuladorExamenUPN.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Pruebas.PruebasUnitarias.Controladores
{
    [TestFixture]
    public class UsuarioControllerTest
    {
        [Test]
        public void DebePoderIngresarUsuario()
        {
            string Username = "Admin";
            string Password = "Admin";

            Usuario usuario = new Usuario()
            {
                Id = 1,
                Nombres = "Ana",
                Password = "Admin",
                Username = "Admin"
            };

            var login = new  Mock<IUsuarioSession>();
            var login2 = new Mock<IUsuario>();

            login2.Setup(p => p.GetUsuario(Username, Password)).Returns(usuario);

            login.Setup(a => a.AutenticaUsername(Username, true));

            var controller = new UsuarioController(login2.Object, login.Object);


            var rederit = controller.Login(Username, Password);

            Assert.IsInstanceOf<RedirectToRouteResult>(rederit);
            Assert.IsNotInstanceOf<ViewResult>(rederit);

        }

    }
}
