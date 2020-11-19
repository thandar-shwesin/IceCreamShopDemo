using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IceCreamShopDemo.Controllers
{
    public class IceCreamController : Controller
    {
        // GET: IceCream
        public ActionResult Index()
        {
            return View();
        }
    }
}