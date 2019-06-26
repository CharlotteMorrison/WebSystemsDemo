using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OspreyOlympiansGold.Models;

namespace OspreyOlympiansGold.Controllers
{
    public class UsersController : Controller
    {
        private Customers db = new Customers();

        // GET: Users
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        // GET: Users/Details/5
        public ActionResult CheckoutDetails(int? id)
        {
            id = 1; //for testing, remove after
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            List<String> features = new List<String>();
            if (user.Plan == 1)
            {
                ViewBag.Plan = "Plan 1";
                features.Add("Access to basic gym equipment and indoor track");
                features.Add("3x use of spa services such as tanning bed and sauna");
                features.Add("1 free session with a personal trainer");
                ViewBag.Cost = " $12/month *12 month contract";
            }
            else if(user.Plan == 2){
                ViewBag.Plan = "Plan 2";
                features.Add("Access to basic gym equipment and indoor track");
                features.Add("3x use of spa services such as tanning bed and sauna");
                features.Add("1 free session with a personal trainer");
                features.Add("Month-to-month, no commitment payment");
                ViewBag.Cost = " $15/month *NO contract";
            }
            else
            {
                ViewBag.Plan = "Plan 3";
                features.Add("Access to basic gym equipment and indoor track");
                features.Add("Access to tennis court and basketball court");
                features.Add("Unlimited use of spa services such as tanning bed and sauna");
                features.Add("5 free sessions with a personal trainer");
                ViewBag.Cost = " $18/month *Unlimited Access";
            }
            ViewBag.Features = features;
            return View(user);
        }

        // GET: Users/Create
        public ActionResult CreateAccount()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateAccount([Bind(Include = "Id,FirstName,LastName,UserName,Password,Email,Street_Address,City,State,Zip,Phone,Plan")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("CheckoutDetails", new { id = user.Id });
            }

            return View(user);
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,UserName,Password,Email,Street_Address,City,State,Zip,Phone")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
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
    }
}
