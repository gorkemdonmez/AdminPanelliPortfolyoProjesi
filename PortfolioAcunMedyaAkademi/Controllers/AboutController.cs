using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioAcunMedyaAkademi.Models;

namespace PortfolioAcunMedyaAkademi.Controllers
{
    public class AboutController : Controller
    {
        DbPortfolioEntities db = new DbPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TblAbout.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]

        public ActionResult CreateAbout(TblAbout P)
        {
            db.TblAbout.Add(P);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteAbout(int id)
        {
            var value = db.TblAbout.Find(id);
            db.TblAbout.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
         
            var value = db.TblAbout.Find(id);
            return View (value);
        }
        [HttpPost]
        public ActionResult UpdateAbout (TblAbout P)
        {
            var value = db.TblAbout.Find(P.AboutId);
            value.Title = P.Title;
            value.Description = P.Description;
            value.ImageUrl = P.ImageUrl;
            db.SaveChanges ();
            return RedirectToAction("Index");
        }

    }
}