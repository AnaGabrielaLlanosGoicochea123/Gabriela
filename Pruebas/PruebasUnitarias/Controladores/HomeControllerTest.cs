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
    public class HomeControllerTest
    {
        [Test]
       public void DebePoderRetonarUnaListadeExamenes()
        {
             
            var examen = new Mock<IExamene>();

            examen.Setup(a => a.Getexamenes()).Returns(new List<Examen>());

            var controller = new HomeController(examen.Object);

            var view = controller.Index() as ViewResult;

            Assert.IsInstanceOf<List<Examen>>(view.Model);
            Assert.IsInstanceOf<ViewResult>(view);

        }
        [Test]
        public void DebePoderRetonarConfirmarExaemn()
        {

            var examen = new Mock<IExamene>();

            Examen examens = new Examen()
            {

                Id = 1,
                TemaId = 1,
                UsuarioId = 1,
                EstaActivo = true,
            };

            examen.Setup(a => a.Confirmar(1)).Returns(examens);

            var controller = new HomeController(examen.Object);

            var view = controller.Confirmar(1) as ViewResult;

            Assert.IsInstanceOf<Examen>(view.Model);
            Assert.IsInstanceOf<ViewResult>(view);

        }
        [Test]
        public void DebePoderDarExamen()
        {

            var examen = new Mock<IExamene>();

            Examen examens = new Examen()
            {

                Id = 1,
                TemaId = 1,
                UsuarioId = 1,
                EstaActivo = true,
            };

            examen.Setup(a => a.DarExamen(1)).Returns(examens);

            var controller = new HomeController(examen.Object);

            var view = controller.DarExamen(1) as ViewResult;

            Assert.IsInstanceOf<Examen>(view.Model);
            Assert.IsInstanceOf<ViewResult>(view);

        }
    }
}
