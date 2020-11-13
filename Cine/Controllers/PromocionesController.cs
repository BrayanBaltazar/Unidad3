using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cine.Controllers
{
    public class PromocionesController : Controller
    {
        // GET: Promociones
        public ActionResult Index()
        {
            return View();
        }
    }
}