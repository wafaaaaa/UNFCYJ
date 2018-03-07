using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CYJ.Models;

namespace CYJ.Controllers
{
    [Authorize]
    public class AboutController : Controller
    {
        private UNFCYJEntities db = new UNFCYJEntities();

        // GET: About
        public ActionResult Index()
        {
            return View(db.POSTs.ToList());
        }

        // GET: About/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            POST pOST = db.POSTs.Find(id);
            if (pOST == null)
            {
                return HttpNotFound();
            }
            return View(pOST);
        }

        // GET: About/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: About/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "postID,postTitle,postContent,createTime,updateTime")] POST pOST)
        {
            if (ModelState.IsValid)
            {
                db.POSTs.Add(pOST);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pOST);
        }

        // GET: About/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            POST pOST = db.POSTs.Find(id);
            if (pOST == null)
            {
                return HttpNotFound();
            }
            return View(pOST);
        }

        // POST: About/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "postID,postTitle,postContent,createTime,updateTime")] POST pOST)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pOST).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pOST);
        }

        // GET: About/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            POST pOST = db.POSTs.Find(id);
            if (pOST == null)
            {
                return HttpNotFound();
            }
            return View(pOST);
        }

        // POST: About/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            POST pOST = db.POSTs.Find(id);
            db.POSTs.Remove(pOST);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Home ()
        {
            return View(db.POSTs.ToList());
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
