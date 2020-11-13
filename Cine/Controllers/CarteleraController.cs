using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cine.Controllers
{
    public class CarteleraController : Controller
    {
        // GET: Cartelera
        public ActionResult Index()
        {
            return View();
        }
    }
}