using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioAcunMedyaAkademi.Models;

namespace PortfolioAcunMedyaAkademi.Controllers
{
    public class DefaultController : Controller
    {
        DbPortfolioEntities db = new DbPortfolioEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            var values = db.TblFeature.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAbout()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialSkill()
        {
            var values = db.TblSkill.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialStatistic()
        {
            var skillcount = db.TblSkill.ToList().Count();
            ViewBag.SkillCount = skillcount;
            var Projectcount = db.TblProject.ToList().Count();
            ViewBag.ProjectCount = Projectcount;
            var TestimonialCount = db.TblTestimonial.ToList().Count();
            ViewBag.TestimonialCount = TestimonialCount;
            var ServiceCount = db.TblService.ToList().Count();
            ViewBag.ServiceCount = ServiceCount;
            return PartialView();
        }
        public PartialViewResult PartialServices()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialContact()
        {
            var values = db.TblContact.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialBanner()
        {
            var values = db.TblBanner.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialProject()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTestimonial()
        {
            var values = db.TblTestimonial.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialFooter()
        {
            var values = db.TblContact.ToList();
            return PartialView(values);
        }
    }
}
