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
    public class VideoUrlsController : Controller
    {
        private VideoUrlsDBContext db = new VideoUrlsDBContext();

        // GET: VideoUrls
        public ActionResult Index()
        {
            return View(db.VideoUrls.ToList());
        }

        // GET: VideoUrls/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VideoUrls videoUrls = db.VideoUrls.Find(id);
            if (videoUrls == null)
            {
                return HttpNotFound();
            }
            return View(videoUrls);
        }

        // GET: VideoUrls/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VideoUrls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,url,userName")] VideoUrls videoUrls)
        {
            if (ModelState.IsValid)
            {
                db.VideoUrls.Add(videoUrls);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(videoUrls);
        }

        // GET: VideoUrls/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VideoUrls videoUrls = db.VideoUrls.Find(id);
            if (videoUrls == null)
            {
                return HttpNotFound();
            }
            return View(videoUrls);
        }

        // POST: VideoUrls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,url,userName")] VideoUrls videoUrls)
        {
            if (ModelState.IsValid)
            {
                db.Entry(videoUrls).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(videoUrls);
        }

        // GET: VideoUrls/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VideoUrls videoUrls = db.VideoUrls.Find(id);
            if (videoUrls == null)
            {
                return HttpNotFound();
            }
            return View(videoUrls);
        }

        // POST: VideoUrls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VideoUrls videoUrls = db.VideoUrls.Find(id);
            db.VideoUrls.Remove(videoUrls);
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
