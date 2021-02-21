using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insuree = (from c in db.Insurees
                               where c.Quote != 0.00m
                               select c).ToList();
                
                return View(insuree);

            }
            
        }
    }
}