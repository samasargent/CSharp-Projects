using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        public decimal CalculateQuote(Insuree insuree)
        {
            decimal quote = 50.00m;
            // START AGE SECTION
            int userAge = DateTime.Now.Year - insuree.DateOfBirth.Year;
            if (userAge <= 18)
            {
                quote += 100.00m;
            }
            else if (userAge > 18 && userAge < 26)
            {
                quote += 50.00m;
            }
            else
            {
                quote += 25.00m;
            }
            // END AGE SECTION
            // START CAR YEAR SECTION
            if (insuree.CarYear < 2000)
            {
                quote += 25.00m;
            }
            else if (insuree.CarYear > 2015)
            {
                quote += 25.00m;
            }    
            else
            {
                quote += 0.00m;
            }
            // END CAR YEAR SECTION
            // START CAR MAKE SECTION
            if (insuree.CarMake.ToLower() == "porsche")
            {
                quote += 25.00m;
            }
            if (insuree.CarMake.ToLower() == "porsche" && insuree.CarModel.ToLower() == "911 carrera")
            {
                quote += 25.00m;
            }
            // END CAR MAKE SECTION
            // START SPEEDING TICKET SECTION
            int ticketFee = insuree.SpeedingTickets * 10;
            quote += Convert.ToDecimal(ticketFee);
            // END SPEEDING TICKET SECTION
            // START DUI SECTION
            if (insuree.DUI == true)
            {
                decimal duiCharge = quote * 0.25m;
                quote += duiCharge;
            }
            // END DUI SECTION
            // START COVERAGE SECTION
            if (insuree.CoverageType == true)
            {
                decimal coverageCharge = quote * 0.50m;
                quote += coverageCharge;
            }
            // END COVERAGE SECTION
            return quote;
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = CalculateQuote(insuree);
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = CalculateQuote(insuree);
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }
    }
}
