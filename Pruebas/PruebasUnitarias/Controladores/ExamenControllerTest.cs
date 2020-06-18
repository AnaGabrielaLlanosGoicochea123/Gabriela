using Moq;
using NUnit.Framework;
using SimuladorExamenUPN.Controllers;
using SimuladorExamenUPN.Interface;
using SimuladorExamenUPN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Pruebas.PruebasUnitarias.Controladores
{
    [TestFixture]
    public class ExamenControllerTest
    {
        [Test]
        public void DebePoderRetonarUnaListadeExamenes()
        {
            var examen = new Mock<IExamene>();
            var usario = new Mock<IUsuario>();

            Usuario usuario = new Usuario()
            {
                Id = 1,
                Nombres = "Ana",
                Password = "Admin",
                Username = "Admin"
            };

            Examen examens = new Examen()
            {

                Id = 1,
                TemaId = 1,
                UsuarioId = 1,
                EstaActivo = true,
            };

            
            usario.Setup(a => a.setNombreUsuario()).Returns(usuario);
            examen.Setup(a => a.ExamenesUser(usuario)).Returns(new List<Examen>());

            var controller = new ExamenController(usario.Object, examen.Object,null);

            var view = controller.Index() as ViewResult;

            
            Assert.IsInstanceOf<List<Examen>>(view.Model);
            Assert.IsInstanceOf<ViewResult>(view);

        }
       
    }

}