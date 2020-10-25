
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Doanquanlythuvien_Htmlhelper.Controllers
{
    public class nhaxuatbanController : Controller
    {
        private Doanquanlythuvien.Models.qlsachEntities dc = new Doanquanlythuvien.Models.qlsachEntities();
        // GET: nhaxuatban
        public ActionResult IndexNXB()
        {
            
            return View(dc.NXBs.ToList());
        }
        public ActionResult Formthemnhaxuatban()
        {
            return View();
            //List<Doanquanlythuvien.Models.CNxb> ds = new List<Doanquanlythuvien.Models.CNxb>();
            //foreach (var a in dc.NXBs.ToList())
            //{
            //    Doanquanlythuvien.Models.CNxb nxb = new Doanquanlythuvien.Models.CNxb();
            //    nxb.MaNXB = a.MaNXB;
            //    nxb.TenNXB = a.TenNXB;
            //    ds.Add(nxb);
            //}
            //return View(ds);
        }
        public ActionResult themNhaxuatban(Doanquanlythuvien.Models.NXB xB)
        {
            if (ModelState.IsValid)
            {
                dc.NXBs.Add(xB);
                dc.SaveChanges();
            }
            return RedirectToAction("IndexNXB");
        }
        public ActionResult xoaNhaxuatban(string id)
        {
            Doanquanlythuvien.Models.NXB xB = dc.NXBs.Find(id);
            dc.NXBs.Remove(xB);
            dc.SaveChanges();
            return RedirectToAction("IndexNXB");
        }
        public ActionResult Formsuanhaxuatban(string id)
        {
            Doanquanlythuvien.Models.NXB xB = dc.NXBs.Find(id);
            return View(xB);
        }
        public ActionResult suaNhaxuatban(Doanquanlythuvien.Models.NXB xB)
        {
            Doanquanlythuvien.Models.NXB nXB = dc.NXBs.Find(xB.MaNXB);
            if (nXB != null)
            {
                nXB.MaNXB = xB.MaNXB;
                nXB.TenNXB = xB.TenNXB;
                dc.SaveChanges();
            }
            return RedirectToAction("IndexNXB");
        }
        public ActionResult xemnxb(string id)
        {
            Doanquanlythuvien.Models.NXB xB = dc.NXBs.Find(id);
            return View(xB);
        }
    }
}