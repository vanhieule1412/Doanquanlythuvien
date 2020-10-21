using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Doanquanlythuvien_Htmlhelper.Controllers
{
    public class tacgiaController : Controller
    {
        private Doanquanlythuvien.Models.qlsachEntities dc = new Doanquanlythuvien.Models.qlsachEntities();
        // GET: tacgia
        public ActionResult IndexTG()
        {
            return View(dc.TACGIAs.ToList());
        }
        public ActionResult Formthemtacgia()
        {
            return View();
        }
        public ActionResult themTacgia(Doanquanlythuvien.Models.TACGIA tACGIA)
        {
            if (ModelState.IsValid)
            {
                dc.TACGIAs.Add(tACGIA);
                dc.SaveChanges();
            }
            return RedirectToAction("IndexTG");
        }
        //public ActionResult Formxoatacgia(string id)
        //{
        //    Doanquanlythuvien.Models.TACGIA tACGIA = dc.TACGIAs.Find(id);
        //    return View(tACGIA);
        //}
       
        public ActionResult xoaTacgia(string id)
        {
            Doanquanlythuvien.Models.TACGIA tACGIA = dc.TACGIAs.Find(id);
            dc.TACGIAs.Remove(tACGIA);
            dc.SaveChanges();
            return RedirectToAction("IndexTG");
        }
        public ActionResult Formsuatacgia(string id)
        {
            Doanquanlythuvien.Models.TACGIA tACGIA = dc.TACGIAs.Find(id);
            return View(tACGIA);
        }
        public ActionResult suaTacgia(Doanquanlythuvien.Models.TACGIA tACGIA)
        {
            Doanquanlythuvien.Models.TACGIA aCGIA = dc.TACGIAs.Find(tACGIA.MaTacGia);
            if (aCGIA != null)
            {
                aCGIA.MaTacGia = tACGIA.MaTacGia;
                aCGIA.TenTacGia = tACGIA.TenTacGia;
                dc.SaveChanges();
            }
            return RedirectToAction("IndexTG");
        }
        public ActionResult xemtg(string id)
        {
            Doanquanlythuvien.Models.TACGIA tACGIA = dc.TACGIAs.Find(id);
            return View(tACGIA);
        }
    }
}