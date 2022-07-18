using AlumnosCrubNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlumnosCrubNet.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumno
        public ActionResult Index()
        {
            AlumnosContex db = new AlumnosContex();

            //db.Alumno.Where.ToList();

            return View(db.Alumno.ToList());
        }

        public ActionResult Agregar() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(Alumno a)
        {
            return View();
        }

    }
}