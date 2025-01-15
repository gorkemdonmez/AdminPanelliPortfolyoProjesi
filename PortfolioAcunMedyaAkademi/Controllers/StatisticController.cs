﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioAcunMedyaAkademi.Models;

namespace PortfolioAcunMedyaAkademi.Controllers
{
    public class StatisticController : Controller
    {
        DbPortfolioEntities db=new DbPortfolioEntities();
        public ActionResult Index()
        {
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.projectCount = db.TblProject.Count();
            ViewBag.skillCount = db.TblSkill.Count();
            ViewBag.skillAvgValue = db.TblSkill.Average(x=> x.Value);
            ViewBag.lastSkillTitleName = db.GetLastSkillTitle().FirstOrDefault();
            ViewBag.mvcCategoryProjectCount = db.TblProject.Where(x => x.ProjectCategory ==4).Count();
            ViewBag.TestimonialCount = db.TblTestimonial.Count();
            ViewBag.ServiceCount = db.TblService.Count();
            ViewBag.FeatureCount = db.TblFeature.Count();
            ViewBag.AboutCount = db.TblAbout.Count();

            return View();
        }
    }
}