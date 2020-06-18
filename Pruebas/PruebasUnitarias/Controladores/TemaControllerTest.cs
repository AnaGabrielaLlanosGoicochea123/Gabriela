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
    public class TemaControllerTest
    {
        [Test]
        public void DebePoderRetonarUnaListadeExamenes()
        {
            var itemas = new Mock<ITemas>();
            /*ar icategorias = new Mock<ICategoria>();*/

            string criterio = "Nombre";

            itemas.Setup(a => a.gettemas(criterio)).Returns(new List<Tema>());

           

            var controller = new TemaController(itemas.Object, null);

            var view = controller.Index(criterio) as ViewResult;


            Assert.IsInstanceOf<List<Tema>>(view.Model);
            Assert.IsInstanceOf<ViewResult>(view);

        }
        [Test]
        public void DebePoderCrear()
        {
           
            var icategorias = new Mock<ICategoria>();

            string criterio = "Nombre";

            icategorias.Setup(a => a.Getcategorias()).Returns(new List<Categoria>());



            var controller = new TemaController(null, icategorias.Object);

            var view = controller.Crear() as ViewResult;


            Assert.IsInstanceOf<Tema>(view.Model);
            Assert.IsInstanceOf<ViewResult>(view);

        }
    }
}
