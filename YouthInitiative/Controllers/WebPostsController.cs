using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using YouthInitiative.Models;

namespace YouthInitiative.Controllers
{
    public class WebPostsController : Controller
    {
        private WebPostContext db = new WebPostContext();

        // GET: WebPosts
        public ActionResult Index()
        {
            return View(db.WebPosts.ToList());
        }

        // GET: WebPosts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WebPosts webPosts = db.WebPosts.Find(id);
            if (webPosts == null)
            {
                return HttpNotFound();
            }
            return View(webPosts);
        }

        // GET: WebPosts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WebPosts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,userName,message")] WebPosts webPosts)
        {
            if (ModelState.IsValid)
            {
                db.WebPosts.Add(webPosts);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(webPosts);
        }

        // GET: WebPosts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WebPosts webPosts = db.WebPosts.Find(id);
            if (webPosts == null)
            {
                return HttpNotFound();
            }
            return View(webPosts);
        }

        // POST: WebPosts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,userName,message")] WebPosts webPosts)
        {
            if (ModelState.IsValid)
            {
                db.Entry(webPosts).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(webPosts);
        }

        // GET: WebPosts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WebPosts webPosts = db.WebPosts.Find(id);
            if (webPosts == null)
            {
                return HttpNotFound();
            }
            return View(webPosts);
        }

        // POST: WebPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WebPosts webPosts = db.WebPosts.Find(id);
            db.WebPosts.Remove(webPosts);
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
