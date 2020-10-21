using Doanquanlythuvien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Doanquanlythuvien_Htmlhelper.Controllers
{
    public class HomeController : Controller
    {
        // private Doanquanlythuvien.Models.qlsachEntities dc = new Doanquanlythuvien.Models.qlsachEntities();
        //GET: Home
        
        public ActionResult Index()
        {
            //List<NXB> nXBs  = db.NXBs.ToList();
            //ViewBag.nXBs = new SelectList(nXBs, "MaNXB", "TenNXB");
            return View();
        }

    }
}