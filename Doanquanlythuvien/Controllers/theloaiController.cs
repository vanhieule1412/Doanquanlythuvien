using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Doanquanlythuvien_Htmlhelper.Controllers
{
    public class theloaiController : Controller
    {
        private Doanquanlythuvien.Models.qlsachEntities dc = new Doanquanlythuvien.Models.qlsachEntities();
        // GET: theloai
        public ActionResult IndexTL()
        {
            return View(dc.THELOAIs.ToList());
        }
        public ActionResult Fromthemtheloai()
        {
            return View();
        }
        public ActionResult themTheloai(Doanquanlythuvien.Models.THELOAI tHELOAI)
        {
            if (ModelState.IsValid)
            {
                dc.THELOAIs.Add(tHELOAI);
                dc.SaveChanges();
            }
            return RedirectToAction("IndexTL");
        }
        //public ActionResult Formxoatacgia(string id)
        //{
        //    Doanquanlythuvien.Models.TACGIA tACGIA = dc.TACGIAs.Find(id);
        //    return View(tACGIA);
        //}

        public ActionResult xoaTheloai(string id)
        {
            Doanquanlythuvien.Models.THELOAI tHELOAI = dc.THELOAIs.Find(id);
            dc.THELOAIs.Remove(tHELOAI);
            dc.SaveChanges();
            return RedirectToAction("IndexTL");
        }
        public ActionResult Formsuatheloai(string id)
        {
            Doanquanlythuvien.Models.THELOAI tHELOAI = dc.THELOAIs.Find(id);
            return View(tHELOAI);
        }
        public ActionResult suaTheloai(Doanquanlythuvien.Models.THELOAI tHELOAI)
        {
            Doanquanlythuvien.Models.THELOAI hELOAI = dc.THELOAIs.Find(tHELOAI.MaTheLoai);
            if (hELOAI != null)
            {
                hELOAI.MaTheLoai = tHELOAI.MaTheLoai;
                hELOAI.TenTheLoai = tHELOAI.TenTheLoai;
                dc.SaveChanges();
            }
            return RedirectToAction("IndexTL");
        }
        public ActionResult xemTheloai(string id)
        {
            Doanquanlythuvien.Models.THELOAI tHELOAI = dc.THELOAIs.Find(id);
            return View(tHELOAI);
        }


    }
}