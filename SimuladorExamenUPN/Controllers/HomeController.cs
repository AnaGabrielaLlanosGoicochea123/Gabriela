using SimuladorExamenUPN.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using SimuladorExamenUPN.Interface;

namespace SimuladorExamenUPN.Controllers
{
   

    [Authorize]
    public class HomeController : Controller
    {
        readonly IExamene iexamene;
        public HomeController(IExamene iexamene)
        {
            this.iexamene = iexamene;

        }
        // GET: HomeExamen
     
        public ActionResult Index()
        {
            var examenes = iexamene.Getexamenes();

            return View(examenes);
        }

        public ActionResult Confirmar(int ExamenId)
        {
            var examen = iexamene.Confirmar(ExamenId);
            return View(examen);
        }

        public ActionResult DarExamen(int ExamenId)
        {

            var examen = iexamene.DarExamen(ExamenId);

            return View(examen);
        }
        
    }
}