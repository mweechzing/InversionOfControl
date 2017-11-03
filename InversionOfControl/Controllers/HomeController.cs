using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using SqlIntro;

namespace InversionOfControl.Controllers
{
    public class HomeController : Controller
    {
        [Dependency]
        public IProductRepository ProductRepository { get; set; }
    
        
        

    public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}