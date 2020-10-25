using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Doanquanlythuvien_Htmlhelper.Controllers
{
    public class sachController : Controller
    {
        
        private Doanquanlythuvien.Models.qlsachEntities dc = new Doanquanlythuvien.Models.qlsachEntities();
        // GET: sach
        public ActionResult IndexS()
        {
            return View(dc.SACHes.ToList());
        }
        
        public ActionResult Fromthemsach()
        {

            //List<SelectListItem> selectListItems = new List<SelectListItem>();
            //foreach (Doanquanlythuvien.Models.NXB nXB in dc.NXBs)
            //{
            //    SelectListItem selectListItem = new SelectListItem
            //    {
            //        Text = nXB.TenNXB.ToString(),
            //        Value = nXB.TenNXB.ToString(),
            //    };
            //    selectListItems.Add(selectListItem);
            //}
            //ViewBag.nXBs = selectListItems;

            
            ViewBag.DSnxb = dc.NXBs.ToList();
            ViewBag.DStacgia = dc.TACGIAs.ToList();
            ViewBag.DStheloai = dc.THELOAIs.ToList();
            //List<Doanquanlythuvien.Models.TACGIA> tACGIAs = dc.TACGIAs.ToList();
            //ViewBag.tACGIAs = new SelectList(tACGIAs, "MaTacGia", "TenTacGia");
            //List<Doanquanlythuvien.Models.THELOAI> tHELOAIs = dc.THELOAIs.ToList();
            //ViewBag.tHELOAIs = new SelectList(tHELOAIs, "MaTheLoai", "TenTheLoai");
            return View();

        }
        [HttpPost]
        public ActionResult themSach(Doanquanlythuvien.Models.SACH sACH)
        {
            if (ModelState.IsValid)
            {
                //List<SelectListItem> selectListItems = new List<SelectListItem>();
                //foreach (var a in dc.NXBs)
                //{
                //    SelectListItem selectListItem = new SelectListItem
                //    {
                //        Text = nXB.MaNXB,
                //        Value = nXB.TenNXB.ToString(),
                //    };
                //    selectListItems.Add(selectListItem);
                //}
                //ViewBag.nXBs = selectListItems;


                dc.SACHes.Add(sACH);
                dc.SaveChanges();
                return RedirectToAction("IndexS");
            }
            ViewBag.DSnxb = dc.NXBs.ToList();
            ViewBag.DStacgia = dc.TACGIAs.ToList();
            ViewBag.DStheloai = dc.THELOAIs.ToList();
            return View("Fromthemsach");
        }

        public ActionResult Fromsuasach()
        {
            List<Doanquanlythuvien.Models.NXB> nXBs = dc.NXBs.ToList();
            ViewBag.nXBs = new SelectList(nXBs, "MaNXB", "TenNXB");
            List<Doanquanlythuvien.Models.TACGIA> tACGIAs = dc.TACGIAs.ToList();
            ViewBag.tACGIAs = new SelectList(tACGIAs, "MaTacGia", "TenTacGia");
            List<Doanquanlythuvien.Models.THELOAI> tHELOAIs = dc.THELOAIs.ToList();
            ViewBag.tHELOAIs = new SelectList(tHELOAIs, "MaTheLoai", "TenTheLoai");
            return View();
        }
        public ActionResult suaSach(Doanquanlythuvien.Models.SACH sACH)
        {
            Doanquanlythuvien.Models.SACH aCH = dc.SACHes.Find(sACH.MaSach);
            if (aCH!=null)
            {
                aCH.MaSach = sACH.MaSach;
                aCH.TenSach = sACH.TenSach;
                //aCH.MaTacGia = sACH.MaTacGia;
                aCH.TenTacGia = sACH.TenTacGia;
                //aCH.MaNXB = sACH.MaNXB;
                aCH.TenNXB = sACH.TenNXB;
                //aCH.MaTheLoai = sACH.MaTheLoai;
                aCH.TenTheLoai = sACH.TenTheLoai;
                aCH.SoLuong = sACH.SoLuong;
                dc.SaveChanges();
                //return RedirectToAction("IndexS");
            }
            return RedirectToAction("IndexS");

            //return View();

        }
        public ActionResult xemSach(string id)
        {
            Doanquanlythuvien.Models.SACH sACH = dc.SACHes.Find(id);
            return View(sACH);
        }
        public ActionResult xoaSach(string id)
        {
            Doanquanlythuvien.Models.SACH sACH = dc.SACHes.Find(id);
            dc.SACHes.Remove(sACH);
            dc.SaveChanges();
            return RedirectToAction("IndexS");
        }
    }
}