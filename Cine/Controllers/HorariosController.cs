using Cine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cine.Controllers
{
    public class HorariosController : Controller
    {
        readonly HorarioBD db = new HorarioBD();
        // GET: Horarios
        public ActionResult Index()
        {
            var horario = db.Horarios.ToList();

            return View(horario);


        }
        public ActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create(Horarios horarios)
        {
            db.Horarios.Add(horarios);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Delete(int id)
        {
            try
            {
                var horario = db.Horarios.Find(id);
                db.Horarios.Remove(horario);
                db.SaveChanges();
            }
            catch
            {

            }
            return RedirectToAction("index");
        }
    }
}
//        public ActionResult Edit(int id)
//        {
//            var horario = db.Horarios.Find(id);
//            return View(horario);

//        }
//        [HttpPost]
//        public ActionResult Edit(int id,Horarios b)
//        {
//            try
//            {
//                var horario = db.Horarios.Find(id);
//                horario.Nombre = c.Nombre;
//                horario.hora = c.Hora;
//                db.SaveChanges();

//            }
//            catch
//            {

//            }
//            return RedirectToAction("Index");
//        }

//    }

//}